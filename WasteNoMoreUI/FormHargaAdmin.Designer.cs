namespace WasteNoMoreUI
{
    partial class FormHargaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHargaAdmin));
            btnBackHarga = new Button();
            lblHarga = new Label();
            dgvHarga = new DataGridView();
            lblUpdate = new Label();
            lblDelete = new Label();
            lblInsert = new Label();
            pbDeleteHarga = new PictureBox();
            pbUpdateHarga = new PictureBox();
            pbInsertHarga = new PictureBox();
            btnLoadHarga = new Button();
            lblKategoriHarga = new Label();
            lblAplikasiHarga = new Label();
            txtHarga = new TextBox();
            cmbAplikasi = new ComboBox();
            cmbKategori = new ComboBox();
            lblHargaKg = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInsertHarga).BeginInit();
            SuspendLayout();
            // 
            // btnBackHarga
            // 
            btnBackHarga.BackColor = SystemColors.ControlLight;
            btnBackHarga.Location = new Point(1028, 653);
            btnBackHarga.Margin = new Padding(2);
            btnBackHarga.Name = "btnBackHarga";
            btnBackHarga.Size = new Size(115, 36);
            btnBackHarga.TabIndex = 112;
            btnBackHarga.Text = "Back";
            btnBackHarga.UseVisualStyleBackColor = false;
            btnBackHarga.Click += btnBackHarga_Click;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(542, 23);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(120, 38);
            lblHarga.TabIndex = 111;
            lblHarga.Text = "HARGA";
            // 
            // dgvHarga
            // 
            dgvHarga.BackgroundColor = SystemColors.ButtonHighlight;
            dgvHarga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHarga.Location = new Point(86, 311);
            dgvHarga.Margin = new Padding(2);
            dgvHarga.Name = "dgvHarga";
            dgvHarga.RowHeadersWidth = 82;
            dgvHarga.Size = new Size(1057, 257);
            dgvHarga.TabIndex = 110;
            dgvHarga.CellContentClick += dgvHarga_CellContentClick;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(858, 236);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(85, 30);
            lblUpdate.TabIndex = 109;
            lblUpdate.Text = "Update";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(1053, 236);
            lblDelete.Margin = new Padding(2, 0, 2, 0);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(79, 30);
            lblDelete.TabIndex = 108;
            lblDelete.Text = "Delete";
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(666, 233);
            lblInsert.Margin = new Padding(2, 0, 2, 0);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(70, 30);
            lblInsert.TabIndex = 107;
            lblInsert.Text = "Insert";
            // 
            // pbDeleteHarga
            // 
            pbDeleteHarga.Image = (Image)resources.GetObject("pbDeleteHarga.Image");
            pbDeleteHarga.Location = new Point(1028, 121);
            pbDeleteHarga.Margin = new Padding(2);
            pbDeleteHarga.Name = "pbDeleteHarga";
            pbDeleteHarga.Size = new Size(115, 112);
            pbDeleteHarga.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeleteHarga.TabIndex = 106;
            pbDeleteHarga.TabStop = false;
            pbDeleteHarga.Click += pbDeleteHarga_Click;
            // 
            // pbUpdateHarga
            // 
            pbUpdateHarga.Image = (Image)resources.GetObject("pbUpdateHarga.Image");
            pbUpdateHarga.Location = new Point(841, 121);
            pbUpdateHarga.Margin = new Padding(2);
            pbUpdateHarga.Name = "pbUpdateHarga";
            pbUpdateHarga.Size = new Size(115, 112);
            pbUpdateHarga.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdateHarga.TabIndex = 105;
            pbUpdateHarga.TabStop = false;
            pbUpdateHarga.Click += pbUpdateHarga_Click;
            // 
            // pbInsertHarga
            // 
            pbInsertHarga.Image = (Image)resources.GetObject("pbInsertHarga.Image");
            pbInsertHarga.Location = new Point(639, 113);
            pbInsertHarga.Margin = new Padding(2);
            pbInsertHarga.Name = "pbInsertHarga";
            pbInsertHarga.Size = new Size(126, 130);
            pbInsertHarga.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInsertHarga.TabIndex = 104;
            pbInsertHarga.TabStop = false;
            pbInsertHarga.Click += pbInsertHarga_Click;
            // 
            // btnLoadHarga
            // 
            btnLoadHarga.BackColor = SystemColors.Highlight;
            btnLoadHarga.ForeColor = SystemColors.ButtonHighlight;
            btnLoadHarga.Location = new Point(589, 590);
            btnLoadHarga.Margin = new Padding(2);
            btnLoadHarga.Name = "btnLoadHarga";
            btnLoadHarga.Size = new Size(115, 36);
            btnLoadHarga.TabIndex = 103;
            btnLoadHarga.Text = "Load";
            btnLoadHarga.UseVisualStyleBackColor = false;
            btnLoadHarga.Click += btnLoadHarga_Click;
            // 
            // lblKategoriHarga
            // 
            lblKategoriHarga.AutoSize = true;
            lblKategoriHarga.Location = new Point(107, 166);
            lblKategoriHarga.Margin = new Padding(2, 0, 2, 0);
            lblKategoriHarga.Name = "lblKategoriHarga";
            lblKategoriHarga.Size = new Size(87, 25);
            lblKategoriHarga.TabIndex = 100;
            lblKategoriHarga.Text = "Kategori :";
            // 
            // lblAplikasiHarga
            // 
            lblAplikasiHarga.AutoSize = true;
            lblAplikasiHarga.Location = new Point(112, 110);
            lblAplikasiHarga.Margin = new Padding(2, 0, 2, 0);
            lblAplikasiHarga.Name = "lblAplikasiHarga";
            lblAplikasiHarga.Size = new Size(82, 25);
            lblAplikasiHarga.TabIndex = 99;
            lblAplikasiHarga.Text = "Aplikasi :";
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(199, 229);
            txtHarga.Margin = new Padding(2);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(326, 37);
            txtHarga.TabIndex = 101;
            // 
            // cmbAplikasi
            // 
            cmbAplikasi.FormattingEnabled = true;
            cmbAplikasi.Location = new Point(199, 107);
            cmbAplikasi.Name = "cmbAplikasi";
            cmbAplikasi.Size = new Size(326, 33);
            cmbAplikasi.TabIndex = 113;
            cmbAplikasi.SelectedIndexChanged += cmbAplikasi_SelectedIndexChanged;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(199, 163);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(326, 33);
            cmbKategori.TabIndex = 114;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lblHargaKg
            // 
            lblHargaKg.AutoSize = true;
            lblHargaKg.Location = new Point(125, 232);
            lblHargaKg.Margin = new Padding(2, 0, 2, 0);
            lblHargaKg.Name = "lblHargaKg";
            lblHargaKg.Size = new Size(69, 25);
            lblHargaKg.TabIndex = 115;
            lblHargaKg.Text = "Harga :";
            // 
            // FormHargaAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1229, 712);
            Controls.Add(lblHargaKg);
            Controls.Add(cmbKategori);
            Controls.Add(cmbAplikasi);
            Controls.Add(btnBackHarga);
            Controls.Add(lblHarga);
            Controls.Add(dgvHarga);
            Controls.Add(lblUpdate);
            Controls.Add(lblDelete);
            Controls.Add(lblInsert);
            Controls.Add(pbDeleteHarga);
            Controls.Add(pbUpdateHarga);
            Controls.Add(pbInsertHarga);
            Controls.Add(btnLoadHarga);
            Controls.Add(txtHarga);
            Controls.Add(lblKategoriHarga);
            Controls.Add(lblAplikasiHarga);
            Name = "FormHargaAdmin";
            Text = "FormHargaAdmin";
            Load += FormHargaAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInsertHarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackHarga;
        private Label lblHarga;
        private DataGridView dgvHarga;
        private Label lblUpdate;
        private Label lblDelete;
        private Label lblInsert;
        private PictureBox pbDeleteHarga;
        private PictureBox pbUpdateHarga;
        private PictureBox pbInsertHarga;
        private Button btnLoadHarga;
        private Label lblKategoriHarga;
        private Label lblAplikasiHarga;
        private TextBox txtHarga;
        private ComboBox cmbAplikasi;
        private ComboBox cmbKategori;
        private Label lblHargaKg;
    }
}