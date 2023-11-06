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
    public partial class Frm_Customer_Dashboard : Form
    {
        public Frm_Customer_Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Frm_Customer_Movie1 movie1= new Frm_Customer_Movie1();
            movie1.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Frm_Customer_Movie2 movie2 = new Frm_Customer_Movie2();
            movie2.Show();
            this.Hide();
        }
    }
}
