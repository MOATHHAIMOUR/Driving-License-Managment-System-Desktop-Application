using DVLD_BusinessLayer;
using System.Data;


namespace DVLD_Project.Forms.UsersForms
{
    public partial class frmUsersMangments : Form
    {
        public string FilterBy { set; get; }
        public string FilterValue { set; get; }

        public DataView Users { set; get; }

        public frmUsersMangments()
        {
            InitializeComponent();
        }

        private void frmUsersMangments_Load(object sender, EventArgs e)
        {
            comboIsActive.Visible = false;
            comboIsActive.SelectedIndex = 0;
            comboFilterBy.SelectedIndex = 0;
            txtFilterValue.Visible =  false; 
            Users = new DataView(clsUser.GetUsers());
            gridUsers.DataSource = Users;
        }


        private void btnAddUser_MouseClick(object sender, MouseEventArgs e)
        {
            frmAddUpdateUser frmSaveUser = new frmAddUpdateUser(-1);
            frmSaveUser.ShowDialog();
        }

        private void comboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.FilterBy = comboFilterBy.SelectedItem!.ToString()!;
            
            txtFilterValue.Visible = this.FilterBy != "None";

            if (this.FilterBy == "IsActive")
            {
                txtFilterValue.Visible = false;
                comboIsActive.Visible = true;
            }
            else
            {
                comboIsActive.Visible = false;
                txtFilterValue.Visible = true;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            this.FilterValue = txtFilterValue.Text;

            if (string.IsNullOrEmpty(FilterValue))
            {
                this.Users.RowFilter = string.Empty;
                gridUsers.DataSource = this.Users;
                return;
            }

            Type type = this.Users.Table!.Columns[this.FilterBy]!.DataType;

            switch (type)
            {
                case Type _ when type == typeof(string):
                    this.Users.RowFilter = $"{this.FilterBy} LIKE '%{this.FilterValue}%'";
                    break;
                case Type _ when type == typeof(int):
                    this.Users.RowFilter = $"{this.FilterBy} = {Convert.ToInt32(this.FilterValue)}";
                    break;
                default:
                    break;

            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.FilterBy == "PersonID" || this.FilterBy == "UserID")
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

        private void comboIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboIsActive.SelectedItem!.ToString())
            {
                case "All":
                    break;
                case "Yes":
                    this.Users.RowFilter = $"{this.FilterBy} = {true}";
                    break;
                case "No":
                    this.Users.RowFilter = $"{this.FilterBy} = {false}";
                    break;

            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserDetails = new frmUserInfo((int)gridUsers.CurrentRow.Cells[0].Value);
            frmUserDetails.ShowDialog();
        }

        private void addNewUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmSaveUser = new frmAddUpdateUser();
            frmSaveUser.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmSaveUser = new frmAddUpdateUser((int)gridUsers.CurrentRow.Cells[0].Value);
            frmSaveUser.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUserByUserID((int)gridUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User can't be deleted as there is data connected to him","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
