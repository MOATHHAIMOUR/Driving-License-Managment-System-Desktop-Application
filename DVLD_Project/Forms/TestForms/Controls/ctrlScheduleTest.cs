using CoreDVLD;
using DVLD_BusinessLayer;
using DVLD_Project.Properties;

namespace DVLD_Project.Forms.TestForms.Controls
{
    public partial class ctrlScheduleTest : UserControl
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;



        private clsTestType.enTestType _TestTypeID;
        public clsTestType.enTestType TestType
        {
            get { return _TestTypeID; }
            set
            {

                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case clsTestType.enTestType.VisionTest:
                        picTest.BackgroundImage = Resources.eye_scan;
                        break;

                    case clsTestType.enTestType.WrittenTest:
                        picTest.BackgroundImage = Resources.test2;
                        break;

                    case clsTestType.enTestType.StreetTest:
                        picTest.BackgroundImage = Resources.street;
                        break;
                }
            }
        }


        private clsLocalDrivingLicenseApplication? _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestAppointment? _TestAppointment;
        private int _TestAppointmentID = -1;



        public ctrlScheduleTest()
        {
            InitializeComponent();
        }


        public void LoadInfo(int LocalDrivingLicenseApplicationID, int AppointmentID = -1)
        {
            // if no appointment id this means AddNew mode otherwise it's update mode.
            if (AppointmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            // Application Info
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestAppointmentID = AppointmentID;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingApplicationByID(_LocalDrivingLicenseApplicationID);

            // Error if there is no LocalDrivingApplication
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            // Fill LocalDrivingApplication Info to contorl
            lbLocalDrivingAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lbLocalDrivingAppClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lbPersonName.Text = _LocalDrivingLicenseApplication.FullName;


            // decide if the createion mode is retake test or not based if the person attended this test before
            if (_LocalDrivingLicenseApplication.DoesAttendTestType(_LocalDrivingLicenseApplicationID, _TestTypeID))
                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;


            if (_CreationMode == enCreationMode.RetakeTestSchedule)
            {
                //get the price for retake test
                lbRetakeApplicationFees.Text = clsApplicationType.Find(clsApplication.enApplicationType.RetakeTest).ApplicationFees.ToString();
                gbApplicationInfo.Enabled = true;
                lbHeader.Text = "Schedule Retake Test";
                lbRetakeTestID.Text = "0";
                //this will show the trials for this test before  
                lbNumberOfTries.Text = clsTestAppointment.HowManyTimeUserdoingTest(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, _TestTypeID).ToString();
            }
            else
            {
                gbApplicationInfo.Enabled = false;
                lbHeader.Text = "Schedule Test";
                lbRetakeApplicationFees.Text = "0";
                lbRetakeTestID.Text = "N/A";
                lbNumberOfTries.Text = "0";
            }


            if (_Mode == enMode.AddNew)
            {
                lbTestFees.Text = clsTestType.Find(_TestTypeID)!.Fees.ToString();
                dateTest.MinDate = DateTime.Now;
                lbRetakeTestID.Text = "N/A";
                _TestAppointment = new clsTestAppointment();
            }
            else
            {
                if (!_LoadTestAppointmentData())
                    return;
            }


            lbTotalFees.Text = (Convert.ToSingle(lbRetakeApplicationFees.Text) + Convert.ToSingle(lbTestFees.Text)).ToString();


            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePrviousTestConstraint())
                return;


        }


        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                lbMessage.Text = "Person Already have an active appointment for this test";
                btnSave.Enabled = false;
                dateTest.Enabled = false;
                return false;
            }
            return true;
        }


        private bool _HandleAppointmentLockedConstraint()
        {
            //if appointment is locked that means the person already sat for this test
            //we cannot update locked appointment
            if (_TestAppointment.IsLocked)
            {
                lbMessage.Visible = true;
                lbMessage.Text = "Person already sat for the test, appointment loacked.";
                dateTest.Enabled = false;
                btnSave.Enabled = false;
                return false;

            }
            else
                lbMessage.Visible = false;

            return true;
        }

        private bool _HandlePrviousTestConstraint()
        {
            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    lbMessage.Visible = false;

                    return true;

                case clsTestType.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.
                    if (!clsLocalDrivingLicenseApplication.DoesPassTestType(_LocalDrivingLicenseApplicationID, clsTestType.enTestType.VisionTest))
                    {
                        lbMessage.Text = "Cannot Sechule, Vision Test should be passed first";
                        lbMessage.Visible = true;
                        btnSave.Enabled = false;
                        dateTest.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lbMessage.Visible = false;
                        btnSave.Enabled = true;
                        dateTest.Enabled = true;
                    }


                    return true;

                case clsTestType.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    if (!clsLocalDrivingLicenseApplication.DoesPassTestType(_LocalDrivingLicenseApplicationID, clsTestType.enTestType.WrittenTest))
                    {
                        lbMessage.Text = "Cannot Sechule, Written Test should be passed first";
                        lbMessage.Visible = true;
                        btnSave.Enabled = false;
                        dateTest.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lbMessage.Visible = false;
                        btnSave.Enabled = true;
                        dateTest.Enabled = true;
                    }


                    return true;

            }
            return true;

        }

        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            lbTestFees.Text = _TestAppointment.PaidFees.ToString();

            //we compare the current date with the appointment date to set the min date.
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dateTest.MinDate = DateTime.Now;
            else
                dateTest.MinDate = _TestAppointment.AppointmentDate;

            dateTest.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationInfo == null)
            {
                lbRetakeApplicationFees.Text = "0";
                lbRetakeTestID.Text = "N/A";
            }
            else
            {
                lbRetakeApplicationFees.Text = _TestAppointment.RetakeTestApplicationInfo.PaidFees.ToString();
                gbRetakeTest.Enabled = true;
                lbHeader.Text = "Schedule Retake Test";
                lbRetakeTestID.Text = _TestAppointment.RetakenTestApplicationID.ToString();
            }

            return true;
        }

        private void ctrlScheduleTest_Load(object sender, EventArgs e)
        {

        }
        private bool _HandleRetakeApplication()
        {
            if (dateTest.Value < DateTime.Now)
            {
                MessageBox.Show("You cant revrese an appoitment in past");
                return false; 
            }

            //this will decide to create a seperate application for retake test or not.
            // and will create it if needed , then it will linkit to the appoinment.
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                //incase the mode is add new and creation mode is retake test we should create a seperate application for it.
                //then we linke it with the appointment.

                //First Create Applicaiton 
                clsApplication Application = new clsApplication();

                Application.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationType.Find(clsApplication.enApplicationType.RetakeTest).ApplicationFees;
                Application.CreatedByUserID = clsUserSettings.CurrentUser.UserID;

                if (!Application.Save())
                {
                    _TestAppointment.RetakenTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakenTestApplicationID = Application.ApplicationID;

            }
            return true;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;

          
            _TestAppointment.AppointmentDate = dateTest.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(lbTestFees.Text);
            _TestAppointment.CreatedByUserID = clsUserSettings.CurrentUser.UserID;
            

            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
