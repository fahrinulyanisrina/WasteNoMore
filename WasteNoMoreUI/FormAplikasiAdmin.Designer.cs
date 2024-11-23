namespace WasteNoMoreUI
{
    partial class FormAplikasiAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAplikasiAdmin));
            btnBackAplikasi = new Button();
            lblAplikasi = new Label();
            dgvAplikasi = new DataGridView();
            lblUpdate = new Label();
            lblDelete = new Label();
            lblInsert = new Label();
            pbDeleteAplikasi = new PictureBox();
            pbUpdateAplikasi = new PictureBox();
            pbInsertAplikasi = new PictureBox();
            btnLoadAplikasi = new Button();
            txtNamaAplikasi = new TextBox();
            txtDeskripsiAplikasi = new TextBox();
            lblEmail = new Label();
            lblNamaPengguna = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAplikasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteAplikasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAplikasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInsertAplikasi).BeginInit();
            SuspendLayout();
            // 
            // btnBackAplikasi
            // 
            btnBackAplikasi.BackColor = SystemColors.ControlLight;
            btnBackAplikasi.Location = new Point(1336, 837);
            btnBackAplikasi.Name = "btnBackAplikasi";
            btnBackAplikasi.Size = new Size(150, 46);
            btnBackAplikasi.TabIndex = 98;
            btnBackAplikasi.Text = "Back";
            btnBackAplikasi.UseVisualStyleBackColor = false;
            btnBackAplikasi.Click += btnBackAplikasi_Click;
            // 
            // lblAplikasi
            // 
            lblAplikasi.AutoSize = true;
            lblAplikasi.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAplikasi.Location = new Point(476, 41);
            lblAplikasi.Name = "lblAplikasi";
            lblAplikasi.Size = new Size(690, 50);
            lblAplikasi.TabIndex = 97;
            lblAplikasi.Text = "Manajemen Aplikasi Penjual Sampah";
            lblAplikasi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAplikasi
            // 
            dgvAplikasi.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAplikasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAplikasi.Location = new Point(112, 399);
            dgvAplikasi.Name = "dgvAplikasi";
            dgvAplikasi.RowHeadersWidth = 82;
            dgvAplikasi.Size = new Size(1374, 329);
            dgvAplikasi.TabIndex = 96;
            dgvAplikasi.CellContentClick += dgvAplikasi_CellContentClick;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(1115, 303);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(111, 40);
            lblUpdate.TabIndex = 95;
            lblUpdate.Text = "Update";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(1369, 303);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(101, 40);
            lblDelete.TabIndex = 94;
            lblDelete.Text = "Delete";
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(866, 300);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(92, 40);
            lblInsert.TabIndex = 93;
            lblInsert.Text = "Insert";
            // 
            // pbDeleteAplikasi
            // 
            pbDeleteAplikasi.Image = (Image)resources.GetObject("pbDeleteAplikasi.Image");
            pbDeleteAplikasi.Location = new Point(1336, 156);
            pbDeleteAplikasi.Name = "pbDeleteAplikasi";
            pbDeleteAplikasi.Size = new Size(150, 143);
            pbDeleteAplikasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeleteAplikasi.TabIndex = 92;
            pbDeleteAplikasi.TabStop = false;
            pbDeleteAplikasi.Click += pbDeleteAplikasi_Click;
            // 
            // pbUpdateAplikasi
            // 
            pbUpdateAplikasi.Image = (Image)resources.GetObject("pbUpdateAplikasi.Image");
            pbUpdateAplikasi.Location = new Point(1093, 156);
            pbUpdateAplikasi.Name = "pbUpdateAplikasi";
            pbUpdateAplikasi.Size = new Size(150, 143);
            pbUpdateAplikasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdateAplikasi.TabIndex = 91;
            pbUpdateAplikasi.TabStop = false;
            pbUpdateAplikasi.Click += pbUpdateAplikasi_Click;
            // 
            // pbInsertAplikasi
            // 
            pbInsertAplikasi.Image = (Image)resources.GetObject("pbInsertAplikasi.Image");
            pbInsertAplikasi.Location = new Point(831, 146);
            pbInsertAplikasi.Name = "pbInsertAplikasi";
            pbInsertAplikasi.Size = new Size(164, 166);
            pbInsertAplikasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInsertAplikasi.TabIndex = 90;
            pbInsertAplikasi.TabStop = false;
            pbInsertAplikasi.Click += pbInsertAplikasi_Click;
            // 
            // btnLoadAplikasi
            // 
            btnLoadAplikasi.BackColor = Color.SteelBlue;
            btnLoadAplikasi.ForeColor = SystemColors.ButtonHighlight;
            btnLoadAplikasi.Location = new Point(766, 756);
            btnLoadAplikasi.Name = "btnLoadAplikasi";
            btnLoadAplikasi.Size = new Size(150, 46);
            btnLoadAplikasi.TabIndex = 89;
            btnLoadAplikasi.Text = "Load";
            btnLoadAplikasi.UseVisualStyleBackColor = false;
            btnLoadAplikasi.Click += btnLoadAplikasi_Click;
            // 
            // txtNamaAplikasi
            // 
            txtNamaAplikasi.Location = new Point(259, 138);
            txtNamaAplikasi.Name = "txtNamaAplikasi";
            txtNamaAplikasi.Size = new Size(423, 39);
            txtNamaAplikasi.TabIndex = 88;
            // 
            // txtDeskripsiAplikasi
            // 
            txtDeskripsiAplikasi.Location = new Point(259, 216);
            txtDeskripsiAplikasi.Multiline = true;
            txtDeskripsiAplikasi.Name = "txtDeskripsiAplikasi";
            txtDeskripsiAplikasi.Size = new Size(423, 145);
            txtDeskripsiAplikasi.TabIndex = 87;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(118, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(122, 32);
            lblEmail.TabIndex = 86;
            lblEmail.Text = "Deskripsi :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(151, 142);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(89, 32);
            lblNamaPengguna.TabIndex = 85;
            lblNamaPengguna.Text = "Nama :";
            // 
            // FormAplikasiAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1598, 911);
            Controls.Add(btnBackAplikasi);
            Controls.Add(lblAplikasi);
            Controls.Add(dgvAplikasi);
            Controls.Add(lblUpdate);
            Controls.Add(lblDelete);
            Controls.Add(lblInsert);
            Controls.Add(pbDeleteAplikasi);
            Controls.Add(pbUpdateAplikasi);
            Controls.Add(pbInsertAplikasi);
            Controls.Add(btnLoadAplikasi);
            Controls.Add(txtNamaAplikasi);
            Controls.Add(txtDeskripsiAplikasi);
            Controls.Add(lblEmail);
            Controls.Add(lblNamaPengguna);
            Margin = new Padding(4);
            Name = "FormAplikasiAdmin";
            Text = "FormAplikasiAdmin";
            Load += FormAplikasiAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAplikasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteAplikasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAplikasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInsertAplikasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackAplikasi;
        private Label lblAplikasi;
        private DataGridView dgvAplikasi;
        private Label lblUpdate;
        private Label lblDelete;
        private Label lblInsert;
        private PictureBox pbDeleteAplikasi;
        private PictureBox pbUpdateAplikasi;
        private PictureBox pbInsertAplikasi;
        private Button btnLoadAplikasi;
        private TextBox txtNamaAplikasi;
        private TextBox txtDeskripsiAplikasi;
        private Label lblEmail;
        private Label lblNamaPengguna;
    }
}