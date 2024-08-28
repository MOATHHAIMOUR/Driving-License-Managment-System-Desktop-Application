using CoreDVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.ApplicationsForms.DetainLicense
{
    public partial class frmDetainLicense : Form
    {
        private int _LicenseID = -1; 

        public frmDetainLicense()
        {
            InitializeComponent();
        }


        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lbDetainDate.Text = DateTime.Now.ToShortDateString();
            lbCreatedBy.Text = clsUserSettings.CurrentUser.UserName; 
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsDetainLicense? DetainLicense =

                       ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainLicense(Convert.ToDecimal(txtFines), clsUserSettings.CurrentUser.UserID); ;
           
            if (DetainLicense == null)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbDetainID.Text = DetainLicense.DetainID.ToString();
            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false; 


        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            if (_LicenseID == -1)
            {
                return; 
            }

            linkLicenseInfo.Enabled = true;
            linkShowLicenseHistory.Enabled = true; 
           

            // check if License is Detain 
            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            
            btnDetain.Enabled = true;

           

        }
    }
}
