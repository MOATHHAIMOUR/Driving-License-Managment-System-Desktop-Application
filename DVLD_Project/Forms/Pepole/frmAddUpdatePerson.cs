using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using System.ComponentModel;
using System.Text.RegularExpressions;


namespace DVLD_Project.Forms.PepoleForms
{
    public partial class frmAddUpdatePerson : Form
    {
        public string PersonsImagesFolderPath = "C:\\Users\\moath\\Desktop\\new-Programes C#\\DVLD\\DVLD_Project\\personsImages\\";


        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;



        public enum enMode { AddNew, Update }

        public enMode en_Mode; 


        public enum enGender { Male, Female }

        public enGender en_Gender; 



        public clsPerson? Person { set; get; }

        public string selectedImagePath { set; get; }


        public int PersonID { set; get; }


        public frmAddUpdatePerson()
        {
            InitializeComponent();
            en_Mode = enMode.AddNew;
        }


        public frmAddUpdatePerson(int personID)
        {
            InitializeComponent();
            en_Mode = enMode.Update;
            PersonID = personID;
        }


        static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Define the regex pattern for a valid US phone number
            string pattern = @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber, pattern);
        }


        private void _ResetdefualtValues()
        {
            LoadCountries();
            if (en_Mode == enMode.AddNew)
            {
                lbHeader.Text = "Add New Person";
                this.Person = new clsPerson();
            }
            else
            {
                lbHeader.Text = "Update Person";
            }

            linkRemove.Visible = !string.IsNullOrEmpty(this.selectedImagePath);
            dtBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtBirth.MinDate = DateTime.Now.AddYears(-100);
            comboCountry.SelectedIndex = comboCountry.FindString("Jordan");
            
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNO.Text = "";
            picPerson.BackgroundImage = Resources.avatar;
            rdMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        public void LoadCountries()
        {
            comboCountry.DataSource = clsCountry.GetAllCountries();
            comboCountry.DisplayMember = "CountryName";
            comboCountry.ValueMember = "CountryID";

        }
        
        
        private void _LoadData()
        {
            this.Person = clsPerson.Find(this.PersonID);
           
            if (this.Person == null)
            {
                MessageBox.Show($"No Person ID With ID = ${PersonID}","Person not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close(); 
                return;
            }

            lbID.Text = this.Person.PersonID.ToString();
            txtAddress.Text = this.Person.Address;
            txtEmail.Text = this.Person.Email;
            txtFirstName.Text = this.Person.FirstName;
            txtLastName.Text = this.Person.LastName;
            txtNO.Text = this.Person.NationalNo;
            txtPhone.Text = this.Person.Phone;
            dtBirth.Value = this.Person.DateOfBirth;
            comboCountry.SelectedValue = this.Person.NationalityCountryID;

            if (!string.IsNullOrEmpty(this.Person.ImagePath))
                picPerson.BackgroundImage = Image.FromFile(Path.Combine(PersonsImagesFolderPath, this.Person.ImagePath));
            else
                picPerson.BackgroundImage = rdMale.Checked ? Resources.avatar : Resources.female;
        }
        
        private void frmSavePerson_Load(object sender, EventArgs e)
        {

            _ResetdefualtValues();

            if (en_Mode == enMode.Update)
                _LoadData(); 
        }




        private void btnSavePerson_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            this.Person.NationalNo = txtNO.Text;
            this.Person.FirstName = txtFirstName.Text;
            this.Person.SecondName = txtSecondName.Text;
            this.Person.ThirdName = txtThirdName.Text;
            this.Person.LastName = txtLastName.Text;
            this.Person.Address = txtAddress.Text;
            this.Person.DateOfBirth = dtBirth.Value;
            this.Person.Email = txtEmail.Text;
            this.Person.Phone = txtPhone.Text;
            this.Person.NationalityCountryID = (int)comboCountry.SelectedValue!;
            //true-> Male , False->Female
            this.Person.Gender = rdMale.Checked;

            SaveImageHandler();

            if (Person.Save())
            {
                lbHeader.Text = "Update Person";
                lbID.Text = this.Person.PersonID.ToString();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveImageHandler()
        {
            //save image steps

            //delete the image from PersonsImageFolder if there is

            bool isSameImage = this.Person.ImagePath ==  Path.GetFileName(this.selectedImagePath);

            if (!string.IsNullOrEmpty(this.Person.ImagePath) && !isSameImage)
                File.Delete(Path.Combine(this.PersonsImagesFolderPath, this.Person.ImagePath));


            //insert Image PersonsImageFolder logic 
            if (string.IsNullOrEmpty(this.selectedImagePath))
            {
                this.Person.ImagePath = "";
            }
            else
            {
                if (!isSameImage)
                {
                    string guidPath = GenrateCustomLocalImagePath();
                    if (SaveImageToPersonsImagesFolder(selectedImagePath, guidPath))
                    {
                        this.Person.ImagePath = Path.GetFileName(guidPath);
                    }
                }
            }
        }

        private string GenrateCustomLocalImagePath()
        {
            // Generate a new GUID
            string guid = Guid.NewGuid().ToString();

            // Get the file extension from the selected image path
            string extension = Path.GetExtension(selectedImagePath);

            // Combine the GUID with the extension to create the new file name
            string newFileName = $"{guid}{extension}";

            // Combine the folder path with the new file name to get the full path
            string imagePath = Path.Combine(PersonsImagesFolderPath, newFileName);

            return imagePath;
        }

        private bool SaveImageToPersonsImagesFolder(string SelectedImagePath, string SavedImagePath)
        {
            bool isSaved = false;
            try
            {
                // Copy the image to the specified destination path
                File.Copy(SelectedImagePath, SavedImagePath, true);

                using (Image backgroundImage = Image.FromFile(SavedImagePath))
                {
                    picPerson.BackgroundImage = new Bitmap(backgroundImage);
                }

                this.Person!.ImagePath = Path.GetFileName(SavedImagePath);
                this.selectedImagePath = SavedImagePath;

                isSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while copying the image: " + ex.Message);
            }

            return isSaved;
        }

        private void linkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    selectedImagePath = filePath;
                    linkImage.Text = "Edit Image";
                    linkRemove.Visible = true;
                    // Load the image into the PictureBox
                    picPerson.BackgroundImage = System.Drawing.Image.FromFile(filePath);
                }
            }
        }

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Dispose of the current background image if any
            if (picPerson.BackgroundImage != null)
            {
                picPerson.BackgroundImage.Dispose();
                picPerson.BackgroundImage = null;
            }
            this.selectedImagePath = "";
            linkRemove.Visible = false;
            linkImage.Text = "setImage";

            picPerson.BackgroundImage = rdMale.Checked ? Resources.avatar : Resources.female;


        }

        private void rdGender_MouseClick(object sender, MouseEventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "Male":
                    picPerson.BackgroundImage = Resources.avatar;
                    break;
                case "Female":
                    picPerson.BackgroundImage = Resources.female;
                    break;
            }

        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }


        private void SetErorrMessage(Control control, CancelEventArgs e, string message)
        {
            e.Cancel = true;
            epPerson.SetError(control, message);
        }

        private void RemoveErorrMessage(Control control, CancelEventArgs e)
        {
            e.Cancel = false;
            epPerson.SetError(control, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                RemoveErorrMessage((TextBox)sender, e);
                return;
            }

            if (IsValidEmail(txtEmail.Text))
            {
                RemoveErorrMessage((TextBox)sender, e);
            }
            else
            {
                SetErorrMessage((TextBox)sender, e, "You Should enter a valid Email");
            }

        }

        private void txtNO_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson.IsPersonExistByNO(txtNO.Text))
            {
                SetErorrMessage((TextBox)sender, e, "NO Number is used by another person");
            }
            else
            {
                RemoveErorrMessage((TextBox)sender, e);
            }
        }



        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
                SetErorrMessage((TextBox)sender, e, "FirstName can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecondName.Text))
                SetErorrMessage((TextBox)sender, e, "SecondName can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }



        private void txtThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThirdName.Text))
                SetErorrMessage((TextBox)sender, e, "ThirdName can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
                SetErorrMessage((TextBox)sender, e, "LastName can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                SetErorrMessage((TextBox)sender, e, "phone number can't be blanl");
                return;
            }

            if (IsValidPhoneNumber(txtPhone.Text))
            {
                RemoveErorrMessage((TextBox)sender, e);
            }
            else
            {
                SetErorrMessage((TextBox)sender, e, "You should enter a valid Phone number");
            }
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
