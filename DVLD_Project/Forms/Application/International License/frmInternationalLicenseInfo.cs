using CoreDVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.License.InternationalLicense
{
    public partial class frmnternationalLicenseInfo : Form
    {

        private int _InternationalLicenseID = -1;
        private int _LicenseID =-1;
        public frmnternationalLicenseInfo(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }

        public frmnternationalLicenseInfo()
        {
            InitializeComponent();
        }



      

        private void btnIssueInternational_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            
           clsInternationalLicense InternationalLicense= new clsInternationalLicense();
            //those are the information for the base application, because it inhirts from application, they are part of the sub class.

            InternationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationType.Find(clsApplication.enApplicationType.NewInternationalLicense)!.ApplicationFees;
            InternationalLicense.CreatedByUserID = clsUserSettings.CurrentUser.UserID;
           
            InternationalLicense.DriverID= ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            InternationalLicense.IssueDate= DateTime.Now;
            InternationalLicense.ExpirationDate= DateTime.Now.AddYears(1);
           
            InternationalLicense.CreatedByUserID = clsUserSettings.CurrentUser.UserID;

            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lbAppID.Text = InternationalLicense.ApplicationID.ToString();
            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            lbInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString() , "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueInternational.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            linkShowLicenseInfo.Enabled = true;

        }

        private void linkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo InternationalLicenseInfo = new frmInternationalLicenseInfo(_InternationalLicenseID);
            InternationalLicenseInfo.ShowDialog();
        }

        private void linkShowLicenseGistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicensesHistory frmShowLicensesHistory = new frmShowLicensesHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frmShowLicensesHistory.ShowDialog();
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            if (_LicenseID == -1)
            {
                return; 
            }


            lbLocalLicenseID.Text = _LicenseID.ToString();
            clsApplicationType ApplicationType = clsApplicationType.Find(clsApplication.enApplicationType.NewInternationalLicense);
            lbFees.Text = ApplicationType.ApplicationFees.ToString();
            lbAppDate.Text = DateTime.Now.ToShortDateString();
            lbIssueDate.Text = DateTime.Now.ToShortDateString();
            lbExpDate.Text = DateTime.Now.AddYears(10).ToShortDateString();


            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassID != 3)
            {
                MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int DriverID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.DriverID;
            //cheek if Person is already have an international License

            int ActiveInternationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(DriverID); 
            if (ActiveInternationalLicenseID!=-1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternationalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                linkShowLicenseHistory.Enabled = true;
                btnIssueInternational.Enabled = false;
                return;

            }

            btnIssueInternational.Enabled = true;

        }
    }
}
