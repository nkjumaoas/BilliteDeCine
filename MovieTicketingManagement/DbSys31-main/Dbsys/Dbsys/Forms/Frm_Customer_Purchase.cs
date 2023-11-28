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
    public partial class Frm_Customer_Purchase : Form
    {
        public bool hasChange = false;
        public Frm_Customer_Purchase()
        {
            InitializeComponent();
        }
        public void setValues(string movie,string title, string price)
        {
            txtMovieNo.Text = movie;
            txtDescription.Text = title;
            txtPrice.Text = price;
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
            try
            {
                using (var db = new DBSYSEntities())
                {
                    var newUserInformation = new UserInformation();
                    newUserInformation.MovieNo = Convert.ToInt32(txtMovieNo.Text);
                    newUserInformation.Description = txtDescription.Text;
                    newUserInformation.CustomerName = txtCustomerName.Text;
                    newUserInformation.ContactNo = txtContactNumber.Text;
                    newUserInformation.EmailAddress = txtEmailAddress.Text;
                    newUserInformation.Price = Convert.ToDecimal(txtPrice.Text);
                    newUserInformation.Quantity = Convert.ToInt32(txtQuantity.Text);
                    newUserInformation.TotalSales= Convert.ToInt64(txtTotalSales.Text);
                    db.UserInformation.Add(newUserInformation);
                    db.SaveChanges();

                    hasChange = true;
                    dgvUserInformation.DataSource = db.Movies.ToList();
                }
                MessageBox.Show("Data has been added ...", "Save new purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
