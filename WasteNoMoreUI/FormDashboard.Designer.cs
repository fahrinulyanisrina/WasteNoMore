namespace WasteNoMoreUI
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            btnEntriSampah = new Button();
            lblJudul = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnTrack = new Button();
            pictureBox3 = new PictureBox();
            btnBandingHarga = new Button();
            btnLogout = new Button();
            label1 = new Label();
            lblEntriSampah = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnEntriSampah
            // 
            btnEntriSampah.BackColor = SystemColors.ActiveCaption;
            btnEntriSampah.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntriSampah.ForeColor = SystemColors.ActiveCaptionText;
            btnEntriSampah.Location = new Point(389, 644);
            btnEntriSampah.Name = "btnEntriSampah";
            btnEntriSampah.Size = new Size(150, 77);
            btnEntriSampah.TabIndex = 50;
            btnEntriSampah.Text = "Entri Sampah";
            btnEntriSampah.UseVisualStyleBackColor = false;
            btnEntriSampah.Click += btnEntriSampah_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(595, 92);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(347, 78);
            lblJudul.TabIndex = 51;
            lblJudul.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 386);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(671, 386);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 214);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // btnTrack
            // 
            btnTrack.BackColor = SystemColors.ActiveCaption;
            btnTrack.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrack.ForeColor = SystemColors.ActiveCaptionText;
            btnTrack.Location = new Point(698, 644);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(150, 77);
            btnTrack.TabIndex = 53;
            btnTrack.Text = "Tracking Sampah";
            btnTrack.UseVisualStyleBackColor = false;
            btnTrack.Click += btnTrack_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(983, 386);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(213, 214);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // btnBandingHarga
            // 
            btnBandingHarga.BackColor = SystemColors.ActiveCaption;
            btnBandingHarga.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBandingHarga.ForeColor = SystemColors.ActiveCaptionText;
            btnBandingHarga.Location = new Point(1008, 644);
            btnBandingHarga.Name = "btnBandingHarga";
            btnBandingHarga.Size = new Size(150, 77);
            btnBandingHarga.TabIndex = 55;
            btnBandingHarga.Text = "Banding Harga";
            btnBandingHarga.UseVisualStyleBackColor = false;
            btnBandingHarga.Click += btnBandingHarga_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(1359, 783);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 53);
            btnLogout.TabIndex = 57;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(507, 190);
            label1.Name = "label1";
            label1.Size = new Size(489, 40);
            label1.TabIndex = 58;
            label1.Text = "Selamat Datang di WasteNoMOre!";
            // 
            // lblEntriSampah
            // 
            lblEntriSampah.AutoSize = true;
            lblEntriSampah.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntriSampah.Location = new Point(366, 614);
            lblEntriSampah.Name = "lblEntriSampah";
            lblEntriSampah.Size = new Size(0, 40);
            lblEntriSampah.TabIndex = 59;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1554, 874);
            Controls.Add(lblEntriSampah);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(pictureBox3);
            Controls.Add(btnBandingHarga);
            Controls.Add(pictureBox2);
            Controls.Add(btnTrack);
            Controls.Add(pictureBox1);
            Controls.Add(lblJudul);
            Controls.Add(btnEntriSampah);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEntriSampah;
        private Label lblJudul;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnTrack;
        private PictureBox pictureBox3;
        private Button btnBandingHarga;
        private Button btnLogout;
        private Label label1;
        private Label lblEntriSampah;
    }
}