using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.ApplicationsForms
{
    public partial class frmEditApplicationType : Form
    {

        public int ApplicaitonID { get; set; }

        public clsApplicationType? Applicaiton { set; get; }
       
        public frmEditApplicationType(int ApplicationID)
        {
            InitializeComponent();

            this.ApplicaitonID = ApplicationID;
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            this.Applicaiton = clsApplicationType.Find((clsApplication.enApplicationType)this.ApplicaitonID);

            if (Applicaiton == null)
            {
                MessageBox.Show("There was an Error please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFees.Text = Applicaiton.ApplicationFees.ToString();
            txtTitle.Text = Applicaiton.ApplicationTitle;
            lbID.Text = Applicaiton.ApplicationTypeID.ToString();
        }


        private void btnSaveApplicationType_Click(object sender, EventArgs e)
        {

            Applicaiton.ApplicationFees = Convert.ToDecimal(txtFees);
            Applicaiton.ApplicationTitle = txtTitle.Text;   
            if (Applicaiton.Save())
            {
                MessageBox.Show("Application is Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was an Error please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
