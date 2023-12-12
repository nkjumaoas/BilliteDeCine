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
        public Receipt(string ticketNo, string movieTitle, string showdate, string quantity, string totalAmount)
        {
            InitializeComponent();

            // Set values in the constructor
            lblticketno.Text = ticketNo;
            lblmovietitle.Text = movieTitle;
            lblShowingDate.Text = showdate;
            lblQuantity.Text = quantity;
            lblTotalAmount.Text = totalAmount;

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
        

        private void Receipt_Load(object sender, EventArgs e)
        {
            
        }
    }
}