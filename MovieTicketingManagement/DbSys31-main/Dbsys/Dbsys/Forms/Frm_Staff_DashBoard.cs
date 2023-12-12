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
    }
}
