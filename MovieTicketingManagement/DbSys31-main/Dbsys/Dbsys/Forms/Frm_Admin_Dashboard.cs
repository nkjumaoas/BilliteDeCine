using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class Frm_Admin_DashBoard : Form
    {
        public Frm_Admin_DashBoard()
        {
            InitializeComponent();
        }

        private void btnTotalSales_Click(object sender, EventArgs e)
        {
            Frm_Admin_Sales s = new Frm_Admin_Sales();
            s.Show();
            this.Hide();
        }

        private void btnAvailableMovie_Click(object sender, EventArgs e)
        {
            Frm_Admin_AvailableMovie a = new Frm_Admin_AvailableMovie();
            a.Show();
            this.Hide();
        }
    }
}
