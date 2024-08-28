using CoreDVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.ApplicationsForms
{
    public partial class frmAddUpdateLocalDrivingLicesnseApplication : Form
    {


        public enum enMode { addNew, Update }
        public enMode _Mode { set; get; }

        private int _LocalDrivingLicenseApplicationID { set; get; }
        private int _SelectedPersonID { set; get; }

        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;



        //Person Information
        public clsPerson Person { set; get; }


        public frmAddUpdateLocalDrivingLicesnseApplication()
        {
            InitializeComponent();
        }

        public frmAddUpdateLocalDrivingLicesnseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }




        private void tbUser_Selecting(object sender, TabControlCancelEventArgs e)
        {/*
            if (this.ctrlPersonDetailsWithFilter1.Person == null)
            {
                e.Cancel = true; // Prevents the tab from changing
            }*/
        }

        private void _FillLicenseClassesInComoboBox()
        {
            //cbLicenseClases.DataSource = clsLicenseClass.GetAllLicensesClases();
            cbLicenseClases.DisplayMember = "ClassName";
            cbLicenseClases.ValueMember = "LicenseClassID";
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillLicenseClassesInComoboBox();


            if (_Mode == enMode.addNew)
            {

                lbHeader.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                tbApplication.Enabled = false;
                cbLicenseClases.SelectedIndex = 2;
                lbApplicationFees.Text = clsApplicationType.Find(clsApplication.enApplicationType.NewDrivingLicense)!.ApplicationFees.ToString();
                lbApplicationDate.Text = DateTime.Now.ToShortDateString();
                lbCreatedBy.Text = clsUserSettings.CurrentUser.UserName;
            }
            else
            {
                lbHeader.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";
                tbApplication.Enabled = true;
                btnSave.Enabled = true;
            }

        }



        private void frmNewLocalDrivingApplication_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void _LoadData()
        {

            ctrlPersonDetailsWithFilter1.FilterEnabeld = false;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingApplicationByID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            ctrlPersonDetailsWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            lbLocalDrivingApplicationApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lbApplicationDate.Text = (_LocalDrivingLicenseApplication.ApplicationDate).ToShortDateString();
            cbLicenseClases.SelectedIndex = cbLicenseClases.FindString(clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID)!.ClassName);
            lbApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lbCreatedBy.Text = clsUser.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID)!.UserName;

        }


        private bool checkIsAgeValid(int LicenseClassID)
        {
            // Replace with actual date of birth
            DateTime dateOfBirth = new DateTime(Person.DateOfBirth.Year, Person.DateOfBirth.Month, Person.DateOfBirth.Day);
            DateTime currentDate = DateTime.Now;

            int age = Convert.ToInt32(currentDate.Year - dateOfBirth.Year);

            return age >= clsLicenseClass.Find(LicenseClassID)!.MinimumAllowedAge;
        }

        private bool IsApplicantHaveBusinessRules()
        {
            if (!checkIsAgeValid((int)cbLicenseClases.SelectedValue!))
                return false;

            return true;
        }


        private void ctrlPersonDetailsWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!IsApplicantHaveBusinessRules())
            {
                MessageBox.Show("your age is not valid for this License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ActiveApplicationID = clsLocalDrivingLicenseApplication.CheckPersonIsHaveAnActiveLicense(_SelectedPersonID, clsApplication.enApplicationType.NewDrivingLicense, (int)cbLicenseClases.SelectedValue!); 
            
            if (ActiveApplicationID != -1)
            {
                // Found an Applicant with Active License Applicantion, prevernt from regester new one because it's same type
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if user already have issued license of the same driving  class.
            if (clsLicense.IsLicenseExistByPersonID(_SelectedPersonID, (int)cbLicenseClases.SelectedValue!))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = _SelectedPersonID; ;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToDecimal(lbApplicationFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsUserSettings.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = (int)cbLicenseClases.SelectedValue!;


            if (_LocalDrivingLicenseApplication.Save())
            {
                lbLocalDrivingApplicationApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lbHeader.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            lbHeader.Text = "Edit Local License Application";
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.Person != null)
            {
                tbApplication.SelectedIndex++;
            }
            else
            {
                MessageBox.Show("You must Select Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboLicenseClases_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
