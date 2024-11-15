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
            cbKategori = new ComboBox();
            lblKategoriAplikasi = new Label();
            txtHarga = new TextBox();
            lblHarga = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAplikasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteAplikasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAplikasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInsertAplikasi).BeginInit();
            SuspendLayout();
            // 
            // btnBackAplikasi
            // 
            btnBackAplikasi.BackColor = SystemColors.ControlLight;
            btnBackAplikasi.Location = new Point(1028, 654);
            btnBackAplikasi.Margin = new Padding(2);
            btnBackAplikasi.Name = "btnBackAplikasi";
            btnBackAplikasi.Size = new Size(115, 36);
            btnBackAplikasi.TabIndex = 98;
            btnBackAplikasi.Text = "Back";
            btnBackAplikasi.UseVisualStyleBackColor = false;
            btnBackAplikasi.Click += btnBackAplikasi_Click;
            // 
            // lblAplikasi
            // 
            lblAplikasi.AutoSize = true;
            lblAplikasi.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAplikasi.Location = new Point(485, 25);
            lblAplikasi.Margin = new Padding(2, 0, 2, 0);
            lblAplikasi.Name = "lblAplikasi";
            lblAplikasi.Size = new Size(331, 38);
            lblAplikasi.TabIndex = 97;
            lblAplikasi.Text = "APLIKASI DAN HARGA";
            // 
            // dgvAplikasi
            // 
            dgvAplikasi.BackgroundColor = SystemColors.ButtonHighlight;
            dgvAplikasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAplikasi.Location = new Point(86, 348);
            dgvAplikasi.Margin = new Padding(2);
            dgvAplikasi.Name = "dgvAplikasi";
            dgvAplikasi.RowHeadersWidth = 82;
            dgvAplikasi.Size = new Size(1057, 221);
            dgvAplikasi.TabIndex = 96;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(858, 237);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(85, 30);
            lblUpdate.TabIndex = 95;
            lblUpdate.Text = "Update";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(1053, 237);
            lblDelete.Margin = new Padding(2, 0, 2, 0);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(79, 30);
            lblDelete.TabIndex = 94;
            lblDelete.Text = "Delete";
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(666, 234);
            lblInsert.Margin = new Padding(2, 0, 2, 0);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(70, 30);
            lblInsert.TabIndex = 93;
            lblInsert.Text = "Insert";
            // 
            // pbDeleteAplikasi
            // 
            pbDeleteAplikasi.Image = (Image)resources.GetObject("pbDeleteAplikasi.Image");
            pbDeleteAplikasi.Location = new Point(1028, 122);
            pbDeleteAplikasi.Margin = new Padding(2);
            pbDeleteAplikasi.Name = "pbDeleteAplikasi";
            pbDeleteAplikasi.Size = new Size(115, 112);
            pbDeleteAplikasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeleteAplikasi.TabIndex = 92;
            pbDeleteAplikasi.TabStop = false;
            pbDeleteAplikasi.Click += pbDeleteAplikasi_Click;
            // 
            // pbUpdateAplikasi
            // 
            pbUpdateAplikasi.Image = (Image)resources.GetObject("pbUpdateAplikasi.Image");
            pbUpdateAplikasi.Location = new Point(841, 122);
            pbUpdateAplikasi.Margin = new Padding(2);
            pbUpdateAplikasi.Name = "pbUpdateAplikasi";
            pbUpdateAplikasi.Size = new Size(115, 112);
            pbUpdateAplikasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdateAplikasi.TabIndex = 91;
            pbUpdateAplikasi.TabStop = false;
            pbUpdateAplikasi.Click += pbUpdateAplikasi_Click;
            // 
            // pbInsertAplikasi
            // 
            pbInsertAplikasi.Image = (Image)resources.GetObject("pbInsertAplikasi.Image");
            pbInsertAplikasi.Location = new Point(639, 114);
            pbInsertAplikasi.Margin = new Padding(2);
            pbInsertAplikasi.Name = "pbInsertAplikasi";
            pbInsertAplikasi.Size = new Size(126, 130);
            pbInsertAplikasi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInsertAplikasi.TabIndex = 90;
            pbInsertAplikasi.TabStop = false;
            pbInsertAplikasi.Click += pbInsertAplikasi_Click;
            // 
            // btnLoadAplikasi
            // 
            btnLoadAplikasi.BackColor = SystemColors.Highlight;
            btnLoadAplikasi.ForeColor = SystemColors.ButtonHighlight;
            btnLoadAplikasi.Location = new Point(589, 591);
            btnLoadAplikasi.Margin = new Padding(2);
            btnLoadAplikasi.Name = "btnLoadAplikasi";
            btnLoadAplikasi.Size = new Size(115, 36);
            btnLoadAplikasi.TabIndex = 89;
            btnLoadAplikasi.Text = "Load";
            btnLoadAplikasi.UseVisualStyleBackColor = false;
            // 
            // txtNamaAplikasi
            // 
            txtNamaAplikasi.Location = new Point(199, 108);
            txtNamaAplikasi.Margin = new Padding(2);
            txtNamaAplikasi.Name = "txtNamaAplikasi";
            txtNamaAplikasi.Size = new Size(326, 31);
            txtNamaAplikasi.TabIndex = 88;
            // 
            // txtDeskripsiAplikasi
            // 
            txtDeskripsiAplikasi.Location = new Point(199, 205);
            txtDeskripsiAplikasi.Margin = new Padding(2);
            txtDeskripsiAplikasi.Multiline = true;
            txtDeskripsiAplikasi.Name = "txtDeskripsiAplikasi";
            txtDeskripsiAplikasi.Size = new Size(326, 85);
            txtDeskripsiAplikasi.TabIndex = 87;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(91, 209);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(93, 25);
            lblEmail.TabIndex = 86;
            lblEmail.Text = "Deskripsi :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(116, 111);
            lblNamaPengguna.Margin = new Padding(2, 0, 2, 0);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(68, 25);
            lblNamaPengguna.TabIndex = 85;
            lblNamaPengguna.Text = "Nama :";
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(199, 153);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(326, 33);
            cbKategori.TabIndex = 99;
            cbKategori.SelectedIndexChanged += cbKategori_SelectedIndexChanged;
            // 
            // lblKategoriAplikasi
            // 
            lblKategoriAplikasi.AutoSize = true;
            lblKategoriAplikasi.Location = new Point(97, 156);
            lblKategoriAplikasi.Margin = new Padding(2, 0, 2, 0);
            lblKategoriAplikasi.Name = "lblKategoriAplikasi";
            lblKategoriAplikasi.Size = new Size(87, 25);
            lblKategoriAplikasi.TabIndex = 100;
            lblKategoriAplikasi.Text = "Kategori :";
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(199, 303);
            txtHarga.Margin = new Padding(2);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(326, 31);
            txtHarga.TabIndex = 101;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(54, 303);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(130, 25);
            lblHarga.TabIndex = 102;
            lblHarga.Text = "Harga (per kg):";
            // 
            // FormAplikasiAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 712);
            Controls.Add(lblHarga);
            Controls.Add(txtHarga);
            Controls.Add(lblKategoriAplikasi);
            Controls.Add(cbKategori);
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
        private ComboBox cbKategori;
        private Label lblKategoriAplikasi;
        private TextBox txtHarga;
        private Label lblHarga;
    }
}