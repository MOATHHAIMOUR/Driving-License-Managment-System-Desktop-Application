using CoreDVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.ApplicationsForms
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : Form
    {


        private int _NewLicenseID = -1;

        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            int SelectedLicenseID = obj;
            lbOldLicenseID.Text = SelectedLicenseID.ToString();
            btnlinkShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID==-1)
            {
                return; 
            }

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReplacment.Enabled = false;
                return;
            }

            btnReplacment.Enabled = true;
        }



        private void btnReplacment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsLicense? NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(), clsUserSettings.CurrentUser.UserID);



            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lbLRAppID.Text = NewLicense.ApplicationID.ToString();
            lbRLID.Text = NewLicense.LicenseID.ToString();
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            btnReplacment.Enabled = false;
            gbReplecmentFor.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            linkShowLicenseInfo.Enabled = true;

        }

        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use accirding 
            // to user selection.

            if (rdDamageLicense.Checked)

                return (int)clsApplication.enApplicationType.ReplacementDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplacementLostDrivingLicense;
        }

        private clsLicense.enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rdDamageLicense.Checked)

                return clsLicense.enIssueReason.DamagedReplacement;
            else
                return clsLicense.enIssueReason.LostReplacement;
        }


        private void LostOrDamage_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (((RadioButton)sender).Text == "License Damage")
            {
                `enumApplicationType = enumApplicationTypes.ReplacementDamagedDrivingLicense;
            }
            else
            {
                enumApplicationType = enumApplicationTypes.ReplacementLostDrivingLicense ;
            }*/
        }

        private void rdDamageLicense_CheckedChanged(object sender, EventArgs e)
        {
            lbHeader.Text = "Replacement for Damaged License";
            this.Text = lbHeader.Text;
            lbAppFees.Text = clsApplicationType.Find((clsApplication.enApplicationType)_GetApplicationTypeID())!.ApplicationFees.ToString();
        }

        private void rdLost_CheckedChanged(object sender, EventArgs e)
        {
            lbHeader.Text = "Replacement for Lost License";
            this.Text = lbHeader.Text;
            lbAppFees.Text = clsApplicationType.Find((clsApplication.enApplicationType)_GetApplicationTypeID())!.ApplicationFees.ToString();
        }
    }
}
