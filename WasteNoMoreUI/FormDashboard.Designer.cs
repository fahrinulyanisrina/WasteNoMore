﻿namespace WasteNoMoreUI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            lblJudul = new Label();
            pbEntri = new PictureBox();
            pbTrack = new PictureBox();
            pbBanding = new PictureBox();
            label1 = new Label();
            lblEntriSampah = new Label();
            lblTrack = new Label();
            lblBanding = new Label();
            lblEntri = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pbEntri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBanding).BeginInit();
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
            lblJudul.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(326, 42);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(178, 41);
            lblJudul.TabIndex = 51;
            lblJudul.Text = "Dashboard";
            // 
            // pbEntri
            // 
            pbEntri.Image = (Image)resources.GetObject("pbEntri.Image");
            pbEntri.Location = new Point(155, 159);
            pbEntri.Margin = new Padding(4, 2, 4, 2);
            pbEntri.Name = "pbEntri";
            pbEntri.Size = new Size(127, 106);
            pbEntri.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEntri.TabIndex = 52;
            pbEntri.TabStop = false;
            pbEntri.Click += pictureBox1_Click;
            // 
            // pbTrack
            // 
            pbTrack.Image = (Image)resources.GetObject("pbTrack.Image");
            pbTrack.Location = new Point(347, 159);
            pbTrack.Margin = new Padding(4, 2, 4, 2);
            pbTrack.Name = "pbTrack";
            pbTrack.Size = new Size(116, 106);
            pbTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTrack.TabIndex = 54;
            pbTrack.TabStop = false;
            pbTrack.Click += pbTrack_Click;
            // 
            // pbBanding
            // 
            pbBanding.Image = (Image)resources.GetObject("pbBanding.Image");
            pbBanding.Location = new Point(535, 159);
            pbBanding.Margin = new Padding(4, 2, 4, 2);
            pbBanding.Name = "pbBanding";
            pbBanding.Size = new Size(126, 106);
            pbBanding.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBanding.TabIndex = 56;
            pbBanding.TabStop = false;
            pbBanding.Click += pbBanding_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 20);
            label1.TabIndex = 58;
            label1.Text = "Selamat Datang di WasteNoMOre!";
            // 
            // lblEntriSampah
            // 
            lblEntriSampah.AutoSize = true;
            lblEntriSampah.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntriSampah.Location = new Point(141, 286);
            lblEntriSampah.Margin = new Padding(4, 0, 4, 0);
            lblEntriSampah.Name = "lblEntriSampah";
            lblEntriSampah.Size = new Size(0, 20);
            lblEntriSampah.TabIndex = 59;
            // 
            // lblTrack
            // 
            lblTrack.AutoSize = true;
            lblTrack.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrack.Location = new Point(333, 282);
            lblTrack.Margin = new Padding(4, 0, 4, 0);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(126, 20);
            lblTrack.TabIndex = 61;
            lblTrack.Text = "Tracking Sampah";
            // 
            // lblBanding
            // 
            lblBanding.AutoSize = true;
            lblBanding.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBanding.Location = new Point(546, 282);
            lblBanding.Margin = new Padding(4, 0, 4, 0);
            lblBanding.Name = "lblBanding";
            lblBanding.Size = new Size(112, 20);
            lblBanding.TabIndex = 62;
            lblBanding.Text = "Banding Harga";
            // 
            // lblEntri
            // 
            lblEntri.AutoSize = true;
            lblEntri.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntri.Location = new Point(162, 281);
            lblEntri.Margin = new Padding(4, 0, 4, 0);
            lblEntri.Name = "lblEntri";
            lblEntri.Size = new Size(100, 20);
            lblEntri.TabIndex = 63;
            lblEntri.Text = "Entri Sampah";
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
            sidebar.Location = new Point(0, 31);
            sidebar.Margin = new Padding(2, 1, 2, 1);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 9, 0, 0);
            sidebar.Size = new Size(54, 320);
            sidebar.TabIndex = 72;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(btnNavbarDashboard);
            pnDashboard.Location = new Point(2, 10);
            pnDashboard.Margin = new Padding(2, 1, 2, 1);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(214, 33);
            pnDashboard.TabIndex = 69;
            // 
            // btnNavbarDashboard
            // 
            btnNavbarDashboard.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarDashboard.FlatStyle = FlatStyle.Flat;
            btnNavbarDashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarDashboard.Image = (Image)resources.GetObject("btnNavbarDashboard.Image");
            btnNavbarDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarDashboard.Location = new Point(2, -1);
            btnNavbarDashboard.Margin = new Padding(2, 1, 2, 1);
            btnNavbarDashboard.Name = "btnNavbarDashboard";
            btnNavbarDashboard.Padding = new Padding(13, 0, 0, 0);
            btnNavbarDashboard.Size = new Size(211, 33);
            btnNavbarDashboard.TabIndex = 70;
            btnNavbarDashboard.Text = "         Dashboard";
            btnNavbarDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarDashboard.UseVisualStyleBackColor = false;
            // 
            // pnEntri
            // 
            pnEntri.Controls.Add(btnNavbarEntri);
            pnEntri.Location = new Point(2, 45);
            pnEntri.Margin = new Padding(2, 1, 2, 1);
            pnEntri.Name = "pnEntri";
            pnEntri.Size = new Size(214, 33);
            pnEntri.TabIndex = 71;
            // 
            // btnNavbarEntri
            // 
            btnNavbarEntri.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarEntri.FlatStyle = FlatStyle.Flat;
            btnNavbarEntri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarEntri.Image = (Image)resources.GetObject("btnNavbarEntri.Image");
            btnNavbarEntri.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarEntri.Location = new Point(2, -1);
            btnNavbarEntri.Margin = new Padding(2, 1, 2, 1);
            btnNavbarEntri.Name = "btnNavbarEntri";
            btnNavbarEntri.Padding = new Padding(13, 0, 0, 0);
            btnNavbarEntri.Size = new Size(211, 33);
            btnNavbarEntri.TabIndex = 70;
            btnNavbarEntri.Text = "         Entri Sampah";
            btnNavbarEntri.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarEntri.UseVisualStyleBackColor = false;
            btnNavbarEntri.Click += btnNavbarEntri_Click;
            // 
            // pnTrack
            // 
            pnTrack.Controls.Add(btnNavbarTrack);
            pnTrack.Location = new Point(2, 80);
            pnTrack.Margin = new Padding(2, 1, 2, 1);
            pnTrack.Name = "pnTrack";
            pnTrack.Size = new Size(214, 33);
            pnTrack.TabIndex = 71;
            // 
            // btnNavbarTrack
            // 
            btnNavbarTrack.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarTrack.FlatStyle = FlatStyle.Flat;
            btnNavbarTrack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarTrack.Image = (Image)resources.GetObject("btnNavbarTrack.Image");
            btnNavbarTrack.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarTrack.Location = new Point(2, -1);
            btnNavbarTrack.Margin = new Padding(2, 1, 2, 1);
            btnNavbarTrack.Name = "btnNavbarTrack";
            btnNavbarTrack.Padding = new Padding(13, 0, 0, 0);
            btnNavbarTrack.Size = new Size(211, 33);
            btnNavbarTrack.TabIndex = 70;
            btnNavbarTrack.Text = "         Tracking Sampah";
            btnNavbarTrack.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarTrack.UseVisualStyleBackColor = false;
            btnNavbarTrack.Click += btnNavbarTrack_Click;
            // 
            // pnBandingHarga
            // 
            pnBandingHarga.Controls.Add(btnNavbarBandingHarga);
            pnBandingHarga.Location = new Point(2, 115);
            pnBandingHarga.Margin = new Padding(2, 1, 2, 1);
            pnBandingHarga.Name = "pnBandingHarga";
            pnBandingHarga.Size = new Size(214, 33);
            pnBandingHarga.TabIndex = 70;
            // 
            // btnNavbarBandingHarga
            // 
            btnNavbarBandingHarga.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarBandingHarga.FlatStyle = FlatStyle.Flat;
            btnNavbarBandingHarga.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarBandingHarga.Image = (Image)resources.GetObject("btnNavbarBandingHarga.Image");
            btnNavbarBandingHarga.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarBandingHarga.Location = new Point(2, -1);
            btnNavbarBandingHarga.Margin = new Padding(2, 1, 2, 1);
            btnNavbarBandingHarga.Name = "btnNavbarBandingHarga";
            btnNavbarBandingHarga.Padding = new Padding(13, 0, 0, 0);
            btnNavbarBandingHarga.Size = new Size(211, 33);
            btnNavbarBandingHarga.TabIndex = 70;
            btnNavbarBandingHarga.Text = "         Banding Harga";
            btnNavbarBandingHarga.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarBandingHarga.UseVisualStyleBackColor = false;
            btnNavbarBandingHarga.Click += btnNavbarBandingHarga_Click;
            // 
            // pnPanduan
            // 
            pnPanduan.Controls.Add(btnNavbarPanduan);
            pnPanduan.Location = new Point(2, 150);
            pnPanduan.Margin = new Padding(2, 1, 2, 1);
            pnPanduan.Name = "pnPanduan";
            pnPanduan.Size = new Size(214, 33);
            pnPanduan.TabIndex = 72;
            // 
            // btnNavbarPanduan
            // 
            btnNavbarPanduan.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarPanduan.FlatStyle = FlatStyle.Flat;
            btnNavbarPanduan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarPanduan.Image = (Image)resources.GetObject("btnNavbarPanduan.Image");
            btnNavbarPanduan.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarPanduan.Location = new Point(2, -1);
            btnNavbarPanduan.Margin = new Padding(2, 1, 2, 1);
            btnNavbarPanduan.Name = "btnNavbarPanduan";
            btnNavbarPanduan.Padding = new Padding(13, 0, 0, 0);
            btnNavbarPanduan.Size = new Size(211, 33);
            btnNavbarPanduan.TabIndex = 70;
            btnNavbarPanduan.Text = "         Panduan";
            btnNavbarPanduan.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarPanduan.UseVisualStyleBackColor = false;
            // 
            // pnAkun
            // 
            pnAkun.Controls.Add(btnNavbarAkun);
            pnAkun.Location = new Point(2, 185);
            pnAkun.Margin = new Padding(2, 1, 2, 1);
            pnAkun.Name = "pnAkun";
            pnAkun.Size = new Size(214, 33);
            pnAkun.TabIndex = 73;
            // 
            // btnNavbarAkun
            // 
            btnNavbarAkun.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarAkun.FlatStyle = FlatStyle.Flat;
            btnNavbarAkun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarAkun.Image = (Image)resources.GetObject("btnNavbarAkun.Image");
            btnNavbarAkun.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarAkun.Location = new Point(2, -1);
            btnNavbarAkun.Margin = new Padding(2, 1, 2, 1);
            btnNavbarAkun.Name = "btnNavbarAkun";
            btnNavbarAkun.Padding = new Padding(13, 0, 0, 0);
            btnNavbarAkun.Size = new Size(211, 33);
            btnNavbarAkun.TabIndex = 70;
            btnNavbarAkun.Text = "         Akun";
            btnNavbarAkun.TextAlign = ContentAlignment.MiddleLeft;
            btnNavbarAkun.UseVisualStyleBackColor = false;
            btnNavbarAkun.Click += btnNavbarAkun_Click;
            // 
            // pnLogout
            // 
            pnLogout.Controls.Add(btnNavbarLogout);
            pnLogout.Location = new Point(2, 220);
            pnLogout.Margin = new Padding(2, 1, 2, 1);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(214, 33);
            pnLogout.TabIndex = 74;
            // 
            // btnNavbarLogout
            // 
            btnNavbarLogout.BackColor = SystemColors.GradientActiveCaption;
            btnNavbarLogout.FlatStyle = FlatStyle.Flat;
            btnNavbarLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavbarLogout.Image = (Image)resources.GetObject("btnNavbarLogout.Image");
            btnNavbarLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavbarLogout.Location = new Point(2, -1);
            btnNavbarLogout.Margin = new Padding(2, 1, 2, 1);
            btnNavbarLogout.Name = "btnNavbarLogout";
            btnNavbarLogout.Padding = new Padding(13, 0, 0, 0);
            btnNavbarLogout.Size = new Size(211, 33);
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
            pnNavbar.Margin = new Padding(2, 1, 2, 1);
            pnNavbar.Name = "pnNavbar";
            pnNavbar.Size = new Size(738, 31);
            pnNavbar.TabIndex = 71;
            // 
            // pbNavbar
            // 
            pbNavbar.Image = (Image)resources.GetObject("pbNavbar.Image");
            pbNavbar.Location = new Point(16, 6);
            pbNavbar.Margin = new Padding(2, 1, 2, 1);
            pbNavbar.Name = "pbNavbar";
            pbNavbar.Size = new Size(31, 21);
            pbNavbar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNavbar.TabIndex = 0;
            pbNavbar.TabStop = false;
            pbNavbar.Click += pbNavbar_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(738, 351);
            Controls.Add(sidebar);
            Controls.Add(pnNavbar);
            Controls.Add(lblEntri);
            Controls.Add(lblBanding);
            Controls.Add(lblTrack);
            Controls.Add(lblEntriSampah);
            Controls.Add(label1);
            Controls.Add(pbBanding);
            Controls.Add(pbTrack);
            Controls.Add(pbEntri);
            Controls.Add(lblJudul);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            FormClosed += FormDashboard_FormClosed;
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pbEntri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBanding).EndInit();
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
        private PictureBox pbEntri;
        private PictureBox pbTrack;
        private PictureBox pbBanding;
        private Label label1;
        private Label lblEntriSampah;
        private Label lblTrack;
        private Label lblBanding;
        private Label lblEntri;
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