using System.Windows.Forms;

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
            pbKategori = new PictureBox();
            pbPengguna = new PictureBox();
            pictureBox1 = new PictureBox();
            lblJudul = new Label();
            lblPengguna = new Label();
            lblAplikasi = new Label();
            lblKategori = new Label();
            lblEntriSampah = new Label();
            label2 = new Label();
            pbHarga = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAplikasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPengguna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHarga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 67;
            label1.Text = "Admin WasteNoMore";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(739, 369);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(81, 24);
            btnLogout.TabIndex = 66;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pbAplikasi
            // 
            pbAplikasi.Image = (Image)resources.GetObject("pbAplikasi.Image");
            pbAplikasi.Location = new Point(436, 164);
            pbAplikasi.Margin = new Padding(2, 1, 2, 1);
            pbAplikasi.Name = "pbAplikasi";
            pbAplikasi.Size = new Size(129, 105);
            pbAplikasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAplikasi.TabIndex = 65;
            pbAplikasi.TabStop = false;
            pbAplikasi.Click += pbAplikasi_Click;
            // 
            // pbKategori
            // 
            pbKategori.Image = (Image)resources.GetObject("pbKategori.Image");
            pbKategori.Location = new Point(273, 164);
            pbKategori.Margin = new Padding(2, 1, 2, 1);
            pbKategori.Name = "pbKategori";
            pbKategori.Size = new Size(120, 105);
            pbKategori.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKategori.TabIndex = 63;
            pbKategori.TabStop = false;
            pbKategori.Click += pbKategori_Click;
            // 
            // pbPengguna
            // 
            pbPengguna.Image = (Image)resources.GetObject("pbPengguna.Image");
            pbPengguna.Location = new Point(107, 164);
            pbPengguna.Margin = new Padding(2, 1, 2, 1);
            pbPengguna.Name = "pbPengguna";
            pbPengguna.Size = new Size(122, 105);
            pbPengguna.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPengguna.TabIndex = 61;
            pbPengguna.TabStop = false;
            pbPengguna.Click += pbPengguna_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(938, 281);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(338, 41);
            lblJudul.Margin = new Padding(2, 0, 2, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(178, 41);
            lblJudul.TabIndex = 60;
            lblJudul.Text = "Dashboard";
            // 
            // lblPengguna
            // 
            lblPengguna.AutoSize = true;
            lblPengguna.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPengguna.Location = new Point(122, 270);
            lblPengguna.MaximumSize = new Size(140, 0);
            lblPengguna.Name = "lblPengguna";
            lblPengguna.Size = new Size(90, 40);
            lblPengguna.TabIndex = 71;
            lblPengguna.Text = "Manajemen Pengguna";
            lblPengguna.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAplikasi
            // 
            lblAplikasi.AutoSize = true;
            lblAplikasi.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAplikasi.Location = new Point(454, 270);
            lblAplikasi.Margin = new Padding(2, 0, 2, 0);
            lblAplikasi.MaximumSize = new Size(140, 0);
            lblAplikasi.Name = "lblAplikasi";
            lblAplikasi.Size = new Size(90, 40);
            lblAplikasi.TabIndex = 70;
            lblAplikasi.Text = "Manajemen Aplikasi";
            lblAplikasi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(286, 266);
            lblKategori.Margin = new Padding(2, 0, 2, 0);
            lblKategori.MaximumSize = new Size(140, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(90, 40);
            lblKategori.TabIndex = 69;
            lblKategori.Text = "Manajemen Kategori";
            lblKategori.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEntriSampah
            // 
            lblEntriSampah.AutoSize = true;
            lblEntriSampah.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntriSampah.Location = new Point(141, 276);
            lblEntriSampah.Margin = new Padding(2, 0, 2, 0);
            lblEntriSampah.Name = "lblEntriSampah";
            lblEntriSampah.Size = new Size(0, 20);
            lblEntriSampah.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(627, 270);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.MaximumSize = new Size(108, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 40);
            label2.TabIndex = 73;
            label2.Text = "Manajemen Harga";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbHarga
            // 
            pbHarga.Image = (Image)resources.GetObject("pbHarga.Image");
            pbHarga.Location = new Point(607, 164);
            pbHarga.Margin = new Padding(2, 1, 2, 1);
            pbHarga.Name = "pbHarga";
            pbHarga.Size = new Size(127, 105);
            pbHarga.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHarga.TabIndex = 72;
            pbHarga.TabStop = false;
            pbHarga.Click += pbHarga_Click;
            // 
            // FormDashobardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(738, 351);
            Controls.Add(label2);
            Controls.Add(pbHarga);
            Controls.Add(lblPengguna);
            Controls.Add(lblAplikasi);
            Controls.Add(lblKategori);
            Controls.Add(lblEntriSampah);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(pbAplikasi);
            Controls.Add(pbKategori);
            Controls.Add(pbPengguna);
            Controls.Add(lblJudul);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormDashobardAdmin";
            Text = "FormDashobardAdmin";
            FormClosed += FormDashobardAdmin_FormClosed;
            Load += FormDashobardAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pbAplikasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPengguna).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private PictureBox pbAplikasi;
        private PictureBox pbKategori;
        private PictureBox pictureBox1;
        private PictureBox pbPengguna;
        private Label lblJudul;
        private Label lblPengguna;
        private Label lblAplikasi;
        private Label lblKategori;
        private Label lblEntriSampah;
        private Label label2;
        private PictureBox pbHarga;
    }
}