using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.TestForms
{
    public partial class frmUpdateTestTypes : Form
    {
        public clsTestType? TestType { set; get; }

        public clsTestType.enTestType TestTypeID { set; get; }

        public frmUpdateTestTypes(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();
            this.TestTypeID = TestTypeID;
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            this.TestType = clsTestType.Find(TestTypeID);

            if (this.TestType == null)
            {
                MessageBox.Show("There was an Error please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbID.Text = this.TestType.ID.ToString();
            txtTitle.Text = this.TestType.Title;
            txtDescription.Text = this.TestType.Description;
            txtFees.Text = this.TestType.Fees.ToString();
        }

        private void btnTestTypeSave_Click(object sender, EventArgs e)
        {
            TestType.Title = txtTitle.Text; 
            TestType.Description = txtDescription.Text;
            TestType.Fees = Convert.ToDecimal(txtFees.Text);

            if (TestType!.Save())
            {
                MessageBox.Show("Test Type is saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("There was an Error please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
