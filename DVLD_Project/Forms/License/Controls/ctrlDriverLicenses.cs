using DVLD_BusinessLayer;
using System.Data;

namespace DVLD_Project.Forms.License.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private clsDriver? _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }


        private void _LoadLocalLicenseInfo()
        {

        }

        private void _LoadInternationalLicenseInfo()
        {

        }

        public void Clear()
        {
            gridInternationalLicenses.DataSource = null;
            gridLocalLicenses.DataSource = null;
        }


        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = clsDriver.FindDriverByPersonID(PersonID);

            
            if (_Driver == null)
            {
                MessageBox.Show($"There is no Driver with PersonID {PersonID} in systme", "Driver Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverID = _Driver.DriverID;
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }

    }
}

