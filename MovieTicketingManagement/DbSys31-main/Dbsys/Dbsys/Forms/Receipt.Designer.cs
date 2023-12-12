namespace Dbsys.Forms
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmovietitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.php = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblShowingDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblticketno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lblmovietitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-3, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 161);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblmovietitle
            // 
            this.lblmovietitle.AutoSize = true;
            this.lblmovietitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmovietitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblmovietitle.Location = new System.Drawing.Point(113, 8);
            this.lblmovietitle.Name = "lblmovietitle";
            this.lblmovietitle.Size = new System.Drawing.Size(36, 28);
            this.lblmovietitle.TabIndex = 48;
            this.lblmovietitle.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(46, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "TITLE :";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.php);
            this.panel4.Controls.Add(this.lblTotalAmount);
            this.panel4.Location = new System.Drawing.Point(456, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 75);
            this.panel4.TabIndex = 44;
            // 
            // php
            // 
            this.php.AutoSize = true;
            this.php.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.php.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.php.ForeColor = System.Drawing.SystemColors.Window;
            this.php.Location = new System.Drawing.Point(43, 22);
            this.php.Name = "php";
            this.php.Size = new System.Drawing.Size(48, 28);
            this.php.TabIndex = 104;
            this.php.Text = "PHP";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotalAmount.Location = new System.Drawing.Point(98, 22);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(36, 28);
            this.lblTotalAmount.TabIndex = 103;
            this.lblTotalAmount.Text = "---";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblShowingDate);
            this.panel2.Location = new System.Drawing.Point(47, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 75);
            this.panel2.TabIndex = 42;
            // 
            // lblShowingDate
            // 
            this.lblShowingDate.AutoSize = true;
            this.lblShowingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblShowingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowingDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblShowingDate.Location = new System.Drawing.Point(54, 22);
            this.lblShowingDate.Name = "lblShowingDate";
            this.lblShowingDate.Size = new System.Drawing.Size(36, 28);
            this.lblShowingDate.TabIndex = 101;
            this.lblShowingDate.Text = "---";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblQuantity);
            this.panel3.Location = new System.Drawing.Point(247, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 75);
            this.panel3.TabIndex = 43;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuantity.Location = new System.Drawing.Point(87, 22);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(36, 28);
            this.lblQuantity.TabIndex = 102;
            this.lblQuantity.Text = "---";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 97);
            this.label3.TabIndex = 40;
            this.label3.Text = "Billete de Cine";
            // 
            // lblticketno
            // 
            this.lblticketno.AutoSize = true;
            this.lblticketno.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticketno.ForeColor = System.Drawing.SystemColors.Window;
            this.lblticketno.Location = new System.Drawing.Point(685, 5);
            this.lblticketno.Name = "lblticketno";
            this.lblticketno.Size = new System.Drawing.Size(31, 23);
            this.lblticketno.TabIndex = 45;
            this.lblticketno.Text = "---";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(740, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblticketno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblShowingDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label php;
        private System.Windows.Forms.Label lblticketno;
        private System.Windows.Forms.Label lblmovietitle;
        private System.Windows.Forms.Label label2;
    }
}