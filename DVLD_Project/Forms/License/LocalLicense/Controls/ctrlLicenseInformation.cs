using DVLD_BusinessLayer;
using DVLD_Project.Properties;
namespace DVLD_Project.Forms.License.Controls
{
    public partial class ctrlLicenseInformation : UserControl
    {
        public ctrlLicenseInformation()
        {
            InitializeComponent();
        }

        private clsLicense? _License;
        private int _LicenseID {set;get;}

        public int LicenseID
        {
            set { _LicenseID = value; }
            get { return _LicenseID; }
        }


        public clsLicense LicenseInfo
        {
            get { return _License; }
        }

        public void LoadLicenseInfoData(int LicenseID)
        {
            _LicenseID = LicenseID;
            _License = clsLicense.Find(_LicenseID);
            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            lbLicenseID.Text = _License.LicenseID.ToString();
            lbIsActive.Text = _License.IsActive ? "Yes" : "No";
            lbIsDetiaiend.Text = _License.IsActive ? "Yes" : "No";
            lbClass.Text = _License.LicenseClassInfo.ClassName;
            lbName.Text = _License.DriverInfo.PersonInfo.FullName;
            lbNO.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lbGender.Text = _License.DriverInfo.PersonInfo.Gender? "Male" : "Female";
            lbDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();

            lbDriverID.Text = _License.DriverID.ToString();
            lbIssueDate.Text = _License.IssueDate.ToShortDateString();
            lbEXPDate.Text = _License.ExpirationDate.ToShortDateString();
            lbIssueReason.Text = _License.IssueReasonText;
            lbNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender)
                pictureBox1.Image = Resources.avatar;
            else
                pictureBox1.Image = Resources.female;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pictureBox1.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }
}
