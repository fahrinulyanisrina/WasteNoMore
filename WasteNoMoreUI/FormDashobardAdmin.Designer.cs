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
            label1.Location = new Point(638, 191);
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
            btnLogout.Location = new Point(1393, 787);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 53);
            btnLogout.TabIndex = 66;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pbAplikasi
            // 
            pbAplikasi.Image = (Image)resources.GetObject("pbAplikasi.Image");
            pbAplikasi.Location = new Point(1040, 360);
            pbAplikasi.Name = "pbAplikasi";
            pbAplikasi.Size = new Size(175, 182);
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
            pbKategori.Location = new Point(720, 360);
            pbKategori.Name = "pbKategori";
            pbKategori.Size = new Size(175, 182);
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
            pbPengguna.Location = new Point(389, 360);
            pbPengguna.Name = "pbPengguna";
            pbPengguna.Size = new Size(175, 182);
            pbPengguna.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPengguna.TabIndex = 61;
            pbPengguna.TabStop = false;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(629, 96);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(347, 78);
            lblJudul.TabIndex = 60;
            lblJudul.Text = "Dashboard";
            // 
            // btnPengguna
            // 
            btnPengguna.BackColor = SystemColors.ActiveCaption;
            btnPengguna.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengguna.ForeColor = SystemColors.ActiveCaptionText;
            btnPengguna.Location = new Point(401, 567);
            btnPengguna.Name = "btnPengguna";
            btnPengguna.Size = new Size(150, 77);
            btnPengguna.TabIndex = 59;
            btnPengguna.Text = "Pengguna";
            btnPengguna.UseVisualStyleBackColor = false;
            btnPengguna.Click += btnPengguna_Click;
            // 
            // FormDashobardAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1647, 901);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(pbAplikasi);
            Controls.Add(btnAplikasi);
            Controls.Add(pbKategori);
            Controls.Add(btnKategori);
            Controls.Add(pbPengguna);
            Controls.Add(lblJudul);
            Controls.Add(btnPengguna);
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