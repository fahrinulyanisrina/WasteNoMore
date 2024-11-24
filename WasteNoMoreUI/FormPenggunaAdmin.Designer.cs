namespace WasteNoMoreUI
{
    partial class FormPenggunaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenggunaAdmin));
            btnBack = new Button();
            lblJudul = new Label();
            dgvPengguna = new DataGridView();
            lblUpdate = new Label();
            lblDelete = new Label();
            lblInsert = new Label();
            pbDelete = new PictureBox();
            pbUpdate = new PictureBox();
            pbInsert = new PictureBox();
            btnLoad = new Button();
            txtNama = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblNamaPengguna = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPasswordd = new Label();
            lblUsername = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInsert).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Brown;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(713, 396);
            btnBack.Margin = new Padding(2, 1, 2, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 22);
            btnBack.TabIndex = 98;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(342, 22);
            lblJudul.Margin = new Padding(2, 0, 2, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(222, 25);
            lblJudul.TabIndex = 97;
            lblJudul.Text = "Manajemen Pengguna";
            // 
            // dgvPengguna
            // 
            dgvPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPengguna.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengguna.Location = new Point(54, 201);
            dgvPengguna.Margin = new Padding(2, 1, 2, 1);
            dgvPengguna.Name = "dgvPengguna";
            dgvPengguna.RowHeadersWidth = 82;
            dgvPengguna.Size = new Size(740, 144);
            dgvPengguna.TabIndex = 96;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(594, 145);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(59, 20);
            lblUpdate.TabIndex = 95;
            lblUpdate.Text = "Update";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(731, 145);
            lblDelete.Margin = new Padding(2, 0, 2, 0);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(53, 20);
            lblDelete.TabIndex = 94;
            lblDelete.Text = "Delete";
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(460, 144);
            lblInsert.Margin = new Padding(2, 0, 2, 0);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(47, 20);
            lblInsert.TabIndex = 93;
            lblInsert.Text = "Insert";
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(713, 76);
            pbDelete.Margin = new Padding(2, 1, 2, 1);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(81, 68);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 92;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            // 
            // pbUpdate
            // 
            pbUpdate.Image = (Image)resources.GetObject("pbUpdate.Image");
            pbUpdate.Location = new Point(583, 76);
            pbUpdate.Margin = new Padding(2, 1, 2, 1);
            pbUpdate.Name = "pbUpdate";
            pbUpdate.Size = new Size(81, 68);
            pbUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdate.TabIndex = 91;
            pbUpdate.TabStop = false;
            pbUpdate.Click += pbUpdate_Click;
            // 
            // pbInsert
            // 
            pbInsert.Image = (Image)resources.GetObject("pbInsert.Image");
            pbInsert.Location = new Point(441, 72);
            pbInsert.Margin = new Padding(2, 1, 2, 1);
            pbInsert.Name = "pbInsert";
            pbInsert.Size = new Size(88, 78);
            pbInsert.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInsert.TabIndex = 90;
            pbInsert.TabStop = false;
            pbInsert.Click += pbInsert_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(406, 358);
            btnLoad.Margin = new Padding(2, 1, 2, 1);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(81, 22);
            btnLoad.TabIndex = 89;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(143, 72);
            txtNama.Margin = new Padding(2, 1, 2, 1);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(217, 23);
            txtNama.TabIndex = 106;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 155);
            txtEmail.Margin = new Padding(2, 1, 2, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 23);
            txtEmail.TabIndex = 105;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(88, 155);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 104;
            lblEmail.Text = "Email :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(85, 73);
            lblNamaPengguna.Margin = new Padding(2, 0, 2, 0);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(45, 15);
            lblNamaPengguna.TabIndex = 103;
            lblNamaPengguna.Text = "Nama :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(143, 99);
            txtUsername.Margin = new Padding(2, 1, 2, 1);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(217, 23);
            txtUsername.TabIndex = 102;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 126);
            txtPassword.Margin = new Padding(2, 1, 2, 1);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(217, 23);
            txtPassword.TabIndex = 101;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordd
            // 
            lblPasswordd.AutoSize = true;
            lblPasswordd.Location = new Point(66, 127);
            lblPasswordd.Margin = new Padding(2, 0, 2, 0);
            lblPasswordd.Name = "lblPasswordd";
            lblPasswordd.Size = new Size(63, 15);
            lblPasswordd.TabIndex = 100;
            lblPasswordd.Text = "Password :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(61, 99);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(66, 15);
            lblUsername.TabIndex = 99;
            lblUsername.Text = "Username :";
            // 
            // FormPenggunaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(838, 351);
            Controls.Add(txtNama);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblNamaPengguna);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(lblPasswordd);
            Controls.Add(lblUsername);
            Controls.Add(btnBack);
            Controls.Add(lblJudul);
            Controls.Add(dgvPengguna);
            Controls.Add(lblUpdate);
            Controls.Add(lblDelete);
            Controls.Add(lblInsert);
            Controls.Add(pbDelete);
            Controls.Add(pbUpdate);
            Controls.Add(pbInsert);
            Controls.Add(btnLoad);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormPenggunaAdmin";
            Text = "FormPenggunaAdmin";
            Load += FormPenggunaAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInsert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblJudul;
        private DataGridView dgvPengguna;
        private Label lblUpdate;
        private Label lblDelete;
        private Label lblInsert;
        private PictureBox pbDelete;
        private PictureBox pbUpdate;
        private PictureBox pbInsert;
        private Button btnLoad;
        private TextBox txtNama;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblNamaPengguna;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPasswordd;
        private Label lblUsername;
    }
}