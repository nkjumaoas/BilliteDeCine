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
                MessageBox.Show("Uploaded");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
