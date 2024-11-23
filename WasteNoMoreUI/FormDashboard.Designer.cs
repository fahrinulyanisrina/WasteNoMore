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
            lblJudul = new Label();
            pbEntri = new PictureBox();
            pbTrack = new PictureBox();
            pbBanding = new PictureBox();
            btnLogout = new Button();
            label1 = new Label();
            lblEntriSampah = new Label();
            lblTrack = new Label();
            lblBanding = new Label();
            lblEntri = new Label();
            pbUser = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbEntri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBanding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(320, 43);
            lblJudul.Margin = new Padding(2, 0, 2, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(178, 41);
            lblJudul.TabIndex = 51;
            lblJudul.Text = "Dashboard";
            // 
            // pbEntri
            // 
            pbEntri.Image = (Image)resources.GetObject("pbEntri.Image");
            pbEntri.Location = new Point(192, 181);
            pbEntri.Margin = new Padding(2, 1, 2, 1);
            pbEntri.Name = "pbEntri";
            pbEntri.Size = new Size(116, 100);
            pbEntri.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEntri.TabIndex = 52;
            pbEntri.TabStop = false;
            pbEntri.Click += pictureBox1_Click;
            // 
            // pbTrack
            // 
            pbTrack.Image = (Image)resources.GetObject("pbTrack.Image");
            pbTrack.Location = new Point(361, 181);
            pbTrack.Margin = new Padding(2, 1, 2, 1);
            pbTrack.Name = "pbTrack";
            pbTrack.Size = new Size(110, 100);
            pbTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTrack.TabIndex = 54;
            pbTrack.TabStop = false;
            pbTrack.Click += pbTrack_Click;
            // 
            // pbBanding
            // 
            pbBanding.Image = (Image)resources.GetObject("pbBanding.Image");
            pbBanding.Location = new Point(529, 181);
            pbBanding.Margin = new Padding(2, 1, 2, 1);
            pbBanding.Name = "pbBanding";
            pbBanding.Size = new Size(115, 100);
            pbBanding.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBanding.TabIndex = 56;
            pbBanding.TabStop = false;
            pbBanding.Click += pbBanding_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(732, 367);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(81, 25);
            btnLogout.TabIndex = 57;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 89);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 20);
            label1.TabIndex = 58;
            label1.Text = "Selamat Datang di WasteNoMOre!";
            // 
            // lblEntriSampah
            // 
            lblEntriSampah.AutoSize = true;
            lblEntriSampah.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntriSampah.Location = new Point(197, 288);
            lblEntriSampah.Margin = new Padding(2, 0, 2, 0);
            lblEntriSampah.Name = "lblEntriSampah";
            lblEntriSampah.Size = new Size(0, 20);
            lblEntriSampah.TabIndex = 59;
            // 
            // lblTrack
            // 
            lblTrack.AutoSize = true;
            lblTrack.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrack.Location = new Point(351, 286);
            lblTrack.Margin = new Padding(2, 0, 2, 0);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(126, 20);
            lblTrack.TabIndex = 61;
            lblTrack.Text = "Tracking Sampah";
            // 
            // lblBanding
            // 
            lblBanding.AutoSize = true;
            lblBanding.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBanding.Location = new Point(529, 285);
            lblBanding.Margin = new Padding(2, 0, 2, 0);
            lblBanding.Name = "lblBanding";
            lblBanding.Size = new Size(112, 20);
            lblBanding.TabIndex = 62;
            lblBanding.Text = "Banding Harga";
            // 
            // lblEntri
            // 
            lblEntri.AutoSize = true;
            lblEntri.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntri.Location = new Point(200, 288);
            lblEntri.Margin = new Padding(2, 0, 2, 0);
            lblEntri.Name = "lblEntri";
            lblEntri.Size = new Size(100, 20);
            lblEntri.TabIndex = 63;
            lblEntri.Text = "Entri Sampah";
            // 
            // pbUser
            // 
            pbUser.Image = (Image)resources.GetObject("pbUser.Image");
            pbUser.Location = new Point(13, 15);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(72, 69);
            pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUser.TabIndex = 64;
            pbUser.TabStop = false;
            pbUser.Click += pbUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 100);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 65;
            label2.Text = "User";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(738, 351);
            Controls.Add(label2);
            Controls.Add(pbUser);
            Controls.Add(lblEntri);
            Controls.Add(lblBanding);
            Controls.Add(lblTrack);
            Controls.Add(lblEntriSampah);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(pbBanding);
            Controls.Add(pbTrack);
            Controls.Add(pbEntri);
            Controls.Add(lblJudul);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pbEntri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBanding).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblJudul;
        private PictureBox pbEntri;
        private PictureBox pbTrack;
        private PictureBox pbBanding;
        private Button btnLogout;
        private Label label1;
        private Label lblEntriSampah;
        private Label lblTrack;
        private Label lblBanding;
        private Label lblEntri;
        private PictureBox pbUser;
        private Label label2;
    }
}