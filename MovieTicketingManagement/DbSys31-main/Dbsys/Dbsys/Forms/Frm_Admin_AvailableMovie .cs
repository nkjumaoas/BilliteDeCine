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
    public partial class Frm_Admin_AvailableMovie : Form
    {
        public bool hasChange = false;


        private String IMG_PATH = AppDomain.CurrentDomain.BaseDirectory + @"\Image";

        public Frm_Admin_AvailableMovie()
        {
            InitializeComponent();
            //
            if (Directory.Exists(IMG_PATH))
                Directory.CreateDirectory(IMG_PATH);


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
                    newMovie.Description = txtDescription.Text;
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
            //dtpShowDate.Clear();
            //pbMovie.Clear();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data has been updated...", "Update movies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_Admin_AvailableMovie_Load(sender, e);
            clearfields();
        }

        private void dgvAvailableMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMovieNo.Text = dgvAvailableMovie[0, e.RowIndex].Value.ToString();
            txtDescription.Text = dgvAvailableMovie[1, e.RowIndex].Value.ToString();
            txtPrice.Text = dgvAvailableMovie[2, e.RowIndex].Value.ToString();
            txtAvailability.Text = dgvAvailableMovie[3, e.RowIndex].Value.ToString();
            dtpShowDate.Text = dgvAvailableMovie[4, e.RowIndex].Value.ToString();
        }

        private void Frm_Admin_AvailableMovie_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                
                
                Frm_Admin_AvailableMovie_Load(sender, e);
                clearfields();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Frm_Admin_DashBoard d = new Frm_Admin_DashBoard();
            d.Show();
            this.Hide();
        }
    }
}
