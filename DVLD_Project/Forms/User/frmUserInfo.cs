namespace DVLD_Project.Forms.UsersForms
{
    public partial class frmUserInfo : Form
    {

        private int _UserID { set; get; } 
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID); 
        }
    }
}
