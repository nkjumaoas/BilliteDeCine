using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Frm_Admin_AddMovie a = new Frm_Admin_AddMovie();
            a.Show();
            this.Hide();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Frm_Admin_Availability c = new Frm_Admin_Availability();
            c.Show();   
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Admin_UserEntry a = new Frm_Admin_UserEntry();
            a.Show();
            this.Hide();
            
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUser.SelectedItem != null && cbUser.SelectedItem.ToString() == "Switch Account")
            {

                Frm_Login c = new Frm_Login();
                c.Show();
                this.Hide();

            }
            else if (cbUser.SelectedItem != null && cbUser.SelectedItem.ToString() == "Log Out")
            {
                this.Close();
            }
        }

        private void Frm_Admin_DashBoard_Load(object sender, EventArgs e)
        {
            
            cbUser.Text = UserLogged.GetInstance().UserAccount.userName;
            
        }
    }
}
