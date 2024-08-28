using DVLD_BusinessLayer;
using System.Data;

namespace DVLD_Project.Forms.License.International_License
{
    public partial class frmInternationalLicensesList : Form
    {


        private DataTable dtInternatiotanlLicenses; 
        public frmInternationalLicensesList()
        {
            InitializeComponent();
        }

        private void frmInternationalLicensesList_Load(object sender, EventArgs e)
        {
            dtInternatiotanlLicenses = clsInternationalLicense.GetInternationalLiceses();
            gridInternationalLicenses.DataSource = dtInternatiotanlLicenses; 
        }
    }
}
