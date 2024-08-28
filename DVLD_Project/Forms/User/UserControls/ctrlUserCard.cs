using DVLD_BusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
namespace DVLD_Project.Forms.UsersForms
{
    public partial class ctrlUserCard : UserControl
    {
        
        public clsUser? User { set; get; }  
        
        private int _UserID { set; get; }

        public int UserID { get { return _UserID; } }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

     
        public void LoadUserInfo(int UserID)
        {
            User = clsUser.FindByUserID(UserID)!;

            if (User == null)
            {
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadData();
        }


        private void LoadData()
        {
            _UserID = User.UserID;
            lbUserID.Text = User.UserID.ToString();
            lbIsActive.Text = User.IsActive ? "Yes" : "No";
            lbUsername.Text = User.UserName;
            ctrlPersonDetail1.LoadPersonInfo(User.PersonID);
        }

    }
}
