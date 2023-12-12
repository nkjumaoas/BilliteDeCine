namespace Dbsys.Forms
{
    partial class Frm_Admin_Purchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin_Purchase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.MovieNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblMovieNo = new System.Windows.Forms.Label();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblShowDate = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.panel2.TabIndex = 85;
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
            this.label1.TabIndex = 86;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_______________________________";
            // 
            // dgvPurchase
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieNo,
            this.Description,
            this.Price,
            this.Quantity,
            this.TotalSales,
            this.delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchase.Location = new System.Drawing.Point(665, 166);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.RowHeadersWidth = 51;
            this.dgvPurchase.RowTemplate.Height = 24;
            this.dgvPurchase.Size = new System.Drawing.Size(801, 296);
            this.dgvPurchase.TabIndex = 88;
            this.dgvPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellContentClick);
            // 
            // MovieNo
            // 
            this.MovieNo.HeaderText = "MovieNo";
            this.MovieNo.MinimumWidth = 6;
            this.MovieNo.Name = "MovieNo";
            this.MovieNo.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Movie Title";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // TotalSales
            // 
            this.TotalSales.HeaderText = "Total Sales";
            this.TotalSales.MinimumWidth = 6;
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.Width = 125;
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "Cancel";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Text = "X";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBox1.Controls.Add(this.lblShowDate);
            this.groupBox1.Controls.Add(this.cbUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblMovieTitle);
            this.groupBox1.Controls.Add(this.lblMovieNo);
            this.groupBox1.Controls.Add(this.nupQuantity);
            this.groupBox1.Controls.Add(this.lblTotalSales);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(139, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 654);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase";
            // 
            // cbUser
            // 
            this.cbUser.BackColor = System.Drawing.Color.Maroon;
            this.cbUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUser.ForeColor = System.Drawing.SystemColors.Window;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Items.AddRange(new object[] {
            "Switch Account",
            "Log Out"});
            this.cbUser.Location = new System.Drawing.Point(1344, 70);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(189, 29);
            this.cbUser.TabIndex = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(67, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 172;
            this.label2.Text = "Showing Date:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(246, 307);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 23);
            this.lblPrice.TabIndex = 171;
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.ForeColor = System.Drawing.Color.White;
            this.lblMovieTitle.Location = new System.Drawing.Point(242, 178);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(0, 23);
            this.lblMovieTitle.TabIndex = 170;
            // 
            // lblMovieNo
            // 
            this.lblMovieNo.AutoSize = true;
            this.lblMovieNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieNo.ForeColor = System.Drawing.Color.White;
            this.lblMovieNo.Location = new System.Drawing.Point(242, 118);
            this.lblMovieNo.Name = "lblMovieNo";
            this.lblMovieNo.Size = new System.Drawing.Size(0, 23);
            this.lblMovieNo.TabIndex = 169;
            // 
            // nupQuantity
            // 
            this.nupQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nupQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupQuantity.ForeColor = System.Drawing.SystemColors.Menu;
            this.nupQuantity.Location = new System.Drawing.Point(250, 359);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(62, 32);
            this.nupQuantity.TabIndex = 168;
            this.nupQuantity.ValueChanged += new System.EventHandler(this.nupQuantity_ValueChanged);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblTotalSales.Location = new System.Drawing.Point(246, 437);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(0, 23);
            this.lblTotalSales.TabIndex = 167;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(65, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 23);
            this.label10.TabIndex = 153;
            this.label10.Text = "Movie No:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(317, 551);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 48);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Confirm";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(65, 368);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 23);
            this.label14.TabIndex = 156;
            this.label14.Text = "Quantity:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(65, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 23);
            this.label13.TabIndex = 155;
            this.label13.Text = "Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(65, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 23);
            this.label9.TabIndex = 135;
            this.label9.Text = "Total Sales:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(65, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 23);
            this.label11.TabIndex = 145;
            this.label11.Text = "Movie Title:";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.BackColor = System.Drawing.Color.Maroon;
            this.btnBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuyTicket.Location = new System.Drawing.Point(878, 668);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(420, 63);
            this.btnBuyTicket.TabIndex = 91;
            this.btnBuyTicket.Text = "BUY TICKET";
            this.btnBuyTicket.UseVisualStyleBackColor = false;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(35, 132);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(76, 66);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 92;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click_1);
            // 
            // lblShowDate
            // 
            this.lblShowDate.AutoSize = true;
            this.lblShowDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDate.ForeColor = System.Drawing.Color.White;
            this.lblShowDate.Location = new System.Drawing.Point(242, 244);
            this.lblShowDate.Name = "lblShowDate";
            this.lblShowDate.Size = new System.Drawing.Size(0, 23);
            this.lblShowDate.TabIndex = 174;
            // 
            // Frm_Admin_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1534, 833);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPurchase);
            this.Name = "Frm_Admin_Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Customer_Movie3";
            this.Load += new System.EventHandler(this.Frm_Customer_Purchase_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSales;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Label lblMovieNo;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblShowDate;
    }
}