using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.License.Controls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        private int _LicenseID { set; get; }
        private bool _FilterEnabeld { set; get; }

        public bool FilterEnabled
        {

            set { _FilterEnabeld = value; gbFilter.Enabled = value; }
            get { return _FilterEnabeld; }
        }

        public int LicenseID
        {
            get { return ctrlLicenseInformation1.LicenseID; }
        }

        public clsLicense SelectedLicenseInfo
        {
            get { return ctrlLicenseInformation1.LicenseInfo; }

        }

        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtLicenseID.Text = LicenseID.ToString();
            ctrlLicenseInformation1.LoadLicenseInfoData(LicenseID);
            if (OnLicenseSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnLicenseSelected(_LicenseID);
        }

        private void btnOnSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (int.TryParse(txtLicenseID.Text, out int LicenseID))
            {
                _LicenseID =  LicenseID;
                LoadLicenseInfo(LicenseID);
            }
            else
            {
                MessageBox.Show("You should entrer a number only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOnSearchForLicense_Click(object sender, EventArgs e)
        {

        }
    }
}
