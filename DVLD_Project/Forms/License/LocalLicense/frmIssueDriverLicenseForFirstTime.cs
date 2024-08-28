using CoreDVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.ApplicationsForms
{
    public partial class frmIssueDriverLicenseForFirstTime : Form
    {

        private int _LocalDrivingApllication { set; get; }

        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication; 
        public frmIssueDriverLicenseForFirstTime(int localDrivingApllication)
        {
            InitializeComponent();
            _LocalDrivingApllication = localDrivingApllication;
        }
        private void frmIssueDriverLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.LoadLocalDrivingApplicationInfo(_LocalDrivingApllication);
        }

        private void btnIssueTest_Click(object sender, EventArgs e)
        {
            //check if the Applicant is already Driver in System 
          int LicenseID = 
                _LocalDrivingLicenseApplication.IssueLicenseForTheFirtTime(txtNotes.Text, clsUserSettings.CurrentUser.UserID);

            if (LicenseID == -1)
            {
                MessageBox.Show("License Was not Issued ! ",
                "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                     "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
