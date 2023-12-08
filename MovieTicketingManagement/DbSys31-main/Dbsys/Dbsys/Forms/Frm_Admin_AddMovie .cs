using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class Frm_Admin_AddMovie : Form
    {
        public bool hasChange = false;

        private String IMG_PATH = AppDomain.CurrentDomain.BaseDirectory + @"\Image";

        private DateTime originalSelectedDate;


        public Frm_Admin_AddMovie()
        {
            InitializeComponent();
            //
            if (Directory.Exists(IMG_PATH))
                Directory.CreateDirectory(IMG_PATH);

            Frm_Admin_AvailableMovie_Load(this, EventArgs.Empty);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_Customer_Dashboard cd = new Frm_Customer_Dashboard();
            cd.Show();
            this.Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            String path = ofd.FileName;

            lblPath.Text = path;
            pbMovie.Image = new Bitmap(path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String oldpath = lblPath.Text;

                String newFile = $"Img.{DateTime.Now.ToString("yyyy - M - d_H - m - ss")}.jpg";

                String newFilepath = Path.Combine(IMG_PATH, newFile);

                System.IO.File.Copy(oldpath, newFilepath);
                //MessageBox.Show("Uploaded");
                using (var db = new DBSYSEntities())
                {
                    var newMovie = new Movies();
                    newMovie.MovieNo = Convert.ToInt32(txtMovieNo.Text);
                    newMovie.MovieTitle = txtDescription.Text;
                    newMovie.Price = Convert.ToDecimal(txtPrice.Text);
                    newMovie.Availability = Convert.ToInt32(txtAvailability.Text);
                    newMovie.ShowingDate = Convert.ToDateTime(dtpShowDate.Text);
                    newMovie.Image = newFile;
                    db.Movies.Add(newMovie);
                    db.SaveChanges();

                    hasChange = true;
                    dgvAvailableMovie.DataSource = db.Movies.ToList();
                }
                MessageBox.Show("Data has been added ...", "Save new movies", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void clearfields()
        {
            txtMovieNo.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtAvailability.Clear();
            // Set back to the original selected date
            dtpShowDate.Value = originalSelectedDate;
            // Clear the image in the PictureBox
            pbMovie.Image = null;  



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Data has been updated...", "Update movies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_Admin_AvailableMovie_Load(sender, e);
            clearfields();*/
            try
            {
                // Get the selected movie number from the DataGridView
                int selectedMovieNo = Convert.ToInt32(dgvAvailableMovie.CurrentRow.Cells[0].Value);

                using (var db = new DBSYSEntities())
                {
                    // Find the movie with the selected movie number
                    var movieToUpdate = db.Movies.SingleOrDefault(m => m.MovieNo == selectedMovieNo);

                    if (movieToUpdate != null)
                    {
                        // Update the properties of the movie with the new values
                        movieToUpdate.MovieTitle = txtDescription.Text;
                        movieToUpdate.Price = Convert.ToDecimal(txtPrice.Text);
                        movieToUpdate.Availability = Convert.ToInt32(txtAvailability.Text);
                        movieToUpdate.ShowingDate = Convert.ToDateTime(dtpShowDate.Text);

                        db.SaveChanges();

                        MessageBox.Show("Record updated successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView after update
                        Frm_Admin_AvailableMovie_Load(sender, e);
                        clearfields();
                    }
                    else
                    {
                        MessageBox.Show("Selected record not found.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAvailableMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMovieNo.Text = dgvAvailableMovie[0, e.RowIndex].Value.ToString();
            txtDescription.Text = dgvAvailableMovie[1, e.RowIndex].Value.ToString();
            txtPrice.Text = dgvAvailableMovie[2, e.RowIndex].Value.ToString();
            txtAvailability.Text = dgvAvailableMovie[3, e.RowIndex].Value.ToString();
            //dtpShowDate.Text = dgvAvailableMovie[4, e.RowIndex].Value.ToString();
            // Store the original selected date
            originalSelectedDate = Convert.ToDateTime(dgvAvailableMovie[4, e.RowIndex].Value);

            dtpShowDate.Value = originalSelectedDate;

            // Retrieve the image file name from the DataGridView
            string imageName = dgvAvailableMovie[5, e.RowIndex].Value.ToString();

            // Construct the full path to the image
            string imagePath = Path.Combine(IMG_PATH, imageName);

            // Check if the file exists before attempting to load it
            if (File.Exists(imagePath))
            {
                // Load the image into the PictureBox
                pbMovie.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Handle the case where the image file is not found
                MessageBox.Show("Image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbMovie.Image = null; // Clear the PictureBox
            }



        }

        private void Frm_Admin_AvailableMovie_Load(object sender, EventArgs e)
        {
            cbUser.Text = UserLogged.GetInstance().UserAccount.userName;
            try
            {
                using (var db = new DBSYSEntities())
                {
                    // Load data from the Movies table into the DataGridView
                    dgvAvailableMovie.DataSource = db.Movies.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Load Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*var res = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                
                
                Frm_Admin_AvailableMovie_Load(sender, e);
                clearfields();
            }*/
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Get the selected movie number from the DataGridView
                    int selectedMovieNo = Convert.ToInt32(dgvAvailableMovie.CurrentRow.Cells[0].Value);

                    using (var db = new DBSYSEntities())
                    {
                        // Find the movie with the selected movie number
                        var movieToDelete = db.Movies.SingleOrDefault(m => m.MovieNo == selectedMovieNo);

                        if (movieToDelete != null)
                        {
                            // Remove the movie from the database
                            db.Movies.Remove(movieToDelete);
                            db.SaveChanges();

                            MessageBox.Show("Record deleted successfully.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView after deletion
                            Frm_Admin_AvailableMovie_Load(sender, e);
                            clearfields();
                        }
                        else
                        {
                            MessageBox.Show("Selected record not found.", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Frm_Admin_DashBoard d = new Frm_Admin_DashBoard();
            d.Show();
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
    }
}
