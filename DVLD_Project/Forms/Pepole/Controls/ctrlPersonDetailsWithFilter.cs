using DVLD_BusinessLayer;

namespace DVLD_Project.Forms.PepoleForms.Controls
{
    public partial class ctrlPersonDetailsWithFilter : UserControl
    {
        //define a custom event handler with delgate with prameters
        public event Action<int> OnPersonSelected;
        //create a protected method to raise the event
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
                handler(PersonID);
        }

        protected bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
            }
            get { return _ShowAddPerson; }
        }

        protected bool _FilterEnabeld = true;

        public bool FilterEnabeld
        {
            set
            {
                _FilterEnabeld = value;
                gbFilter.Enabled = value;
            }
            get { return _FilterEnabeld; }
        }

        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }


        public ctrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }


        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));

                    break;

                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabeld)
                // Raise the event with a parameter
                OnPersonSelected(ctrlPersonCard1.PersonID);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmSavePerson = new frmAddUpdatePerson(-1);
            frmSavePerson.DataBack += FrmSavePerson_DataBack;
            frmSavePerson.ShowDialog();
        }

        private void FrmSavePerson_DataBack(object sender, int PersonID)
        {
            // Handle the data received
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        private void ctrlPersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus(); 
        }
    }
}
