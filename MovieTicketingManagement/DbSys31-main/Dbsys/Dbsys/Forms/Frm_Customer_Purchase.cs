using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class Frm_Customer_Purchase : Form
    {
        public bool hasChange = false;

        private static List<object[]> rowDataList = new List<object[]>();

        public Frm_Customer_Purchase()
        {
            InitializeComponent();
        }
        public void setValues(string movie,string title, string price)
        {
            lblMovieNo.Text = movie;
            lblMovieTitle.Text = title;
            lblPrice.Text = price;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*try
            {
                using (var db = new DBSYSEntities())
                {
                    var newUserInformation = new UserInformation
                    {
                        MovieNo = Convert.ToInt32(txtMovieNo.Text),
                        Description = txtDescription.Text,
                        CustomerName = txtCustomerName.Text,
                        ContactNo = txtContactNumber.Text,
                        EmailAddress = txtEmailAddress.Text,
                        Price = Convert.ToDecimal(txtPrice.Text),
                        Quantity = Convert.ToInt32(txtQuantity.Text),
                        TotalSales = Convert.ToInt64(txtTotalSales.Text)
                    };

                    // Add the new user information to the DbSet
                    db.UserInformation.Add(newUserInformation);

                    // Save changes to the database
                    db.SaveChanges();

                    // Refresh the DataGridView if needed
                    dgvUserInformation.DataSource = db.UserInformation.ToList();

                    hasChange = true;

                    MessageBox.Show("Data has been added...", "Save new purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            object[] rowData = new object[]
            {
                lblMovieNo.Text,
                lblMovieTitle.Text,
                lblPrice.Text,
                nupQuantity.Text,
                lblTotalSales.Text
            };

            // Add the row data to the list
            rowDataList.Add(rowData);

            // Add the row data to the DataGridView
            dgvUserInformation.Rows.Add(rowData);
        }

        private void dgvUserInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserInformation.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
            {
                dgvUserInformation.Rows.Remove(dgvUserInformation.Rows[e.RowIndex]);
                //getsum();
            }

        }

        private void nupQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(lblPrice.Text, out decimal price))
            {
                // Calculate the total sales based on the quantity selected in the NumericUpDown
                int quantity = (int)nupQuantity.Value;
                decimal totalSales = price * quantity;

                // Display the total sales in the lblTotalSales label
                lblTotalSales.Text = totalSales.ToString();
            }
    
        }
    }
}
