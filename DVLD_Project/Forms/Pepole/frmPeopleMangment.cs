using DVLD_BusinessLayer;
using DVLD_Project.Forms.PepoleForms;
using System.Data;

namespace DVLD.Forms.PepoleForms
{
    public partial class frmPeopleMangment : Form
    {

        public string FilterBy { set; get; }

        public DataTable PeopelData { set; get; }

        public string FilterValue { set; get; }

        public frmPeopleMangment()
        {
            InitializeComponent();
        }


        private void PeopleMangment_Load(object sender, EventArgs e)
        {
            this.PeopelData = clsPerson.GetAllPeople();
            gridPeople.DataSource = this.PeopelData;
            comboBox1.SelectedIndex = 0;

            if (PeopelData.Rows.Count > 0)
            {

                gridPeople.Columns[0].HeaderText = "Person ID";
                gridPeople.Columns[0].Width = 110;

                gridPeople.Columns[1].HeaderText = "National No.";
                gridPeople.Columns[1].Width = 120;


                gridPeople.Columns[2].HeaderText = "First Name";
                gridPeople.Columns[2].Width = 120;

                gridPeople.Columns[3].HeaderText = "Second Name";
                gridPeople.Columns[3].Width = 140;


                gridPeople.Columns[4].HeaderText = "Third Name";
                gridPeople.Columns[4].Width = 120;

                gridPeople.Columns[5].HeaderText = "Last Name";
                gridPeople.Columns[5].Width = 120;

                gridPeople.Columns[6].HeaderText = "Gendor";
                gridPeople.Columns[6].Width = 120;

                gridPeople.Columns[7].HeaderText = "Date Of Birth";
                gridPeople.Columns[7].Width = 140;

                gridPeople.Columns[8].HeaderText = "Nationality";
                gridPeople.Columns[8].Width = 120;


                gridPeople.Columns[9].HeaderText = "Phone";
                gridPeople.Columns[9].Width = 120;


                gridPeople.Columns[10].HeaderText = "Email";
                gridPeople.Columns[10].Width = 170;
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddNewPerson = new frmAddUpdatePerson();
            frmAddNewPerson.ShowDialog();
            this.gridPeople.DataSource = new DataView(clsPerson.GetAllPeople());

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FilterBy = (string)comboBox1.SelectedItem!;

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            this.FilterValue = txtFilterValue.Text;

            if (string.IsNullOrEmpty(FilterValue))
            {
                this.PeopelData.DefaultView.RowFilter = string.Empty;
                gridPeople.DataSource = this.PeopelData;
                return;
            }

            Type type = this.PeopelData!.Columns[this.FilterBy]!.DataType;

            switch (type)
            {
                case Type _ when type == typeof(string):
                    this.PeopelData.DefaultView.RowFilter = $"{this.FilterBy} LIKE '%{this.FilterValue}%'";
                    break;
                case Type _ when type == typeof(int):
                    this.PeopelData.DefaultView.RowFilter = $"{this.FilterBy} = {Convert.ToInt32(this.FilterValue)}";
                    break;
                default:
                    break;

            }

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.FilterBy == "PersonID")
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

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddNewPerson = new frmAddUpdatePerson();
            frmAddNewPerson.ShowDialog();
            this.gridPeople.DataSource = new DataView(clsPerson.GetAllPeople());
        }

        private void showDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frmPersonDetails = new frmPersonDetails((int)gridPeople.CurrentRow.Cells[0].Value);
            frmPersonDetails.ShowDialog();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddNewPerson = new frmAddUpdatePerson((int)gridPeople.CurrentRow.Cells[0].Value);
            frmAddNewPerson.ShowDialog();
            this.gridPeople.DataSource = new DataView(clsPerson.GetAllPeople());

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + gridPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.DeletePerson((int)gridPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gridPeople.DataSource = new DataView(clsPerson.GetAllPeople());
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAddPerson_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
