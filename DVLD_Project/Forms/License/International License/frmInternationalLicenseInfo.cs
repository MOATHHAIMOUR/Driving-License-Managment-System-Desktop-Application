using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Forms.License.InternationalLicense
{
    public partial class frmInternationalLicenseInfo : Form
    {
        public int InternationalLicenseId { set; get; }

        public delegate void onOpendInternationalForm(int InternationalID);

        public static event onOpendInternationalForm OnOpendInternationalForm;  
        public frmInternationalLicenseInfo(int InternationalLicenseId)
        {
            InitializeComponent();
            this.InternationalLicenseId = InternationalLicenseId;
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            OnOpendInternationalForm?.Invoke(InternationalLicenseId);
        }
    }
}
