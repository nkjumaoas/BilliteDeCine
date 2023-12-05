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
        public Receipt(string ticketNo, string movieTitle, string quantity, string totalAmount)
        {
            InitializeComponent();

            // Set values in the constructor
            lblticketno.Text = ticketNo;
            lblmovietitle.Text = movieTitle;
            lblquan.Text = quantity;
            lbltamount.Text = totalAmount;
            lblQuantity.Text = quantity;
            lblTotalAmount.Text = totalAmount;

            // Subscribe to the Paint event
            panel1.Paint += panel1_Paint;

            // Handle the Load event to ensure labels are populated before rotating
            this.Load += Receipt_Load;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            RotateLabelVertical(e.Graphics, lblticketno, new Point(10, 10));
            RotateLabelVertical(e.Graphics, lblmovietitle, new Point(10, 80));
            RotateLabelVertical(e.Graphics, lblshowdate, new Point(10, 150));
            RotateLabelVertical(e.Graphics, lblquan, new Point(10, 220));
            RotateLabelVertical(e.Graphics, lbltamount, new Point(10, 290));
        }

        private void RotateLabelVertical(Graphics g, Label label, Point position)
        {
            using (StringFormat stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                g.TranslateTransform(position.X, position.Y);
                g.RotateTransform(-90);

                // Draw text at the center
                RectangleF rect = new RectangleF(0, 0, label.Height, label.Width);
                g.DrawString(label.Text, label.Font, Brushes.Black, rect, stringFormat);

                g.ResetTransform();
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // Call the panel1_Paint event to ensure labels are rotated after Load
            panel1.Invalidate();
        }
    }
}