using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using static DVLD_BusinessLayer.clsTestType;

namespace DVLD_Project.Forms.TestForms.Controls
{
    public partial class ctrlScheduledTest : UserControl
    {
        private clsTestAppointment? _TestAppointment;

        private clsLocalDrivingLicenseApplication? _LocalDrivingLicenseApplication; 

        private int _TestAppointmentID {  get; set; }   

        private int _TestID { set; get; }
        public int TestAppointmentID { get { return _TestAppointmentID; } set { _TestAppointmentID = value;  } }

        public int TestID { get { return _TestID; } }


        private clsTestType.enTestType _TestTypeID;
        public clsTestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {

                    case clsTestType.enTestType.VisionTest:
                        {
                            pictureBox1.Image = Resources.eye_scan;
                            break;
                        }

                    case clsTestType.enTestType.WrittenTest:
                        {
                            pictureBox1.Image = Resources.testing;
                            break;
                        }
                    case clsTestType.enTestType.StreetTest:
                        {
                            pictureBox1.Image = Resources.street;
                            break;
                        }
                }
            }
        }


        public ctrlScheduledTest()
        {
            InitializeComponent();
        }


        public void LoadTestInfo(int TestAppoinmentID)
        {
            _TestAppointment = clsTestAppointment.Find(TestAppoinmentID);
            //incase we did not find any appointment .
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }
            _TestID = _TestAppointment.TestID;
            lbLocalDrivingAppID.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();
            
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingApplicationByID(_TestAppointment.LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _TestAppointment.LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbApplicantName.Text = _LocalDrivingLicenseApplication.PersonInfo.FullName;
            lbLocalDrivingAppClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lbTestFees.Text = _TestAppointment.PaidFees.ToString(); 
            lbDate.Text = _TestAppointment.AppointmentDate.ToShortDateString();
            lbTries.Text = clsTestAppointment.HowManyTimeUserdoingTest(_LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, _TestAppointment.TestTypeID).ToString();
            lbIsTakenMeassage.Text = _TestID == -1 ? "Test Not Taken yet" : _TestID.ToString(); 

        }



    }
}
