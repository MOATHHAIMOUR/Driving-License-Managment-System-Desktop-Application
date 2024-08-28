namespace DVLD_Project.Forms.License
{
    public partial class frmShowLicensesHistory : Form
    {
        public int PersonID = -1;

        public frmShowLicensesHistory(int PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }

        public frmShowLicensesHistory()
        {
            InitializeComponent();
        }



        private void ctrlPersonDetailsWithFilter1_OnPersonSelected(int obj)
        {
            PersonID = obj;

            if (obj != -1)
                ctrlDriverLicenses1.LoadInfoByPersonID(PersonID);
            else
                ctrlDriverLicenses1.Clear();
        }

        private void frmShowLicensesHistory_Load(object sender, EventArgs e)
        {
            if (PersonID != -1)
            {
                ctrlPersonDetailsWithFilter1.LoadPersonInfo(PersonID);
                ctrlPersonDetailsWithFilter1.FilterEnabeld = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
