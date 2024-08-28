using DVLD_BusinessLayer;



namespace DVLD_Project.Forms.ApplicationsForms.Controls
{
    public partial class ctrlApplicationInfo : UserControl
    {

        private clsLocalDrivingLicenseApplication? _LocalDrivingLicenseApplication;

        private int _LocalDrivingApplicationID { set; get; }
        public int LocalDrivingApplicationID
        {
            get { return _LocalDrivingApplicationID; }
        }

        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }


        private void ctrlApplicationInfo_Load(object sender, EventArgs e)
        {


        }

        public void LoadLocalDrivingApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindLocalDrivingApplicationByID(LocalDrivingLicenseApplicationID);
            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LocalDrivingApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;

            _FillLocalDrivingLicenseApplicationInfo();

        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            lbApplicantName.Text = _LocalDrivingLicenseApplication.PersonInfo.FullName;
            lbApplicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToShortDateString(); 
            lbApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lbLDAppId.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lbApplicationStatus.Text = _LocalDrivingLicenseApplication.StatusText;
            lbAppliedForLicense.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName; 
            lbApplicationStatusDate.Text = _LocalDrivingLicenseApplication.LastStatusDate.ToShortDateString();
            lbApplicationType.Text = _LocalDrivingLicenseApplication.applicationTypeInfo.ApplicationTitle;
            lbCreatedBy.Text = _LocalDrivingLicenseApplication.CreatedByUserInfo.UserName;
            lbPassedTests.Text = clsLocalDrivingLicenseApplication.NumberOfPassedOrFaildTests(LocalDrivingApplicationID, 1).ToString(); 
        }



        private void linkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*frmPersonDetails frmPersonDetails = new frmPersonDetails();
            frmPersonDetails.ShowDialog();*/
        }

      
    }
}
