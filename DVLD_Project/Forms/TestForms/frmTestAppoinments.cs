using DVLD_BusinessLayer;
using DVLD_Project.Properties;


namespace DVLD_Project.Forms.TestForms
{
    public partial class frmTestAppoinments : Form
    {
        private int _LocalDrivingApplicationID { set; get; }
        private clsTestType.enTestType _TestType { set; get; }

        public frmTestAppoinments(int LocalDrivingApplicationID, clsTestType.enTestType TestType)
        {
            InitializeComponent();
            _TestType = TestType;
            LocalDrivingApplicationID = _LocalDrivingApplicationID;
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {

                case clsTestType.enTestType.VisionTest:
                    {
                        lbHeader.Text = "Vision Test Appointments";
                        this.Text = lbHeader.Text;
                        pictureImage.Image = Resources.eye_scan;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        lbHeader.Text = "Written Test Appointments";
                        this.Text = lbHeader.Text;
                        pictureImage.Image = Resources.testing;
                        break;
                    }
                case clsTestType.enTestType.StreetTest:
                    {
                        lbHeader.Text = "Street Test Appointments";
                        this.Text = lbHeader.Text;
                        pictureImage.Image = Resources.street;
                        break;
                    }
            }
        }



        private void frmTestAppoinments_Load(object sender, EventArgs e)
        {
            gridTests.DataSource = clsTestAppointment.GetTestAppoinments(_LocalDrivingApplicationID, _TestType);

            ctrlApplicationInfo1.LoadLocalDrivingApplicationInfo(_LocalDrivingApplicationID);
            _LoadTestTypeImageAndTitle();
        }

        private void btnAddTestAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.IsApplicantPassTest(_LocalDrivingApplicationID, _TestType))
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalDrivingApplicationID, _TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            frmScheduleTest frmScheduleTest = new frmScheduleTest(_LocalDrivingApplicationID, _TestType);
            frmScheduleTest.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)gridTests.CurrentRow.Cells[0].Value;

            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingApplicationID, _TestType, TestAppointmentID);

            frm.ShowDialog();
        }
    }
}
