namespace DVLD_Project.Forms.License
{
    public partial class frmLicenseDetails : Form
    {
        public int LicenseID { set; get; }
        public frmLicenseDetails(int licenseID)
        {
            InitializeComponent();
            LicenseID = licenseID;
        }

        private void frmLicenseDetails_Load(object sender, EventArgs e)
        {
            ctrlLicenseInformation1.LoadLicenseInfoData(LicenseID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
