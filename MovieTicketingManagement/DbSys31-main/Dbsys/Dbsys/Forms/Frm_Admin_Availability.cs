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
    public partial class Frm_Admin_Availability : Form
    {
        private PictureBox[] pictureBoxes; // Array to store PictureBox controls
        public Frm_Admin_Availability()
        {
            InitializeComponent();
            // Initialize PictureBox array
            pictureBoxes = new PictureBox[] { pbMovie1, pbMovie2, pbMovie3, pbMovie4, pbMovie5, pbMovie6, pbMovie7, pbMovie8 };
        }



        private void Frm_Teacher_DashBoard_Load(object sender, EventArgs e)
        {
            comboBox1.Text = UserLogged.GetInstance().UserAccount.userName;
            try
            {
                using (var db = new DBSYSEntities())
                {
                    // Get all movies from the database
                    List<Movies> movies = db.Movies.ToList();

                    // Display images in PictureBox controls
                    for (int i = 0; i < movies.Count && i < pictureBoxes.Length; i++)
                    {
                        string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", movies[i].Image);

                        if (File.Exists(imagePath))
                        {
                            pictureBoxes[i].Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show($"Image not found for movie {movies[i].MovieNo}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}", "Load Images Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Switch Account")
            {

                Frm_Login c = new Frm_Login();
                c.Show();
                this.Hide();

            }
            else if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() == "Log Out")
            {
                this.Close();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_Admin_DashBoard a = new Frm_Admin_DashBoard();  
            a.Show();
            this.Hide();
        }

        private void pbMovie1_Click(object sender, EventArgs e)
        {
            Frm_Admin_Movie1 a = new Frm_Admin_Movie1();
            a.Show();
            this.Hide();
        }
    }
}
