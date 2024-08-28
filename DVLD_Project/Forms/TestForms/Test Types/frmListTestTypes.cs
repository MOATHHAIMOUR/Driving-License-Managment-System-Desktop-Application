using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.TestForms
{
    public partial class frmListTestTypes : Form
    {
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            gridTestsTypes.DataSource = clsTestType.GetTeatsTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestTypes frmUpdateTestTypes = new frmUpdateTestTypes((clsTestType.enTestType)gridTestsTypes.CurrentRow.Cells[0].Value);
            frmUpdateTestTypes.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close( );
        }
    }
}
