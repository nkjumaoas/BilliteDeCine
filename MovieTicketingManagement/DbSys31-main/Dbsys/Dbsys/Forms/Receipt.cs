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
        //public Receipt(string ticketNo, string movieTitle, string showdate, string quantity, string totalAmount, Form Purchase)
        //{
        //    InitializeComponent();

        //    // Set values in the constructor
        //    lblticketno.Text = ticketNo;
        //    lblmovietitle.Text = movieTitle;
        //    lblShowingDate.Text = showdate;
        //    lblQuantity.Text = quantity;
        //    lblTotalAmount.Text = totalAmount;

        //    this.Purchase = Purchase;
        //    Purchase.Hide();


        //}
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
            SaveToTicketTable();

        }
        private void SaveToTicketTable()
        {
            try
            {
                // Convert necessary values to appropriate types
                int ticketNumber = Convert.ToInt32(lblticketno.Text);
                string movieTitle = lblmovietitle.Text;
                DateTime showingDate = Convert.ToDateTime(lblShowingDate.Text);
                int ticketQuantity = Convert.ToInt32(lblQuantity.Text);
                decimal ticketTotalAmount = Convert.ToDecimal(lblTotalAmount.Text);

                // Save to the database
                using (var db = new DBSYSEntities())
                {
                    var newTicket = new Ticket
                    {
                        newTicket.TicketNo = ticketNumber,
                        newTicket.MovieTitle = movieTitle,
                        newTicket.ShowingDate = showingDate,
                        newTicket.Quantity = ticketQuantity,
                        newTicket.TotalAmount = ticketTotalAmount
                    };

                    db.Ticket.Add(newTicket);
                    int result = db.SaveChanges();
                    Console.WriteLine("Number of changes saved: " + result);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error saving to Ticket table: " + ex.Message);
            }
        }



        private void Receipt_Load(object sender, EventArgs e)
        {
            
        }
    }
}