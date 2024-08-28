using CoreDVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.ApplicationsForms.ReleaseDetainLicense
{
    public partial class frmReleaseDetainLicense : Form
    {


        private int _LicenseID = -1;
        public frmReleaseDetainLicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }


        private void frmReleaseDetainLicense_Load(object sender, EventArgs e)
        {
          
            if (_LicenseID != -1)
            {
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false; 
                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
            }

        }


        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            _LicenseID = obj;

            if (_LicenseID == -1)
                return;

            linkShowLicenseHistory.Enabled = true;  

            //cheek if the license is detain 
            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbApppFees.Text = clsApplicationType.Find(clsApplication.enApplicationType.ReleaseDetainedDrivingLicense)!.ApplicationFees.ToString();
            lbCreatedBy.Text = clsUserSettings.CurrentUser.UserName; 
            btnRelease.Enabled = true;
            lbDetainID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lbLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();
            lbDetainDate.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate.ToShortDateString();
            lbFineFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lbTotalFees.Text = (Convert.ToDecimal(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString()) + Convert.ToDecimal(lbApppFees)).ToString(); 

             btnRelease.Enabled = true;
        
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsDetainLicense clsDetain = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainLicense(clsUserSettings.CurrentUser.UserID); 

            if (clsDetain == null)
            {
                MessageBox.Show("Faild to to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            linkLicenseInfo.Enabled = true;

        }

       
    }
}
