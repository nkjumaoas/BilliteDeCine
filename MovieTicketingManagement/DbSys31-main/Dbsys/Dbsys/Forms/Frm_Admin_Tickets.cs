using Dbsys.AppData;
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
    public partial class Frm_Admin_Tickets : Form
    {
        public Frm_Admin_Tickets()
        {
            InitializeComponent();
        }

        

        private void Frm_Customer_Purchase_Load(object sender, EventArgs e)
        {
            cbUser.Text = UserLogged.GetInstance().UserAccount.userName; 
            try
            {
                using (var db = new DBSYSEntities())
                {
                    // Load data from the Movies table into the DataGridView
                    dgvTickets.DataSource = db.Ticket.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Load Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateSoldTicketSum();
        }
        private void UpdateSoldTicketSum()
        {
            try
            {
                using (var db = new DBSYSEntities())
                {
                    lblSoldTickets.Text = (db.Ticket.Sum(t => t.soldTickets) ?? 0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating soldTicket sum: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
