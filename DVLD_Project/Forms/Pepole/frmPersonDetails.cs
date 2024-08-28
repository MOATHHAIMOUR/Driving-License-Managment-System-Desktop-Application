namespace DVLD_Project.Forms.PepoleForms
{
    public partial class frmPersonDetails : Form
    {

        public frmPersonDetails(int PersonId)
        {
            InitializeComponent();
            ctrlPersonDetail1.LoadPersonInfo(PersonId);
        }

        public frmPersonDetails(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonDetail1.LoadPersonInfo(NationalNo);
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
