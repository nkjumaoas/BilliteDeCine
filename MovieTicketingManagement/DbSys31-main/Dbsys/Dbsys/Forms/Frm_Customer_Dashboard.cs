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
    public partial class Frm_Customer_Dashboard : Form
    {
        private PictureBox[] pictureBoxes; // Array to store PictureBox controls
        public Frm_Customer_Dashboard()
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
            Frm_Movie1 m1 = new Frm_Movie1();
            // Check if the PictureBox has an image
            if (pictureBoxes[0].Image != null)
            {
                m1.Show();
                this.Hide();
            }
        }

        private void pbMovie2_Click(object sender, EventArgs e)
        {
            Frm_Movie2 m2 = new Frm_Movie2();
            // Check if the PictureBox has an image
            if (pictureBoxes[1].Image != null)
            {
                m2.Show();
                this.Hide();
            }
        }

        private void pbMovie3_Click(object sender, EventArgs e)
        {
            Frm_Movie3 m3 = new Frm_Movie3();
            // Check if the PictureBox has an image
            if (pictureBoxes[2].Image != null)
            {
                m3.Show();
                this.Hide();
            }
        }

        private void pbMovie4_Click(object sender, EventArgs e)
        {
            Frm_Movie4 m4 = new Frm_Movie4();
            //Check if the PictureBox has an image
            if (pictureBoxes[3].Image != null)
            {
                m4.Show();
                this.Hide();
            }
            //Frm_Movie4 m4 = new Frm_Movie4();
            //m4.Show();
            //this.Hide();
        }

        private void pbMovie5_Click(object sender, EventArgs e)
        {
            Frm_Movie5 m5 = new Frm_Movie5();
            // Check if the PictureBox has an image
            if (pictureBoxes[4].Image != null)
            {
                m5.Show();
                this.Hide();
            }
        }

        private void pbMovie6_Click(object sender, EventArgs e)
        {
            Frm_Movie6 m6 = new Frm_Movie6();
            // Check if the PictureBox has an image
            if (pictureBoxes[5].Image != null)
            {
                m6.Show();
                this.Hide();
            }
        }

        private void pbMovie7_Click(object sender, EventArgs e)
        {
            Frm_Movie7 m7 = new Frm_Movie7();
            // Check if the PictureBox has an image
            if (pictureBoxes[6].Image != null)
            {
                m7.Show();
                this.Hide();
            }
        }

        private void pbMovie8_Click(object sender, EventArgs e)
        {
            Frm_Movie8 m8 = new Frm_Movie8();
            // Check if the PictureBox has an image
            if (pictureBoxes[7].Image != null)
            {
                m8.Show();
                this.Hide();
            }
        }
    }
}
