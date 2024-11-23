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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            btnDaftar = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPasswordd = new Label();
            lblUsername = new Label();
            txtNamaPengguna = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblNamaPengguna = new Label();
            lblLogin = new Label();
            tbOtp = new TextBox();
            lblOtp = new Label();
            btnOtp = new Button();
            panelRegister = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            llLogin = new LinkLabel();
            label2 = new Label();
            panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.SteelBlue;
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = SystemColors.ButtonHighlight;
            btnDaftar.Location = new Point(872, 608);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(400, 46);
            btnDaftar.TabIndex = 38;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDaftar_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(872, 244);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 39);
            txtUsername.TabIndex = 36;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(872, 311);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 39);
            txtPassword.TabIndex = 35;
            // 
            // lblPasswordd
            // 
            lblPasswordd.AutoSize = true;
            lblPasswordd.Location = new Point(729, 313);
            lblPasswordd.Name = "lblPasswordd";
            lblPasswordd.Size = new Size(123, 32);
            lblPasswordd.TabIndex = 34;
            lblPasswordd.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(719, 244);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(133, 32);
            lblUsername.TabIndex = 33;
            lblUsername.Text = "Username :";
            // 
            // txtNamaPengguna
            // 
            txtNamaPengguna.Location = new Point(872, 174);
            txtNamaPengguna.Name = "txtNamaPengguna";
            txtNamaPengguna.Size = new Size(400, 39);
            txtNamaPengguna.TabIndex = 43;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(872, 376);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 39);
            txtEmail.TabIndex = 42;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(769, 383);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 32);
            lblEmail.TabIndex = 41;
            lblEmail.Text = "Email :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(763, 176);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(89, 32);
            lblNamaPengguna.TabIndex = 40;
            lblNamaPengguna.Text = "Nama :";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(824, 741);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(306, 40);
            lblLogin.TabIndex = 44;
            lblLogin.Text = "Sudah memiliki akun?";
            // 
            // tbOtp
            // 
            tbOtp.Location = new Point(872, 516);
            tbOtp.Name = "tbOtp";
            tbOtp.Size = new Size(400, 39);
            tbOtp.TabIndex = 48;
            // 
            // lblOtp
            // 
            lblOtp.AutoSize = true;
            lblOtp.Location = new Point(727, 517);
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
            btnOtp.Location = new Point(1026, 435);
            btnOtp.Name = "btnOtp";
            btnOtp.Size = new Size(246, 46);
            btnOtp.TabIndex = 49;
            btnOtp.Text = "Kirim Kode OTP";
            btnOtp.UseVisualStyleBackColor = false;
            btnOtp.Click += btnOtp_Click;
            // 
            // panelRegister
            // 
            panelRegister.BackColor = SystemColors.GradientActiveCaption;
            panelRegister.Controls.Add(pictureBox1);
            panelRegister.Controls.Add(label1);
            panelRegister.Dock = DockStyle.Left;
            panelRegister.Location = new Point(0, 0);
            panelRegister.Margin = new Padding(4);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(578, 829);
            panelRegister.TabIndex = 50;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 531);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(338, 51);
            label1.TabIndex = 47;
            label1.Text = "WASTE NO MORE";
            // 
            // llLogin
            // 
            llLogin.AutoSize = true;
            llLogin.DisabledLinkColor = Color.FromArgb(37, 74, 116);
            llLogin.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llLogin.LinkColor = SystemColors.Highlight;
            llLogin.Location = new Point(1127, 741);
            llLogin.Name = "llLogin";
            llLogin.Size = new Size(102, 40);
            llLogin.TabIndex = 51;
            llLogin.TabStop = true;
            llLogin.Text = "Log-In";
            llLogin.LinkClicked += llLogin_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(730, 49);
            label2.Name = "label2";
            label2.Size = new Size(577, 50);
            label2.TabIndex = 52;
            label2.Text = "Buat Akun WasteNoMore Anda!";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1474, 829);
            Controls.Add(label2);
            Controls.Add(llLogin);
            Controls.Add(panelRegister);
            Controls.Add(btnOtp);
            Controls.Add(lblLogin);
            Controls.Add(tbOtp);
            Controls.Add(lblOtp);
            Controls.Add(txtNamaPengguna);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblNamaPengguna);
            Controls.Add(btnDaftar);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPasswordd);
            Controls.Add(lblUsername);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += FormRegister_Load;
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDaftar;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPasswordd;
        private Label lblUsername;
        private TextBox txtNamaPengguna;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblNamaPengguna;
        private Label lblLogin;
        private TextBox tbOtp;
        private Label lblOtp;
        private Button btnOtp;
        private Panel panelRegister;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel llLogin;
        private Label label2;
    }
}