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
            btnLogin = new Button();
            lblLogin = new Label();
            panel1 = new Panel();
            lblRegister = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(454, 345);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 36);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.SteelBlue;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = SystemColors.ButtonHighlight;
            btnDaftar.Location = new Point(618, 345);
            btnDaftar.Margin = new Padding(2);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(115, 36);
            btnDaftar.TabIndex = 38;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(533, 51);
            lblJudul.Margin = new Padding(2, 0, 2, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(174, 30);
            lblJudul.TabIndex = 37;
            lblJudul.Text = "Buat Akun Anda!";
            lblJudul.Click += lblJudul_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(533, 212);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(232, 31);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(533, 264);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 31);
            txtPassword.TabIndex = 35;
            // 
            // lblPasswordd
            // 
            lblPasswordd.AutoSize = true;
            lblPasswordd.Location = new Point(423, 266);
            lblPasswordd.Margin = new Padding(2, 0, 2, 0);
            lblPasswordd.Name = "lblPasswordd";
            lblPasswordd.Size = new Size(96, 25);
            lblPasswordd.TabIndex = 34;
            lblPasswordd.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(415, 212);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 25);
            lblUsername.TabIndex = 33;
            lblUsername.Text = "Username :";
            // 
            // txtNamaPengguna
            // 
            txtNamaPengguna.Location = new Point(533, 109);
            txtNamaPengguna.Margin = new Padding(2);
            txtNamaPengguna.Name = "txtNamaPengguna";
            txtNamaPengguna.Size = new Size(232, 31);
            txtNamaPengguna.TabIndex = 43;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(533, 160);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 31);
            txtEmail.TabIndex = 42;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(454, 166);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 25);
            lblEmail.TabIndex = 41;
            lblEmail.Text = "Email :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(449, 111);
            lblNamaPengguna.Margin = new Padding(2, 0, 2, 0);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(68, 25);
            lblNamaPengguna.TabIndex = 40;
            lblNamaPengguna.Text = "Nama :";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(7, 99, 102);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(134, 345);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 36);
            btnLogin.TabIndex = 45;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(43, 302);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(298, 25);
            lblLogin.TabIndex = 44;
            lblLogin.Text = "Sudah memiliki akun? Silakan Login!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(lblRegister);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 450);
            panel1.TabIndex = 46;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.White;
            lblRegister.Location = new Point(73, 128);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(251, 38);
            lblRegister.TabIndex = 46;
            lblRegister.Text = "WASTE NO MORE";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
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
            Margin = new Padding(2);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += FormRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btnLogin;
        private Label lblLogin;
        private Panel panel1;
        private Label lblRegister;
    }
}