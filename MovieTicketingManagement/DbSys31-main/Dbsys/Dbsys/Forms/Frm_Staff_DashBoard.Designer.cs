namespace Dbsys.Forms
{
    partial class Frm_Staff_DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Staff_DashBoard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAddMovies = new System.Windows.Forms.Button();
            this.btnTotalSales = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1545, 100);
            this.panel2.TabIndex = 86;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Maroon;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Switch Account",
            "Log Out"});
            this.comboBox1.Location = new System.Drawing.Point(1344, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 29);
            this.comboBox1.TabIndex = 109;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(178, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 44;
            this.label5.Text = "-MOVIE TICKET-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(132, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 39);
            this.label4.TabIndex = 43;
            this.label4.Text = "Billete de Cine";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1351, 16);
            this.label1.TabIndex = 87;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_______________________________";
            // 
            // btnUser
            // 
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(600, 486);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(335, 59);
            this.btnUser.TabIndex = 93;
            this.btnUser.Text = "USER";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAddMovies
            // 
            this.btnAddMovies.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddMovies.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMovies.Location = new System.Drawing.Point(600, 384);
            this.btnAddMovies.Name = "btnAddMovies";
            this.btnAddMovies.Size = new System.Drawing.Size(335, 60);
            this.btnAddMovies.TabIndex = 92;
            this.btnAddMovies.Text = "ADD MOVIES";
            this.btnAddMovies.UseVisualStyleBackColor = true;
            this.btnAddMovies.Click += new System.EventHandler(this.btnAddMovies_Click);
            // 
            // btnTotalSales
            // 
            this.btnTotalSales.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTotalSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSales.Location = new System.Drawing.Point(600, 287);
            this.btnTotalSales.Name = "btnTotalSales";
            this.btnTotalSales.Size = new System.Drawing.Size(335, 60);
            this.btnTotalSales.TabIndex = 91;
            this.btnTotalSales.Text = "TOTAL SALES";
            this.btnTotalSales.UseVisualStyleBackColor = true;
            this.btnTotalSales.Click += new System.EventHandler(this.btnTotalSales_Click);
            // 
            // Frm_Staff_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1534, 833);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnAddMovies);
            this.Controls.Add(this.btnTotalSales);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Staff_DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Staff_DashBoard";
            this.Load += new System.EventHandler(this.Frm_Teacher_DashBoard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnAddMovies;
        private System.Windows.Forms.Button btnTotalSales;
    }
}