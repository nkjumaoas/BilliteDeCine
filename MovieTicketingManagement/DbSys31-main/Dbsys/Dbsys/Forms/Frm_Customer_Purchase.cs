using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            comboBox1.Text = UserLogged.GetInstance().UserAccount.userName;
            // Disable the Buy Ticket button initially
            btnBuyTicket.Enabled = false; 
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

            int selectedQuantity = Convert.ToInt32(nupQuantity.Value);

            // Check availability before adding the purchase to the list
            using (var db = new DBSYSEntities())
            {
                int movieNo = Convert.ToInt32(lblMovieNo.Text);
                var movie = db.Movies.SingleOrDefault(m => m.MovieNo == movieNo);

                if (movie == null || movie.Availability < selectedQuantity)
                {
                    MessageBox.Show($"Sorry, the selected quantity for {lblMovieTitle.Text} is not available. Available stock: {movie.Availability}.", "Save Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
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
            dgvPurchase.Rows.Add(rowData);

            // After adding data to the DataGridView, check if it has rows
            if (dgvPurchase.Rows.Count > 0)
            {
                btnBuyTicket.Enabled = true; // Enable the Buy Ticket button
            }
        }

        private void dgvPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPurchase.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
            {
                dgvPurchase.Rows.Remove(dgvPurchase.Rows[e.RowIndex]);
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

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            SalesMaster newSalesMaster = null;

            try
            {
                using (var db = new DBSYSEntities())
                {
                    // Create a new SalesMaster entry with the current date
                    newSalesMaster = new SalesMaster
                    {
                        // TicketNo will be auto-generated by the database
                        DateSale = DateTime.Now
                    };

                    // Add the new sales master to the DbSet
                    db.SalesMaster.Add(newSalesMaster);
                    db.SaveChanges();
                    hasChange = true;

                    // Iterate through the DataGridView rows and add SalesDetails
                    foreach (DataGridViewRow row in dgvPurchase.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            try
                            {
                                // Create SQL command to insert data into SalesDetails
                                string insertQuery = "INSERT INTO SalesDetails (Movie, Quantity, Price, TotalAmount, TicketNo) " +
                                                     "VALUES (@Movie, @Quantity, @Price, @TotalAmount, @TicketNo)";

                                // Create parameters for the SQL command
                                var parameters = new object[]
                                {
                            new SqlParameter("@Movie", Convert.ToInt32(row.Cells["MovieNo"].Value)),
                            new SqlParameter("@Quantity", Convert.ToInt32(row.Cells["Quantity"].Value)),
                            new SqlParameter("@Price", Convert.ToDecimal(row.Cells["Price"].Value)),
                            new SqlParameter("@TotalAmount", Convert.ToDecimal(row.Cells["TotalSales"].Value)),
                            new SqlParameter("@TicketNo", newSalesMaster.TicketNo)
                                };

                                // Execute SQL command
                                db.Database.ExecuteSqlCommand(insertQuery, parameters);
                                hasChange = true;

                                // Update the availability in the Movies table
                                int movieNo = Convert.ToInt32(row.Cells["MovieNo"].Value);
                                int purchasedQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                                var movieToUpdate = db.Movies.SingleOrDefault(m => m.MovieNo == movieNo);

                                if (movieToUpdate != null)
                                {
                                    // Subtract the purchased quantity from the current availability
                                    movieToUpdate.Availability -= purchasedQuantity;
                                }

                                // Save changes to the database
                                db.SaveChanges();
                                hasChange = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                    // Optionally, clear the rowDataList after successful insertion
                    rowDataList.Clear();

                    MessageBox.Show("Data has been inserted into SalesDetail table.", "Buy Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView with SalesDetails data
                    dgvPurchase.DataSource = db.SalesDetails.ToList();
                }
                if (newSalesMaster != null)
                {
                    Receipt r = new Receipt(newSalesMaster.TicketNo.ToString(),lblMovieTitle.Text,nupQuantity.Value.ToString(),lblTotalSales.Text);

                    r.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Frm_Customer_Dashboard c = new Frm_Customer_Dashboard();
            c.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
