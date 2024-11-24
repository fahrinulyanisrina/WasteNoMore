namespace WasteNoMoreUI
{
    partial class FormEntriSampah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntriSampah));
            lblJudul = new Label();
            cmbKategori = new ComboBox();
            txtBerat = new TextBox();
            lblKg = new Label();
            lblBerat = new Label();
            lblKategori = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
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
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);

            lblJudul.Location = new Point(519, 199);

            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(250, 19);
            lblJudul.TabIndex = 26;
            lblJudul.Text = "Masukkan Data Sampah Terbaru Anda!";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;

            cmbKategori.Location = new Point(680, 312);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(306, 40);

            cmbKategori.TabIndex = 24;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // txtBerat
            // 

            txtBerat.Location = new Point(680, 385);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(245, 39);

            txtBerat.TabIndex = 23;
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;

            lblKg.Location = new Point(946, 388);

            lblKg.Name = "lblKg";
            lblKg.Size = new Size(20, 15);
            lblKg.TabIndex = 22;
            lblKg.Text = "kg";
            // 
            // lblBerat
            // 
            lblBerat.AutoSize = true;

            lblBerat.Location = new Point(499, 385);

            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(86, 15);
            lblBerat.TabIndex = 21;
            lblBerat.Text = "Berat Sampah :";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;

            lblKategori.Location = new Point(558, 312);

            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(57, 15);
            lblKategori.TabIndex = 20;
            lblKategori.Text = "Kategori :";
            // 
            // label1
            // 
            label1.AutoSize = true;

            label1.Location = new Point(535, 199);

            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Brown;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;

            btnCancel.Location = new Point(589, 494);

            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 22);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;

            btnAdd.Location = new Point(794, 494);

            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 22);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
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
            // FormEntriSampah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;

            ClientSize = new Size(1474, 829);
            Controls.Add(sidebar);
            Controls.Add(pnNavbar);

            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblJudul);
            Controls.Add(cmbKategori);
            Controls.Add(txtBerat);
            Controls.Add(lblKg);
            Controls.Add(lblBerat);
            Controls.Add(lblKategori);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormEntriSampah";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEntriSampah";
            FormClosed += FormEntriSampah_FormClosed;
            Load += FormEntriSampah_Load;
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
        private Label lblJudul;
        private ComboBox cmbKategori;
        private TextBox txtBerat;
        private Label lblKg;
        private Label lblBerat;
        private Label lblKategori;
        private Label label1;
        private Button btnCancel;
        private Button btnAdd;
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
    }
}