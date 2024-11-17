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
            tbOtp = new TextBox();
            lblOtp = new Label();
            btnOtp = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(591, 660);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
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
            btnDaftar.Location = new Point(804, 660);
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
            lblJudul.Location = new Point(693, 65);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(223, 37);
            lblJudul.TabIndex = 37;
            lblJudul.Text = "Buat Akun Anda!";
            lblJudul.Click += lblJudul_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(693, 210);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 39);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(693, 277);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 39);
            txtPassword.TabIndex = 35;
            // 
            // lblPasswordd
            // 
            lblPasswordd.AutoSize = true;
            lblPasswordd.Location = new Point(550, 279);
            lblPasswordd.Name = "lblPasswordd";
            lblPasswordd.Size = new Size(123, 32);
            lblPasswordd.TabIndex = 34;
            lblPasswordd.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(540, 210);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(133, 32);
            lblUsername.TabIndex = 33;
            lblUsername.Text = "Username :";
            // 
            // txtNamaPengguna
            // 
            txtNamaPengguna.Location = new Point(693, 140);
            txtNamaPengguna.Name = "txtNamaPengguna";
            txtNamaPengguna.Size = new Size(300, 39);
            txtNamaPengguna.TabIndex = 43;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(693, 342);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 39);
            txtEmail.TabIndex = 42;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(590, 349);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 32);
            lblEmail.TabIndex = 41;
            lblEmail.Text = "Email :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(584, 142);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(89, 32);
            lblNamaPengguna.TabIndex = 40;
            lblNamaPengguna.Text = "Nama :";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(7, 99, 102);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(174, 442);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 45;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(56, 387);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(404, 32);
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
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 750);
            panel1.TabIndex = 46;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.White;
            lblRegister.Location = new Point(95, 164);
            lblRegister.Margin = new Padding(4, 0, 4, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(338, 51);
            lblRegister.TabIndex = 46;
            lblRegister.Text = "WASTE NO MORE";
            // 
            // tbOtp
            // 
            tbOtp.Location = new Point(684, 523);
            tbOtp.Name = "tbOtp";
            tbOtp.Size = new Size(300, 39);
            tbOtp.TabIndex = 48;
            // 
            // lblOtp
            // 
            lblOtp.AutoSize = true;
            lblOtp.Location = new Point(539, 524);
            lblOtp.Name = "lblOtp";
            lblOtp.Size = new Size(130, 32);
            lblOtp.TabIndex = 47;
            lblOtp.Text = "Kode OTP :";
            // 
            // btnOtp
            // 
            btnOtp.BackColor = Color.SteelBlue;
            btnOtp.FlatStyle = FlatStyle.Flat;
            btnOtp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOtp.ForeColor = SystemColors.ButtonHighlight;
            btnOtp.Location = new Point(670, 442);
            btnOtp.Name = "btnOtp";
            btnOtp.Size = new Size(246, 46);
            btnOtp.TabIndex = 49;
            btnOtp.Text = "Kirim Kode OTP";
            btnOtp.UseVisualStyleBackColor = false;
            btnOtp.Click += btnOtp_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1040, 745);
            Controls.Add(btnOtp);
            Controls.Add(tbOtp);
            Controls.Add(lblOtp);
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
        private TextBox tbOtp;
        private Label lblOtp;
        private Button btnOtp;
    }
}