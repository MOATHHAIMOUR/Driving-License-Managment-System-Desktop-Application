using CoreDVLD;
using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.TestForms.Controls
{
    public partial class frmTakeTest : Form
    {

        public int TestAppoinmnetID { set; get; }

        private clsTestType.enTestType TestType;
        public clsTest Test;
        public int TestID { set; get; }

        public frmTakeTest(int testAppoinmnetID, clsTestType.enTestType enTestType)
        {
            InitializeComponent();
            TestAppoinmnetID = testAppoinmnetID;
            TestType = enTestType;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.TestTypeID = TestType;
            ctrlScheduledTest1.LoadTestInfo(TestAppoinmnetID);

            TestID = ctrlScheduledTest1.TestID;
            if (TestID != -1)
            {
                Test = clsTest.Find(TestID)!;

                if (Test.TestResult)
                    rdPass.Checked = true;
                else
                    rdFail.Checked = true;
                txtNotes.Text = Test.Notes;

                lbEditMessage.Visible = true;
                rdPass.Enabled = false;
                rdFail.Enabled = false;
            }
            else
                Test = new clsTest();
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
               )return;
            

            Test.TestAppointmentID = TestAppoinmnetID;
            Test.TestResult = rdPass.Checked;
            Test.Notes = txtNotes.Text.Trim();
            Test.CreatedByUserID = clsUserSettings.CurrentUser.UserID;

            if (Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
