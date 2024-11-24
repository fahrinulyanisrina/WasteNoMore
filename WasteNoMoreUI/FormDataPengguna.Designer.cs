namespace WasteNoMoreUI
{
    partial class FormDataPengguna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataPengguna));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnChange = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblNama = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            tbNama = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
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
            sidebarTransition = new System.Windows.Forms.Timer(components);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 148);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 51);
            label1.TabIndex = 0;
            label1.Text = "Data Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 261);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 367);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 468);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(811, 562);
            btnChange.Margin = new Padding(6);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(308, 81);
            btnChange.TabIndex = 5;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 261);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(19, 32);
            label6.TabIndex = 6;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(499, 367);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 32);
            label7.TabIndex = 7;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(499, 468);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(19, 32);
            label8.TabIndex = 8;
            label8.Text = ":";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(553, 261);
            lblNama.Margin = new Padding(6, 0, 6, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(91, 32);
            lblNama.TabIndex = 10;
            lblNama.Text = "label10";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(553, 367);
            lblUsername.Margin = new Padding(6, 0, 6, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 32);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "label11";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(553, 468);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(91, 32);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "label12";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(811, 244);
            tbNama.Margin = new Padding(6);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(314, 39);
            tbNama.TabIndex = 14;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(811, 451);
            tbEmail.Margin = new Padding(6);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(314, 39);
            tbEmail.TabIndex = 16;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(811, 350);
            tbUsername.Margin = new Padding(6);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(314, 39);
            tbUsername.TabIndex = 17;
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
            sidebar.TabIndex = 72;
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
            pnNavbar.TabIndex = 71;
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
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // FormDataPengguna
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1474, 829);
            Controls.Add(sidebar);
            Controls.Add(pnNavbar);
            Controls.Add(tbUsername);
            Controls.Add(tbEmail);
            Controls.Add(tbNama);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblNama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnChange);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "FormDataPengguna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDataPengguna";

            FormClosed += FormDataPengguna_FormClosed;

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

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChange;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblNama;
        private Label lblUsername;
        private Label lblEmail;
        private TextBox tbNama;
        private TextBox tbEmail;
        private TextBox tbUsername;
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
        private System.Windows.Forms.Timer sidebarTransition;
    }
}