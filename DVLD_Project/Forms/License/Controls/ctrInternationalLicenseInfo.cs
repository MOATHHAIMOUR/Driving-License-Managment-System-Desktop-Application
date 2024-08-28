using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.License.Controls
{
    public partial class ctrInternationalLicenseInfo : UserControl
    {
        public clsInternationalLicense? InternationalLicense { set; get; }

        public static int LicenseID { set; get; }

        public static int DriverID { set; get; }

        public clsPerson Person { set; get; }
        public static int PerosnID { set; get; }

        public ctrInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void FrmInternationalLicenseInfo_OnOpendInternationalForm(int InternationalID)
        {
           /* InternationalLicense = clsInternationalLicense.GetInternationalLicenseByID(InternationalID);

            if (InternationalLicense == null)
            {
                MessageBox.Show("The License not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            DriverID = InternationalLicense.DriverID;

            clsApplication Application = clsApplication.FindBaseApplication(InternationalLicense.ApplicationID)!;

            Person = clsPerson.Find(Application.ApplicantPersonID)!;
           

   

            LicenseID = InternationalLicense.InternationalLicenseID;
            lbName.Text = Person.FirstName + " " + Person.LastName;
            lbInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            lbNO.Text = Person.NationalNo;
            lbGender.Text = Person.Gender ? "Male" : "Female";
            lbIssueDate.Text = InternationalLicense.IssueDate.ToString("d");
            lbIssueDate.Text = InternationalLicense.IssueDate.ToString("d");
            IsActive.Text = InternationalLicense.IsActive ? "YES" : "NO";
            lbDateOfBirth.Text = Person.DateOfBirth.ToString("d");
            lbEXPDate.Text = InternationalLicense.ExpirationDate.ToString("d");
            lbIsDetiaiend.Text = "NO";*/
        }
    
    }
}
