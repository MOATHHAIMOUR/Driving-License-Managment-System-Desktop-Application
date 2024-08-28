using DVLD_BusinessLayer;
using DVLD_Project.Forms.PepoleForms;
using DVLD_Project.Forms.PepoleForms.Controls;
using System.Data;

namespace DVLD_Project.Forms.Drivers
{
    public partial class frmListDrivers : Form
    {


        private DataTable dtDrivers { set; get; }

        public frmListDrivers()
        {
            InitializeComponent();
        }


        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            dtDrivers = clsDriver.GetAllDrivers(); ;

            gridDrivers.DataSource = dtDrivers;

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (comboFilterBy.SelectedItem)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                dtDrivers.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "FullName" || FilterColumn == "NationalNo")
                //in this case we deal with numbers not string.
                dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            else
                dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());


        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)gridDrivers.CurrentRow.Cells[1].Value;
            frmPersonDetails ctrlPersonCard = new frmPersonDetails(PersonID);   
            ctrlPersonCard.ShowDialog();  
        }
    }
}
