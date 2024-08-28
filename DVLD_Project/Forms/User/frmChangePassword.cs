using DVLD_BusinessLayer;
using System.ComponentModel;


namespace DVLD_Project.Forms.UsersForms
{
    public partial class frmChangePassword : Form
    {

        public int UserID { get; set; }
        private clsUser? _User; 
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                SetErorrMessage((TextBox)sender, e, "Current Password can't be blank ");
            }
            else if (txtCurrentPassword.Text != ctrlUserCard1.User.Password)
            {
                SetErorrMessage((TextBox)sender, e, "Incorrect Password");
            }
            else
            {
                RemoveErorrMessage((TextBox)sender, e);
            }
        }

        private void SetErorrMessage(Control control, CancelEventArgs e, string message)
        {
            e.Cancel = true;
            ebChangePassword.SetError(control, message);
        }

        private void RemoveErorrMessage(Control control, CancelEventArgs e)
        {
            e.Cancel = false;
            ebChangePassword.SetError(control, "");
        }

        private void btnSaveChangePassword_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtNewPassword.Text;

            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefualtValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            _User = clsUser.FindByUserID(UserID);

            if (_User == null)
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Could not Find User with id = " + UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }
            ctrlUserCard1.LoadUserInfo(UserID);
        }
    }
}
