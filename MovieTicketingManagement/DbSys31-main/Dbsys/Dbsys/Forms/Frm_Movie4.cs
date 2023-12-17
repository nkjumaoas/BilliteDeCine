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
    public partial class Frm_Movie4 : Form
    {
        public Frm_Movie4()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_Admin_AvailableMovies cd = new Frm_Admin_AvailableMovies();
            cd.Show();
            this.Hide();
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

        private void Frm_Customer_Movie4_Load(object sender, EventArgs e)
        {
            cbUser.Text = UserLogged.GetInstance().UserAccount.userName;
            try
            {
                using (var db = new DBSYSEntities())
                {
                    // Replace 1 with the actual MovieNo associated with pbMovie1
                    var selectedMovie = db.Movies.FirstOrDefault(m => m.MovieNo == 4);

                    if (selectedMovie != null)
                    {
                        // Display movie information in labels
                        lblMovieNo.Text = $"{selectedMovie.MovieNo}";
                        lblMovieTitle.Text = $"{selectedMovie.MovieTitle}";
                        lblPrice.Text = $"{selectedMovie.Price:F2}";

                        // Check if ShowingDate is not null before calling ToShortDateString
                        lblShowDate.Text = $"{selectedMovie.ShowingDate?.ToShortDateString()}";
                    }
                    else
                    {
                        MessageBox.Show("Selected movie not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving movie information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_Admin_Purchase a = new Frm_Admin_Purchase();
            a.Show();
            a.setValues(lblMovieNo.Text, lblMovieTitle.Text, lblShowDate.Text, lblPrice.Text);
            this.Dispose();
        }
    }
}
