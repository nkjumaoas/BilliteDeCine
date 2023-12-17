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
    public partial class Frm_Staff_DashBoard : Form
    {
        public Frm_Staff_DashBoard()
        {
            InitializeComponent();
        }

        private void Frm_Teacher_DashBoard_Load(object sender, EventArgs e)
        {
            comboBox1.Text = UserLogged.GetInstance().UserAccount.userName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Switch Account")
            {

                Frm_Login c = new Frm_Login();
                c.Show();
                this.Hide();

            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Log Out")
            {
                this.Close();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Frm_Staff_UserEntry s = new Frm_Staff_UserEntry();
            s.Show();
            this.Hide();
        }

        private void btnAddMovies_Click(object sender, EventArgs e)
        {
            Frm_Staff_AddMovie s = new Frm_Staff_AddMovie();
            s.Show();
            this.Hide();
        }

        private void btnTotalSales_Click(object sender, EventArgs e)
        {
            Frm_Staff_Sales s = new Frm_Staff_Sales();
            s.Show();
            this.Hide();
        }
    }
}
