using DVLD_BusinessLayer;
using DVLD_Project.Forms.PepoleForms.Controls;
using System.ComponentModel;


namespace DVLD_Project.Forms.UsersForms
{
    public partial class frmAddUpdateUser : Form
    {

        public enum en_Mode { AddNew, Update }
        public en_Mode Mode;
        private int _UserID { set; get; }
        public clsUser? User { set; get; }


       
        public frmAddUpdateUser()
        {
            InitializeComponent();
            Mode = en_Mode.AddNew; 

        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            Mode = en_Mode.Update; 
            this._UserID = UserID;
        }


        private void _ResetDefulatValues()
        {
            if (Mode == en_Mode.AddNew)
            {
                lbHeader.Text = "Add New User";
                this.Text = "Add New User"; 
                this.User = new clsUser();
            }
            else
            {
                lbHeader.Text = "Update User";
                this.Text = "Update User";
            }
        }

        private void _LoadData()
        {
            User = clsUser.FindByUserID(_UserID);
            ctrlPersonDetailsWithFilter1.Enabled = false; 
            if (User == null)
            {
                MessageBox.Show("Cant find User please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtUsername.Text = User.UserName;
            txtPassword.Text = User.Password;
            txtConfirmPassword.Text = User.Password;
            chIsActive.Checked = User.IsActive;
            ctrlPersonDetailsWithFilter1.LoadPersonInfo(User.PersonID);
        }
        private void frmAddUpdateUserUser_Load(object sender, EventArgs e)
        {
            _ResetDefulatValues();
            if (Mode==en_Mode.Update)
                _LoadData(); 
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonDetailsWithFilter1.PersonID != -1)
            {
                if (clsUser.IsUserExistByPersonID(User.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    btnSaveUser.Enabled = true;
                    tbUser.Enabled = true;
                    tbUser.SelectedIndex++;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

      

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
                SetErorrMessage((TextBox)sender, e, "Username can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);

            if(clsUser.IsUserExistByUserName(txtUsername.Text))
                SetErorrMessage((TextBox)sender, e, "Username is already used by another user, please use another one");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
                SetErorrMessage((TextBox)sender, e, "Password can't be blank");
            else
                RemoveErorrMessage((TextBox)sender, e);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
                SetErorrMessage((TextBox)sender, e, "Confitme can't be blank");

            else if (txtPassword.Text != txtConfirmPassword.Text)
                SetErorrMessage((TextBox)sender, e, "Password and Confirme Password shoud be same");

            else
                RemoveErorrMessage((TextBox)sender, e);

        }

        private void SetErorrMessage(Control control, CancelEventArgs e, string message)
        {
            e.Cancel = true;
            epUser.SetError(control, message);
        }

        private void RemoveErorrMessage(Control control, CancelEventArgs e)
        {
            e.Cancel = false;
            epUser.SetError(control, "");
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            this.User!.PersonID = this.User.PersonInfo.PersonID;
            this.User.UserName = txtUsername.Text;
            this.User.Password = txtPassword.Text;
            this.User.IsActive = chIsActive.Checked;
            if (User!.Save())
            {
                MessageBox.Show("User Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbHeader.Text = "Edite User";
                lbPersonID.Text = this.User!.PersonID.ToString();
            }
            else
            {
                MessageBox.Show("There was an Erorr please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void tbUser_Selecting(object sender, TabControlCancelEventArgs e)
        {
            /*if (this.ctrlPersonDetailsWithFilter1.Person == null)
            {
                e.Cancel = true; // Prevents the tab from changing
            }*/
        }

       

       
    }
}
