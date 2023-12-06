using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dbsys.Forms
{
    public partial class Frm_Customer_Movie1 : Form
    {
        

        public Frm_Customer_Movie1()
        {
            InitializeComponent();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_Customer_Dashboard cd = new Frm_Customer_Dashboard();
            cd.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string movie = "1";
            Frm_Customer_Purchase cp = new Frm_Customer_Purchase();
            cp.Show();
            cp.setValues(movie,lblMovieTitle.Text,lblPrice.Text);
            this.Dispose();
        }
    }
}
