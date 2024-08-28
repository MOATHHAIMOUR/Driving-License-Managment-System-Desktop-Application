using DVLD_BusinessLayer;
using DVLD_Project.Properties;


namespace DVLD_Project.Forms.PepoleForms.Controls
{
    public partial class ctrlPersonCard : UserControl
    {

        public string PersonsImagesFolderPath = "C:\\Users\\moath\\Desktop\\new-Programes C#\\DVLD\\DVLD_Project\\personsImages\\";

        private clsPerson _Person;

        private int _PersonID = -1;

        // Exposed Properties
        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent(); 
        }
       
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lbPersonID.Text = "[????]";
            lbNO.Text = "[????]";
            picPerson.Image = Resources.avatar;
            lbGender.Text = "[????]";
            lbEmail.Text = "[????]";
            lbPhone.Text = "[????]";
            lbDataOfBirth.Text = "[????]";
            lbCountry.Text = "[????]";
            lbAddrress.Text = "[????]";

        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            
            if (SelectedPersonInfo == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
   
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        } 
        
        private void _FillPersonInfo()
        {
            lbPersonID.Text = this.SelectedPersonInfo!.PersonID.ToString();
            lbName.Text = string.Join(' ', [this.SelectedPersonInfo.FirstName, this.SelectedPersonInfo.SecondName, this.SelectedPersonInfo.ThirdName, this.SelectedPersonInfo.LastName]);
            lbAddrress.Text = this.SelectedPersonInfo.Address;
            lbCountry.Text = clsCountry.Find(SelectedPersonInfo.NationalityCountryID).CountryName;
            lbPhone.Text = this.SelectedPersonInfo.Phone;
            lbEmail.Text = this.SelectedPersonInfo.Email;
            lbGender.Text = this.SelectedPersonInfo.Gender ? "Male" : "Female";
            lbNO.Text = this.SelectedPersonInfo.NationalNo;
            lbDataOfBirth.Text = this.SelectedPersonInfo.DateOfBirth.ToString();
           
            if (!string.IsNullOrEmpty(this.SelectedPersonInfo.ImagePath))
                picPerson.BackgroundImage = Image.FromFile(Path.Combine(PersonsImagesFolderPath, this.SelectedPersonInfo.ImagePath));
            else
                picPerson.BackgroundImage = this.SelectedPersonInfo.Gender ? Resources.avatar : Resources.avatar;
        }
       
        private void linkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson SavePersonForm = new frmAddUpdatePerson(this.SelectedPersonInfo!.PersonID);
            SavePersonForm.ShowDialog();
            LoadPersonInfo(this.SelectedPersonInfo!.PersonID);
        }

        private void ctrlPersonDetail_Load(object sender, EventArgs e)
        {
        }

    }
}
