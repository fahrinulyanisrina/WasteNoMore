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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblSignIn = new Label();
            panelLogin = new Panel();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            lblJudul = new Label();
            llRegister = new LinkLabel();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(888, 438);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(408, 46);
            btnLogin.TabIndex = 38;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(888, 275);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(408, 39);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(888, 341);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(408, 39);
            txtPassword.TabIndex = 35;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(745, 344);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 32);
            lblPassword.TabIndex = 34;
            lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(736, 275);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(133, 32);
            lblUsername.TabIndex = 33;
            lblUsername.Text = "Username :";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = Color.Black;
            lblSignIn.Location = new Point(820, 677);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(308, 40);
            lblSignIn.TabIndex = 40;
            lblSignIn.Text = "Belum memiliki akun?";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = SystemColors.GradientActiveCaption;
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Dock = DockStyle.Left;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Margin = new Padding(4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(578, 829);
            panelLogin.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(126, 531);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(338, 51);
            lblLogin.TabIndex = 47;
            lblLogin.Text = "WASTE NO MORE";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblJudul.Location = new Point(855, 108);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(393, 51);
            lblJudul.TabIndex = 43;
            lblJudul.Text = "Login ke Akun Anda!";
            // 
            // llRegister
            // 
            llRegister.AutoSize = true;
            llRegister.DisabledLinkColor = Color.FromArgb(37, 74, 116);
            llRegister.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llRegister.LinkColor = SystemColors.Highlight;
            llRegister.Location = new Point(1124, 677);
            llRegister.Name = "llRegister";
            llRegister.Size = new Size(124, 40);
            llRegister.TabIndex = 44;
            llRegister.TabStop = true;
            llRegister.Text = "Sign-Up";
            llRegister.LinkClicked += llRegister_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1474, 829);
            Controls.Add(llRegister);
            Controls.Add(lblJudul);
            Controls.Add(panelLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(lblSignIn);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblSignIn;
        private Panel panelLogin;
        private Label lblLogin;
        private Label lblJudul;
        private PictureBox pictureBox1;
        private LinkLabel llRegister;
    }
}