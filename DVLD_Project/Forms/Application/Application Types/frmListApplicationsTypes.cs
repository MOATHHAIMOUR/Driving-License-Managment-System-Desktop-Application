using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.ApplicationsForms
{
    public partial class frmListApplicationTypes : Form
    {
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {       
            FillGridWithApplicationTypes();
        }

        private void FillGridWithApplicationTypes()
        {
            gridApplications.DataSource = clsApplicationType.GetApplicationTypes();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frmEditApplicationType = new frmEditApplicationType((int)gridApplications.CurrentRow.Cells[0].Value);
            frmEditApplicationType.ShowDialog();
            FillGridWithApplicationTypes();
        }
    }
}
