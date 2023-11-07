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

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Frm_Customer_Movie3 movie3 = new Frm_Customer_Movie3();
            movie3.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Frm_Customer_Movie4 movie4 = new Frm_Customer_Movie4();
            movie4.Show();
            this.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Frm_Customer_Movie5 movie5 = new Frm_Customer_Movie5();
            movie5.Show();
            this.Hide();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Frm_Customer_Movie6 movie6 = new Frm_Customer_Movie6();
            movie6.Show();
            this.Hide();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Frm_Customer_Movie7 movie7 = new Frm_Customer_Movie7();
            movie7.Show();
            this.Hide();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Frm_Customer_Movie8 movie8 = new Frm_Customer_Movie8();
            movie8.Show();
            this.Hide();
        }
    }
}
