namespace WasteNoMoreUI
{
    partial class FormLogin
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
            btnLogin = new Button();
            lblJudul = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSignIn = new Label();
            btnRegister = new Button();
            panelLogin = new Panel();
            lblLogin = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(321, 150);
            btnCancel.Margin = new Padding(1, 1, 1, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 22);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(432, 150);
            btnLogin.Margin = new Padding(1, 1, 1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(80, 22);
            btnLogin.TabIndex = 38;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(396, 35);
            lblJudul.Margin = new Padding(1, 0, 1, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(44, 19);
            lblJudul.TabIndex = 37;
            lblJudul.Text = "Login";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(376, 74);
            txtUsername.Margin = new Padding(1, 1, 1, 1);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(164, 23);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(376, 106);
            txtPassword.Margin = new Padding(1, 1, 1, 1);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 35;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(299, 107);
            lblPassword.Margin = new Padding(1, 0, 1, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 34;
            lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(294, 74);
            lblUsername.Margin = new Padding(1, 0, 1, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(66, 15);
            lblUsername.TabIndex = 33;
            lblUsername.Text = "Username :";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.ForeColor = Color.White;
            lblSignIn.Location = new Point(8, 190);
            lblSignIn.Margin = new Padding(1, 0, 1, 0);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(259, 15);
            lblSignIn.TabIndex = 40;
            lblSignIn.Text = "Belum memiliki akun? Silahkan buat akun anda!";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(7, 99, 102);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(93, 214);
            btnRegister.Margin = new Padding(1, 1, 1, 1);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(80, 22);
            btnRegister.TabIndex = 41;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(7, 99, 102);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Controls.Add(lblSignIn);
            panelLogin.Controls.Add(btnRegister);
            panelLogin.Location = new Point(0, 0);
            panelLogin.Margin = new Padding(2, 2, 2, 2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(280, 270);
            panelLogin.TabIndex = 42;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(51, 77);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(168, 25);
            lblLogin.TabIndex = 47;
            lblLogin.Text = "WASTE NO MORE";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(560, 270);
            Controls.Add(panelLogin);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(lblJudul);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Margin = new Padding(1, 1, 1, 1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnLogin;
        private Label lblJudul;
        public TextBox txtUsername;
        public TextBox txtPassword;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblSignIn;
        private Button btnRegister;
        private Panel panelLogin;
        private Label lblLogin;
    }
}