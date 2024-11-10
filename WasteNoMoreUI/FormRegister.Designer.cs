namespace WasteNoMoreUI
{
    partial class FormRegister
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
            btnCancel = new Button();
            btnDaftar = new Button();
            lblJudul = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPasswordd = new Label();
            lblUsername = new Label();
            txtNamaPengguna = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblNamaPengguna = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(368, 519);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = SystemColors.HotTrack;
            btnDaftar.ForeColor = SystemColors.ButtonHighlight;
            btnDaftar.Location = new Point(603, 519);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(150, 46);
            btnDaftar.TabIndex = 38;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(443, 95);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(223, 37);
            lblJudul.TabIndex = 37;
            lblJudul.Text = "Buat Akun Anda!";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(368, 334);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(423, 39);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(368, 400);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(423, 39);
            txtPassword.TabIndex = 35;
            // 
            // lblPasswordd
            // 
            lblPasswordd.AutoSize = true;
            lblPasswordd.Location = new Point(225, 403);
            lblPasswordd.Name = "lblPasswordd";
            lblPasswordd.Size = new Size(123, 32);
            lblPasswordd.TabIndex = 34;
            lblPasswordd.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(215, 334);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(133, 32);
            lblUsername.TabIndex = 33;
            lblUsername.Text = "Username :";
            // 
            // txtNamaPengguna
            // 
            txtNamaPengguna.Location = new Point(368, 201);
            txtNamaPengguna.Name = "txtNamaPengguna";
            txtNamaPengguna.Size = new Size(423, 39);
            txtNamaPengguna.TabIndex = 43;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(368, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(423, 39);
            txtEmail.TabIndex = 42;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(265, 274);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 32);
            lblEmail.TabIndex = 41;
            lblEmail.Text = "Email :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(259, 204);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(89, 32);
            lblNamaPengguna.TabIndex = 40;
            lblNamaPengguna.Text = "Nama :";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1098, 687);
            Controls.Add(txtNamaPengguna);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblNamaPengguna);
            Controls.Add(btnCancel);
            Controls.Add(btnDaftar);
            Controls.Add(lblJudul);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPasswordd);
            Controls.Add(lblUsername);
            Name = "FormRegister";
            Text = "FormRegister";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnDaftar;
        private Label lblJudul;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPasswordd;
        private Label lblUsername;
        private TextBox txtNamaPengguna;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblNamaPengguna;
    }
}