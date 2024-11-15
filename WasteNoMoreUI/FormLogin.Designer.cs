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
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(297, 295);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 36);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(434, 295);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 36);
            btnLogin.TabIndex = 38;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(395, 107);
            lblJudul.Margin = new Padding(2, 0, 2, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(66, 30);
            lblJudul.TabIndex = 37;
            lblJudul.Text = "Login";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(315, 166);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(326, 31);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(315, 218);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(326, 31);
            txtPassword.TabIndex = 35;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(205, 220);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(96, 25);
            lblPassword.TabIndex = 34;
            lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(198, 166);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 25);
            lblUsername.TabIndex = 33;
            lblUsername.Text = "Username :";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Location = new Point(236, 381);
            lblSignIn.Margin = new Padding(2, 0, 2, 0);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(386, 25);
            lblSignIn.TabIndex = 40;
            lblSignIn.Text = "Belum memiliki akun? Silahkan buat akun anda!";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.HotTrack;
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(358, 421);
            btnRegister.Margin = new Padding(2, 2, 2, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(115, 36);
            btnRegister.TabIndex = 41;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(857, 553);
            Controls.Add(btnRegister);
            Controls.Add(lblSignIn);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(lblJudul);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnLogin;
        private Label lblJudul;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblSignIn;
        private Button btnRegister;
    }
}