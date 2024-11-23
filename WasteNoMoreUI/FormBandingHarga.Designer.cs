namespace WasteNoMoreUI
{
    partial class FormBandingHarga
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBandingHarga));
            btnCancelBanding = new Button();
            btnBandingkan = new Button();
            lblBandingHarga = new Label();
            txtKuantitas = new TextBox();
            lblKg = new Label();
            lblBeratBanding = new Label();
            lblKategoriBanding = new Label();
            label1 = new Label();
            dgvBandingHarga = new DataGridView();
            lblAplikasiBanding = new Label();
            clbAplikasi = new CheckedListBox();
            clbKategori = new CheckedListBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidebar = new FlowLayoutPanel();
            pnDashboard = new Panel();
            btnNavbarDashboard = new Button();
            pnEntri = new Panel();
            btnNavbarEntri = new Button();
            pnTrack = new Panel();
            btnNavbarTrack = new Button();
            pnBandingHarga = new Panel();
            btnNavbarBandingHarga = new Button();
            pnPanduan = new Panel();
            btnNavbarPanduan = new Button();
            pnAkun = new Panel();
            btnNavbarAkun = new Button();
            pnLogout = new Panel();
            btnNavbarLogout = new Button();
            pnNavbar = new Panel();
            pbNavbar = new PictureBox();
            lblHasilPerbandingan = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBandingHarga).BeginInit();
            sidebar.SuspendLayout();
            pnDashboard.SuspendLayout();
            pnEntri.SuspendLayout();
            pnTrack.SuspendLayout();
            pnBandingHarga.SuspendLayout();
            pnPanduan.SuspendLayout();
            pnAkun.SuspendLayout();
            pnLogout.SuspendLayout();
            pnNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNavbar).BeginInit();
            SuspendLayout();
            // 
            // btnCancelBanding
            // 
            btnCancelBanding.BackColor = SystemColors.ControlDarkDark;
            btnCancelBanding.ForeColor = SystemColors.ButtonHighlight;
            btnCancelBanding.Location = new Point(1231, 771);
            btnCancelBanding.Name = "btnCancelBanding";
            btnCancelBanding.Size = new Size(150, 46);
            btnCancelBanding.TabIndex = 50;
            btnCancelBanding.Text = "Cancel";
            btnCancelBanding.UseVisualStyleBackColor = false;
            btnCancelBanding.Click += btnCancelBanding_Click;
            // 
            // btnBandingkan
            // 
            btnBandingkan.BackColor = SystemColors.HotTrack;
            btnBandingkan.ForeColor = SystemColors.ButtonHighlight;
            btnBandingkan.Location = new Point(1105, 315);
            btnBandingkan.Name = "btnBandingkan";
            btnBandingkan.Size = new Size(198, 46);
            btnBandingkan.TabIndex = 49;
            btnBandingkan.Text = "Bandingkan";
            btnBandingkan.UseVisualStyleBackColor = false;
            btnBandingkan.Click += btnBandingkan_Click;
            // 
            // lblBandingHarga
            // 
            lblBandingHarga.AutoSize = true;
            lblBandingHarga.Font = new Font("Segoe UI Semibold", 11.125F, FontStyle.Bold);
            lblBandingHarga.Location = new Point(478, 119);
            lblBandingHarga.Name = "lblBandingHarga";
            lblBandingHarga.Size = new Size(678, 41);
            lblBandingHarga.TabIndex = 48;
            lblBandingHarga.Text = "Bandingkan Harga Sampah di Berbagai Aplikasi!";
            lblBandingHarga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtKuantitas
            // 
            txtKuantitas.Location = new Point(1163, 214);
            txtKuantitas.Name = "txtKuantitas";
            txtKuantitas.Size = new Size(140, 39);
            txtKuantitas.TabIndex = 46;
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Location = new Point(1329, 216);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(40, 32);
            lblKg.TabIndex = 45;
            lblKg.Text = "kg";
            // 
            // lblBeratBanding
            // 
            lblBeratBanding.AutoSize = true;
            lblBeratBanding.Location = new Point(982, 214);
            lblBeratBanding.Name = "lblBeratBanding";
            lblBeratBanding.Size = new Size(174, 32);
            lblBeratBanding.TabIndex = 44;
            lblBeratBanding.Text = "Berat Sampah :";
            // 
            // lblKategoriBanding
            // 
            lblKategoriBanding.AutoSize = true;
            lblKategoriBanding.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategoriBanding.Location = new Point(562, 214);
            lblKategoriBanding.Name = "lblKategoriBanding";
            lblKategoriBanding.Size = new Size(115, 32);
            lblKategoriBanding.TabIndex = 43;
            lblKategoriBanding.Text = "Kategori :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 42;
            // 
            // dgvBandingHarga
            // 
            dgvBandingHarga.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvBandingHarga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBandingHarga.Location = new Point(178, 486);
            dgvBandingHarga.Margin = new Padding(4);
            dgvBandingHarga.Name = "dgvBandingHarga";
            dgvBandingHarga.RowHeadersWidth = 62;
            dgvBandingHarga.Size = new Size(1203, 239);
            dgvBandingHarga.TabIndex = 52;
            dgvBandingHarga.CellContentClick += dgvBandingHarga_CellContentClick;
            // 
            // lblAplikasiBanding
            // 
            lblAplikasiBanding.AutoSize = true;
            lblAplikasiBanding.Location = new Point(178, 214);
            lblAplikasiBanding.Name = "lblAplikasiBanding";
            lblAplikasiBanding.Size = new Size(107, 32);
            lblAplikasiBanding.TabIndex = 54;
            lblAplikasiBanding.Text = "Aplikasi :";
            // 
            // clbAplikasi
            // 
            clbAplikasi.FormattingEnabled = true;
            clbAplikasi.Location = new Point(291, 214);
            clbAplikasi.Margin = new Padding(4);
            clbAplikasi.Name = "clbAplikasi";
            clbAplikasi.Size = new Size(242, 148);
            clbAplikasi.TabIndex = 55;
            clbAplikasi.SelectedIndexChanged += clbAplikasi_SelectedIndexChanged;
            // 
            // clbKategori
            // 
            clbKategori.FormattingEnabled = true;
            clbKategori.Location = new Point(680, 214);
            clbKategori.Margin = new Padding(4);
            clbKategori.Name = "clbKategori";
            clbKategori.Size = new Size(242, 148);
            clbKategori.TabIndex = 56;
            clbKategori.SelectedIndexChanged += clbKategori_SelectedIndexChanged;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick_1;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.GradientActiveCaption;
            sidebar.Controls.Add(pnDashboard);
            sidebar.Controls.Add(pnEntri);
            sidebar.Controls.Add(pnTrack);
            sidebar.Controls.Add(pnBandingHarga);
            sidebar.Controls.Add(pnPanduan);
            sidebar.Controls.Add(pnAkun);
            sidebar.Controls.Add(pnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 67);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 20, 0, 0);
            sidebar.Size = new Size(107, 762);
            sidebar.TabIndex = 70;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(btnNavbarDashboard);
            pnDashboard.Location = new Point(3, 23);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(397, 70);
            pnDashboard.TabIndex = 69;
            // 
            // btnNavbarDashboard
            // 
            btnNavbarDashboard.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarDashboard.FlatStyle = FlatStyle.Flat;
            btnNavbarDashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarDashboard.Image = (Image)resources.GetObject("btnNavbarDashboard.Image");
            btnNavbarDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarDashboard.Location = new Point(3, -3);
            btnNavbarDashboard.Name = "btnNavbarDashboard";
            btnNavbarDashboard.Padding = new Padding(25, 0, 0, 0);
            btnNavbarDashboard.Size = new Size(391, 70);
            btnNavbarDashboard.TabIndex = 70;
            btnNavbarDashboard.Text = "         Dashboard";
            btnNavbarDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarDashboard.UseVisualStyleBackColor = false;
            btnNavbarDashboard.Click += btnNavbarDashboard_Click;
            // 
            // pnEntri
            // 
            pnEntri.Controls.Add(btnNavbarEntri);
            pnEntri.Location = new Point(3, 99);
            pnEntri.Name = "pnEntri";
            pnEntri.Size = new Size(397, 70);
            pnEntri.TabIndex = 71;
            // 
            // btnNavbarEntri
            // 
            btnNavbarEntri.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarEntri.FlatStyle = FlatStyle.Flat;
            btnNavbarEntri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarEntri.Image = (Image)resources.GetObject("btnNavbarEntri.Image");
            btnNavbarEntri.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarEntri.Location = new Point(3, -3);
            btnNavbarEntri.Name = "btnNavbarEntri";
            btnNavbarEntri.Padding = new Padding(25, 0, 0, 0);
            btnNavbarEntri.Size = new Size(391, 70);
            btnNavbarEntri.TabIndex = 70;
            btnNavbarEntri.Text = "         Entri Sampah";
            btnNavbarEntri.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarEntri.UseVisualStyleBackColor = false;
            btnNavbarEntri.Click += btnNavbarEntri_Click;
            // 
            // pnTrack
            // 
            pnTrack.Controls.Add(btnNavbarTrack);
            pnTrack.Location = new Point(3, 175);
            pnTrack.Name = "pnTrack";
            pnTrack.Size = new Size(397, 70);
            pnTrack.TabIndex = 71;
            // 
            // btnNavbarTrack
            // 
            btnNavbarTrack.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarTrack.FlatStyle = FlatStyle.Flat;
            btnNavbarTrack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarTrack.Image = (Image)resources.GetObject("btnNavbarTrack.Image");
            btnNavbarTrack.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarTrack.Location = new Point(3, -3);
            btnNavbarTrack.Name = "btnNavbarTrack";
            btnNavbarTrack.Padding = new Padding(25, 0, 0, 0);
            btnNavbarTrack.Size = new Size(391, 70);
            btnNavbarTrack.TabIndex = 70;
            btnNavbarTrack.Text = "         Tracking Sampah";
            btnNavbarTrack.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarTrack.UseVisualStyleBackColor = false;
            btnNavbarTrack.Click += btnNavbarTrack_Click;
            // 
            // pnBandingHarga
            // 
            pnBandingHarga.Controls.Add(btnNavbarBandingHarga);
            pnBandingHarga.Location = new Point(3, 251);
            pnBandingHarga.Name = "pnBandingHarga";
            pnBandingHarga.Size = new Size(397, 70);
            pnBandingHarga.TabIndex = 70;
            // 
            // btnNavbarBandingHarga
            // 
            btnNavbarBandingHarga.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarBandingHarga.FlatStyle = FlatStyle.Flat;
            btnNavbarBandingHarga.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarBandingHarga.Image = (Image)resources.GetObject("btnNavbarBandingHarga.Image");
            btnNavbarBandingHarga.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarBandingHarga.Location = new Point(3, -3);
            btnNavbarBandingHarga.Name = "btnNavbarBandingHarga";
            btnNavbarBandingHarga.Padding = new Padding(25, 0, 0, 0);
            btnNavbarBandingHarga.Size = new Size(391, 70);
            btnNavbarBandingHarga.TabIndex = 70;
            btnNavbarBandingHarga.Text = "         Banding Harga";
            btnNavbarBandingHarga.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarBandingHarga.UseVisualStyleBackColor = false;
            btnNavbarBandingHarga.Click += btnNavbarBandingHarga_Click;
            // 
            // pnPanduan
            // 
            pnPanduan.Controls.Add(btnNavbarPanduan);
            pnPanduan.Location = new Point(3, 327);
            pnPanduan.Name = "pnPanduan";
            pnPanduan.Size = new Size(397, 70);
            pnPanduan.TabIndex = 72;
            // 
            // btnNavbarPanduan
            // 
            btnNavbarPanduan.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarPanduan.FlatStyle = FlatStyle.Flat;
            btnNavbarPanduan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarPanduan.Image = (Image)resources.GetObject("btnNavbarPanduan.Image");
            btnNavbarPanduan.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarPanduan.Location = new Point(3, -3);
            btnNavbarPanduan.Name = "btnNavbarPanduan";
            btnNavbarPanduan.Padding = new Padding(25, 0, 0, 0);
            btnNavbarPanduan.Size = new Size(391, 70);
            btnNavbarPanduan.TabIndex = 70;
            btnNavbarPanduan.Text = "         Panduan";
            btnNavbarPanduan.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarPanduan.UseVisualStyleBackColor = false;
            // 
            // pnAkun
            // 
            pnAkun.Controls.Add(btnNavbarAkun);
            pnAkun.Location = new Point(3, 403);
            pnAkun.Name = "pnAkun";
            pnAkun.Size = new Size(397, 70);
            pnAkun.TabIndex = 73;
            // 
            // btnNavbarAkun
            // 
            btnNavbarAkun.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarAkun.FlatStyle = FlatStyle.Flat;
            btnNavbarAkun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarAkun.Image = (Image)resources.GetObject("btnNavbarAkun.Image");
            btnNavbarAkun.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarAkun.Location = new Point(3, -3);
            btnNavbarAkun.Name = "btnNavbarAkun";
            btnNavbarAkun.Padding = new Padding(25, 0, 0, 0);
            btnNavbarAkun.Size = new Size(391, 70);
            btnNavbarAkun.TabIndex = 70;
            btnNavbarAkun.Text = "         Akun";
            btnNavbarAkun.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarAkun.UseVisualStyleBackColor = false;
            btnNavbarAkun.Click += btnNavbarAkun_Click;
            // 
            // pnLogout
            // 
            pnLogout.Controls.Add(btnNavbarLogout);
            pnLogout.Location = new Point(3, 479);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(397, 70);
            pnLogout.TabIndex = 74;
            // 
            // btnNavbarLogout
            // 
            btnNavbarLogout.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarLogout.FlatStyle = FlatStyle.Flat;
            btnNavbarLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarLogout.Image = (Image)resources.GetObject("btnNavbarLogout.Image");
            btnNavbarLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarLogout.Location = new Point(3, -3);
            btnNavbarLogout.Name = "btnNavbarLogout";
            btnNavbarLogout.Padding = new Padding(25, 0, 0, 0);
            btnNavbarLogout.Size = new Size(391, 70);
            btnNavbarLogout.TabIndex = 70;
            btnNavbarLogout.Text = "         Logout";
            btnNavbarLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarLogout.UseVisualStyleBackColor = false;
            btnNavbarLogout.Click += btnNavbarLogout_Click;
            // 
            // pnNavbar
            // 
            pnNavbar.BackColor = SystemColors.GradientActiveCaption;
            pnNavbar.Controls.Add(pbNavbar);
            pnNavbar.Dock = DockStyle.Top;
            pnNavbar.Location = new Point(0, 0);
            pnNavbar.Name = "pnNavbar";
            pnNavbar.Size = new Size(1474, 67);
            pnNavbar.TabIndex = 69;
            // 
            // pbNavbar
            // 
            pbNavbar.Image = (Image)resources.GetObject("pbNavbar.Image");
            pbNavbar.Location = new Point(29, 12);
            pbNavbar.Name = "pbNavbar";
            pbNavbar.Size = new Size(58, 45);
            pbNavbar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNavbar.TabIndex = 0;
            pbNavbar.TabStop = false;
            pbNavbar.Click += pbNavbar_Click;
            // 
            // lblHasilPerbandingan
            // 
            lblHasilPerbandingan.AutoSize = true;
            lblHasilPerbandingan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblHasilPerbandingan.Location = new Point(653, 432);
            lblHasilPerbandingan.Name = "lblHasilPerbandingan";
            lblHasilPerbandingan.Size = new Size(268, 37);
            lblHasilPerbandingan.TabIndex = 72;
            lblHasilPerbandingan.Text = "Hasil Perbandingan :";
            lblHasilPerbandingan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBandingHarga
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1474, 829);
            Controls.Add(lblHasilPerbandingan);
            Controls.Add(sidebar);
            Controls.Add(pnNavbar);
            Controls.Add(clbKategori);
            Controls.Add(clbAplikasi);
            Controls.Add(lblAplikasiBanding);
            Controls.Add(dgvBandingHarga);
            Controls.Add(btnCancelBanding);
            Controls.Add(btnBandingkan);
            Controls.Add(lblBandingHarga);
            Controls.Add(txtKuantitas);
            Controls.Add(lblKg);
            Controls.Add(lblBeratBanding);
            Controls.Add(lblKategoriBanding);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "FormBandingHarga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBandingHarga";
            Load += FormBandingHarga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBandingHarga).EndInit();
            sidebar.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            pnEntri.ResumeLayout(false);
            pnTrack.ResumeLayout(false);
            pnBandingHarga.ResumeLayout(false);
            pnPanduan.ResumeLayout(false);
            pnAkun.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            pnNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbNavbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelBanding;
        private Button btnBandingkan;
        private Label lblBandingHarga;
        private TextBox txtKuantitas;
        private Label lblKg;
        private Label lblBeratBanding;
        private Label lblKategoriBanding;
        private Label label1;
        private DataGridView dgvBandingHarga;
        private Label lblAplikasiBanding;
        private CheckedListBox clbAplikasi;
        private CheckedListBox clbKategori;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel sidebar;
        private Panel pnDashboard;
        private Button btnNavbarDashboard;
        private Panel pnEntri;
        private Button btnNavbarEntri;
        private Panel pnTrack;
        private Button btnNavbarTrack;
        private Panel pnBandingHarga;
        private Button btnNavbarBandingHarga;
        private Panel pnPanduan;
        private Button btnNavbarPanduan;
        private Panel pnAkun;
        private Button btnNavbarAkun;
        private Panel pnLogout;
        private Button btnNavbarLogout;
        private Panel pnNavbar;
        private PictureBox pbNavbar;
        private Label lblHasilPerbandingan;
    }
}