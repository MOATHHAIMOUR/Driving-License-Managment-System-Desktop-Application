using DVLD_BusinessLayer;
using DVLD_Project.Forms.Application.Local_Driving_License;
using DVLD_Project.Forms.TestForms;
using System.Data;

namespace DVLD_Project.Forms.ApplicationsForms
{
    public partial class frmLocalDrivingLicensesManagment : Form
    {
        public frmLocalDrivingLicensesManagment()
        {
            InitializeComponent();
        }


        public string FilterBy { set; get; }

        public string FilterValue { set; get; }
        public DataView LocalDrivingLicensesDataView { set; get; }

        private void FillGridApplication()
        {
            LocalDrivingLicensesDataView = new DataView(clsLocalDrivingLicenseApplication.GetLocalDrivingLicense());

            dgvLocalDrivingLicenseApplications.DataSource = LocalDrivingLicensesDataView;
        }
        private void frmLocalDrivingLicensesManagment_Load(object sender, EventArgs e)
        {
            FillGridApplication();
            comboFilterBy.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;
            dgvLocalDrivingLicenseApplications.DataSource = LocalDrivingLicensesDataView;
            comboStatus.Visible = false;
        }

        private void comboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dgvLocalDrivingLicenseApplications.SelectedRows.Count == 0)
                FillGridApplication();

            FilterBy = comboFilterBy.SelectedItem!.ToString();
            if (FilterBy == "Status")
            {
                comboStatus.Visible = true;
                txtFilterValue.Visible = false;
            }
            else
            {
                comboStatus.Visible = false;
                txtFilterValue.Visible = true;
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.FilterBy == "ApplicationID" || this.FilterBy == "NationalNo")
            {
                if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                {
                    // Allow the character
                    e.Handled = false;
                }
                else
                {
                    // Reject the character
                    e.Handled = true;
                }
            }
        }

        private void FilterLogicForText()
        {
            if (string.IsNullOrEmpty(this.FilterValue))
            {
                FillGridApplication();
                return;
            }
            Type type = this.LocalDrivingLicensesDataView.Table!.Columns[this.FilterBy]!.DataType;

            switch (type)
            {
                case Type _ when type == typeof(string):
                    this.LocalDrivingLicensesDataView.RowFilter = $"{this.FilterBy} LIKE '%{this.FilterValue}%'";
                    break;
                case Type _ when type == typeof(int):
                    this.LocalDrivingLicensesDataView.RowFilter = $"{this.FilterBy} = {Convert.ToInt32(this.FilterValue)}";
                    break;
                case Type _ when type == typeof(byte):
                    this.LocalDrivingLicensesDataView.RowFilter = $"{this.FilterBy} = {Convert.ToByte(this.comboFilterBy.SelectedIndex + 1)}";
                    break;
                default:
                    throw new Exception("unknown Action Type");

            }
        }

        public void FilterLogicForStatus(string FilterValue)
        {
            switch (FilterValue)
            {
                case "New":
                    this.LocalDrivingLicensesDataView.RowFilter = $"ApplicationStatus = '{FilterValue}'";
                    break;
                case "Completed":
                    this.LocalDrivingLicensesDataView.RowFilter = $"ApplicationStatus = '{FilterValue}'";
                    break;
                case "Deleted":
                    this.LocalDrivingLicensesDataView.RowFilter = $"ApplicationStatus = '{FilterValue}' ";
                    break;
                default:
                    throw new Exception("unknown Action Type");

            }
        }
        private void FilterLogic()
        {
            if (txtFilterValue.Visible)
            {
                FilterLogicForText();
            }
            else
            {
                FilterLogicForStatus(comboStatus.SelectedItem!.ToString()!);
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterValue = txtFilterValue.Text;
            FilterLogic();
        }

        private void btnAddLocalLicenseApplication_MouseClick(object sender, MouseEventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frmNewLocalDrivingApplication = new frmAddUpdateLocalDrivingLicesnseApplication(-1);
            frmNewLocalDrivingApplication.ShowDialog();
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLogic();
        }





        private void VisionTest(object sender, EventArgs e)
        {

            FillGridApplication();
        }

        private void sechudelWrittenTest_Click(object sender, EventArgs e)
        {

            FillGridApplication();
        }


        private void sechudelStreetTest_Click(object sender, EventArgs e)
        {

            FillGridApplication();
        }

        private void contexLocalApplication_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string ApplicationStatus = (string)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value;

            int NumberOfpassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;


            ToolStripMenuItem TestsTypesParentItem = (ToolStripMenuItem)contexLocalApplication.Items["menuSechudelTestTool"]!;

            ToolStripMenuItem IsuueMenuItem = (ToolStripMenuItem)contexLocalApplication.Items["issueDrivingLicenseFirstTimeToolStripMenuItem"]!;

            if (ApplicationStatus == "Completed")
            {
                IsuueMenuItem.Enabled = false;
                TestsTypesParentItem.Enabled = false;

            }
            else if (ApplicationStatus == "Canceled")
            {
                IsuueMenuItem.Enabled = false;
                TestsTypesParentItem.DropDownItems[0].Enabled = false;
                TestsTypesParentItem.DropDownItems[1].Enabled = false;
                TestsTypesParentItem.DropDownItems[2].Enabled = false;
            }
            else
            {
                IsuueMenuItem.Enabled = false;
                if (NumberOfpassedTests == 0)
                {
                    TestsTypesParentItem.DropDownItems[1].Enabled = false;
                    TestsTypesParentItem.DropDownItems[2].Enabled = false;
                }
                else if (NumberOfpassedTests == 1)
                {
                    TestsTypesParentItem.DropDownItems[0].Enabled = false;
                    TestsTypesParentItem.DropDownItems[2].Enabled = false;
                }
                else if (NumberOfpassedTests == 2)
                {
                    TestsTypesParentItem.DropDownItems[0].Enabled = false;
                    TestsTypesParentItem.DropDownItems[1].Enabled = false;
                }
                else
                {
                    IsuueMenuItem.Enabled = true;
                    TestsTypesParentItem.DropDownItems[0].Enabled = false;
                    TestsTypesParentItem.DropDownItems[1].Enabled = false;
                    TestsTypesParentItem.DropDownItems[2].Enabled = false;
                }
            }
        }

        private void contexLocalApplication_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            ToolStripMenuItem parentItem = (ToolStripMenuItem)contexLocalApplication.Items["menuSechudelTestTool"]!;

            parentItem.DropDownItems[0].Enabled = true;
            parentItem.DropDownItems[1].Enabled = true;
            parentItem.DropDownItems[2].Enabled = true;
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FillGridApplication();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showApplicationDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            frmAddUpdateLocalDrivingLicesnseApplication frm =
                         new frmAddUpdateLocalDrivingLicesnseApplication(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;



        }
    }
}
