using CoreDVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.ApplicationsForms.RenewLocalDrivingLicense
{
    public partial class frmRenewLicenseApplication : Form
    {


        private clsApplicationType _ApplicationType { set; get; }
        public frmRenewLicenseApplication()
        {
            InitializeComponent();
        }


        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            linkLicenseHistory.Enabled = false;
            linkShowLicenseInfo.Enabled = false; 
            //get Application information 
            _ApplicationType = clsApplicationType.Find(clsApplication.enApplicationType.RenewDrivingLicense)!;
            lbAppDate.Text = DateTime.Now.ToString("d");
            lbIssue_Date.Text = DateTime.Now.ToString("d");
            lbAppFees.Text = _ApplicationType.ApplicationFees.ToString();
            lbCreatedBy.Text = clsUserSettings.CurrentUser.UserName;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense? NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense();

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lbRLAppID.Text = NewLicense.ApplicationID.ToString();
            lbRLID.Text = NewLicense.LicenseID.ToString();
            MessageBox.Show("Licensed Renewed Successfully with ID=" + NewLicense.LicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            linkShowLicenseInfo.Enabled = true;
        }

        private void btnShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*  frmShowLicensesHistory showLicensesHistory = new frmShowLicensesHistory(PersonID); 
              showLicensesHistory.ShowDialog();   */
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;
            lbOldLicenseID.Text = SelectedLicenseID.ToString();
            linkLicenseHistory.Enabled = SelectedLicenseID != -1;
            if (SelectedLicenseID == -1)
                return;


            int DefualtValideltyLenght = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefaultValidityLength;
            lbExppDate.Text = DateTime.Now.AddYears(DefualtValideltyLenght).ToShortTimeString();
            lbLicenseFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ClassFees.ToString(); 
            lbTotalFees.Text = (Convert.ToInt32(lbAppFees.Text)  + Convert.ToInt32(lbLicenseFees.Text)).ToString(); 
            

            //cheek if License not Expired 
            if(!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate.ToShortDateString()
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;

            }


            //cheek if License is not Active 
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                     , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;

            }

            btnRenew.Enabled = true;
        }
    }
}
