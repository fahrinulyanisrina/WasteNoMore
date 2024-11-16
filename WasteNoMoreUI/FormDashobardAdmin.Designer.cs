namespace WasteNoMoreUI
{
    partial class FormDashobardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashobardAdmin));
            label1 = new Label();
            btnLogout = new Button();
            pbAplikasi = new PictureBox();
            btnAplikasi = new Button();
            pbKategori = new PictureBox();
            btnKategori = new Button();
            pbPengguna = new PictureBox();
            lblJudul = new Label();
            btnPengguna = new Button();
            ((System.ComponentModel.ISupportInitialize)pbAplikasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPengguna).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(534, 195);
            label1.Name = "label1";
            label1.Size = new Size(315, 40);
            label1.TabIndex = 67;
            label1.Text = "Admin WasteNoMore";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(1184, 756);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 52);
            btnLogout.TabIndex = 66;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pbAplikasi
            // 
            pbAplikasi.Image = (Image)resources.GetObject("pbAplikasi.Image");
            pbAplikasi.Location = new Point(894, 360);
            pbAplikasi.Name = "pbAplikasi";
            pbAplikasi.Size = new Size(176, 182);
            pbAplikasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAplikasi.TabIndex = 65;
            pbAplikasi.TabStop = false;
            // 
            // btnAplikasi
            // 
            btnAplikasi.BackColor = SystemColors.ActiveCaption;
            btnAplikasi.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAplikasi.ForeColor = SystemColors.ActiveCaptionText;
            btnAplikasi.Location = new Point(1050, 568);
            btnAplikasi.Name = "btnAplikasi";
            btnAplikasi.Size = new Size(150, 77);
            btnAplikasi.TabIndex = 64;
            btnAplikasi.Text = "Aplikasi dan Harga";
            btnAplikasi.UseVisualStyleBackColor = false;
            btnAplikasi.Click += btnAplikasi_Click;
            // 
            // pbKategori
            // 
            pbKategori.Image = (Image)resources.GetObject("pbKategori.Image");
            pbKategori.Location = new Point(575, 360);
            pbKategori.Name = "pbKategori";
            pbKategori.Size = new Size(176, 182);
            pbKategori.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKategori.TabIndex = 63;
            pbKategori.TabStop = false;
            // 
            // btnKategori
            // 
            btnKategori.BackColor = SystemColors.ActiveCaption;
            btnKategori.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKategori.ForeColor = SystemColors.ActiveCaptionText;
            btnKategori.Location = new Point(735, 568);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(150, 77);
            btnKategori.TabIndex = 62;
            btnKategori.Text = "Kategori";
            btnKategori.UseVisualStyleBackColor = false;
            btnKategori.Click += btnKategori_Click;
            // 
            // pbPengguna
            // 
            pbPengguna.Image = (Image)resources.GetObject("pbPengguna.Image");
            pbPengguna.Location = new Point(243, 360);
            pbPengguna.Name = "pbPengguna";
            pbPengguna.Size = new Size(176, 182);
            pbPengguna.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPengguna.TabIndex = 61;
            pbPengguna.TabStop = false;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(525, 100);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(347, 78);
            lblJudul.TabIndex = 60;
            lblJudul.Text = "Dashboard";
            // 
            // btnPengguna
            // 
            lblPengguna.AutoSize = true;
            lblPengguna.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPengguna.Location = new Point(247, 545);
            lblPengguna.Margin = new Padding(4, 0, 4, 0);
            lblPengguna.MaximumSize = new Size(260, 0);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(172, 80);
            lblPengguna.TabIndex = 71;
            lblPengguna.Text = "Manajemen Pengguna";
            lblPengguna.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAplikasi
            // 
            lblAplikasi.AutoSize = true;
            lblAplikasi.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAplikasi.Location = new Point(894, 545);
            lblAplikasi.Margin = new Padding(4, 0, 4, 0);
            lblAplikasi.MaximumSize = new Size(260, 0);
            lblAplikasi.Name = "lblAplikasi";
            lblAplikasi.Size = new Size(177, 120);
            lblAplikasi.TabIndex = 70;
            lblAplikasi.Text = "Manajemen Aplikasi dan Harga";
            lblAplikasi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(579, 545);
            lblKategori.Margin = new Padding(4, 0, 4, 0);
            lblKategori.MaximumSize = new Size(260, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(172, 80);
            lblKategori.TabIndex = 69;
            lblKategori.Text = "Manajemen Kategori";
            lblKategori.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEntriSampah
            // 
            lblEntriSampah.AutoSize = true;
            lblEntriSampah.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntriSampah.Location = new Point(506, 712);
            lblEntriSampah.Margin = new Padding(4, 0, 4, 0);
            lblEntriSampah.Name = "lblEntriSampah";
            lblEntriSampah.Size = new Size(0, 40);
            lblEntriSampah.TabIndex = 68;
            // 
            // FormDashobardAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1414, 862);
            Controls.Add(lblPengguna);
            Controls.Add(lblAplikasi);
            Controls.Add(lblKategori);
            Controls.Add(lblEntriSampah);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(pbAplikasi);
            Controls.Add(btnAplikasi);
            Controls.Add(pbKategori);
            Controls.Add(btnKategori);
            Controls.Add(pbPengguna);
            Controls.Add(lblJudul);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormDashobardAdmin";
            Text = "FormDashobardAdmin";
            ((System.ComponentModel.ISupportInitialize)pbAplikasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPengguna).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private PictureBox pbAplikasi;
        private Button btnAplikasi;
        private PictureBox pbKategori;
        private Button btnKategori;
        private PictureBox pbPengguna;
        private Label lblJudul;
        private Button btnPengguna;
    }
}