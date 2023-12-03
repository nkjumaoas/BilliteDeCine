﻿using System;
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
            Frm_Admin_AddMovie a = new Frm_Admin_AddMovie();
            a.Show();
            this.Hide();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Frm_Customer_Dashboard c = new Frm_Customer_Dashboard();
            c.Show();   
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_UserAccount a = new Frm_UserAccount();
            a.Show();
            this.Hide();
        }
    }
}
