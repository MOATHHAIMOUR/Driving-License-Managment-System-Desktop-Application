using DVLD.Forms.PepoleForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnPeopleMangment_MouseClick(object sender, MouseEventArgs e)
        {
            frmPeopleMangment frmPeopleMangment = new frmPeopleMangment();
            frmPeopleMangment.ShowDialog();
        }
    }
}
