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
    public partial class Frm_Admin_Sales : Form
    {
        public Frm_Admin_Sales()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_Customer_Dashboard cd = new Frm_Customer_Dashboard();
            cd.Show();
            this.Hide();
        }

        private void Frm_Customer_Purchase_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Frm_Admin_DashBoard a = new Frm_Admin_DashBoard();
            a.Show();
            this.Dispose();
        }
    }
}
