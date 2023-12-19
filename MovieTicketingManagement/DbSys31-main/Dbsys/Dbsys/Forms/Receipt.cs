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
using System.Windows.Forms.VisualStyles;

namespace Dbsys.Forms
{
    
    public partial class Receipt : Form
    {
        private Form Purchase;
        public Receipt(Form Purchase)
        {
            InitializeComponent();
            this.Purchase = Purchase;
            Purchase.Hide();


        }

        public void setValues(string ticketNo, string movieTitle, string showdate, string quantity, string totalAmount)
        {
            // Display values on the form
            lblticketno.Text = ticketNo;
            lblmovietitle.Text = movieTitle;
            lblShowingDate.Text = showdate;
            lblQuantity.Text = quantity;
            lblTotalAmount.Text = totalAmount;

            // Save values to the database
            SaveToDatabase(ticketNo, quantity);

        }

        private void SaveToDatabase(string ticketNo, string quantity)
        {
            try
            {
                using (var db = new DBSYSEntities())
                {
                    // Convert the quantity string to an int
                    if (!int.TryParse(quantity, out int parsedQuantity))
                    {
                        MessageBox.Show("Invalid quantity format. Please enter a valid number.");
                        return;
                    }

                    // Execute raw SQL insert statement
                    string sql = $"INSERT INTO Ticket (ticketNo, soldTickets) VALUES ({int.Parse(ticketNo)}, {parsedQuantity})";
                    db.Database.ExecuteSqlCommand(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Receipt_Load(object sender, EventArgs e)
        {
            
        }
    }
}