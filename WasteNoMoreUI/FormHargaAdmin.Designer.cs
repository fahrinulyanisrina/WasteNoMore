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
            lblKg = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInsertHarga).BeginInit();
            SuspendLayout();
            // 
            // btnBackHarga
            // 
            btnBackHarga.BackColor = SystemColors.ScrollBar;
            btnBackHarga.Location = new Point(719, 392);
            btnBackHarga.Margin = new Padding(2, 1, 2, 1);
            btnBackHarga.Name = "btnBackHarga";
            btnBackHarga.Size = new Size(81, 22);
            btnBackHarga.TabIndex = 112;
            btnBackHarga.Text = "Back";
            btnBackHarga.UseVisualStyleBackColor = false;
            btnBackHarga.Click += btnBackHarga_Click;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(313, 18);
            lblHarga.Margin = new Padding(2, 0, 2, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(265, 25);
            lblHarga.TabIndex = 111;
            lblHarga.Text = "Manajemen Harga Sampah";
            lblHarga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvHarga
            // 
            dgvHarga.BackgroundColor = SystemColors.ButtonHighlight;
            dgvHarga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHarga.Location = new Point(60, 187);
            dgvHarga.Margin = new Padding(2, 1, 2, 1);
            dgvHarga.Name = "dgvHarga";
            dgvHarga.RowHeadersWidth = 82;
            dgvHarga.Size = new Size(740, 154);
            dgvHarga.TabIndex = 110;
            dgvHarga.CellContentClick += dgvHarga_CellContentClick;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(600, 142);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(59, 20);
            lblUpdate.TabIndex = 109;
            lblUpdate.Text = "Update";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(737, 142);
            lblDelete.Margin = new Padding(2, 0, 2, 0);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(53, 20);
            lblDelete.TabIndex = 108;
            lblDelete.Text = "Delete";
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(466, 140);
            lblInsert.Margin = new Padding(2, 0, 2, 0);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(47, 20);
            lblInsert.TabIndex = 107;
            lblInsert.Text = "Insert";
            // 
            // pbDeleteHarga
            // 
            pbDeleteHarga.Image = (Image)resources.GetObject("pbDeleteHarga.Image");
            pbDeleteHarga.Location = new Point(719, 73);
            pbDeleteHarga.Margin = new Padding(2, 1, 2, 1);
            pbDeleteHarga.Name = "pbDeleteHarga";
            pbDeleteHarga.Size = new Size(81, 67);
            pbDeleteHarga.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeleteHarga.TabIndex = 106;
            pbDeleteHarga.TabStop = false;
            pbDeleteHarga.Click += pbDeleteHarga_Click;
            // 
            // pbUpdateHarga
            // 
            pbUpdateHarga.Image = (Image)resources.GetObject("pbUpdateHarga.Image");
            pbUpdateHarga.Location = new Point(589, 73);
            pbUpdateHarga.Margin = new Padding(2, 1, 2, 1);
            pbUpdateHarga.Name = "pbUpdateHarga";
            pbUpdateHarga.Size = new Size(81, 67);
            pbUpdateHarga.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdateHarga.TabIndex = 105;
            pbUpdateHarga.TabStop = false;
            pbUpdateHarga.Click += pbUpdateHarga_Click;
            // 
            // pbInsertHarga
            // 
            pbInsertHarga.Image = (Image)resources.GetObject("pbInsertHarga.Image");
            pbInsertHarga.Location = new Point(447, 68);
            pbInsertHarga.Margin = new Padding(2, 1, 2, 1);
            pbInsertHarga.Name = "pbInsertHarga";
            pbInsertHarga.Size = new Size(88, 78);
            pbInsertHarga.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInsertHarga.TabIndex = 104;
            pbInsertHarga.TabStop = false;
            pbInsertHarga.Click += pbInsertHarga_Click;
            // 
            // btnLoadHarga
            // 
            btnLoadHarga.BackColor = Color.SteelBlue;
            btnLoadHarga.ForeColor = SystemColors.ButtonHighlight;
            btnLoadHarga.Location = new Point(412, 354);
            btnLoadHarga.Margin = new Padding(2, 1, 2, 1);
            btnLoadHarga.Name = "btnLoadHarga";
            btnLoadHarga.Size = new Size(81, 22);
            btnLoadHarga.TabIndex = 103;
            btnLoadHarga.Text = "Load";
            btnLoadHarga.UseVisualStyleBackColor = false;
            btnLoadHarga.Click += btnLoadHarga_Click;
            // 
            // lblKategoriHarga
            // 
            lblKategoriHarga.AutoSize = true;
            lblKategoriHarga.Location = new Point(75, 99);
            lblKategoriHarga.Margin = new Padding(2, 0, 2, 0);
            lblKategoriHarga.Name = "lblKategoriHarga";
            lblKategoriHarga.Size = new Size(57, 15);
            lblKategoriHarga.TabIndex = 100;
            lblKategoriHarga.Text = "Kategori :";
            // 
            // lblAplikasiHarga
            // 
            lblAplikasiHarga.AutoSize = true;
            lblAplikasiHarga.Location = new Point(79, 66);
            lblAplikasiHarga.Margin = new Padding(2, 0, 2, 0);
            lblAplikasiHarga.Name = "lblAplikasiHarga";
            lblAplikasiHarga.Size = new Size(54, 15);
            lblAplikasiHarga.TabIndex = 99;
            lblAplikasiHarga.Text = "Aplikasi :";
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(139, 132);
            txtHarga.Margin = new Padding(2, 1, 2, 1);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(185, 24);
            txtHarga.TabIndex = 101;
            // 
            // cmbAplikasi
            // 
            cmbAplikasi.FormattingEnabled = true;
            cmbAplikasi.Location = new Point(139, 64);
            cmbAplikasi.Margin = new Padding(2, 2, 2, 2);
            cmbAplikasi.Name = "cmbAplikasi";
            cmbAplikasi.Size = new Size(230, 23);
            cmbAplikasi.TabIndex = 113;
            cmbAplikasi.SelectedIndexChanged += cmbAplikasi_SelectedIndexChanged;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(139, 98);
            cmbKategori.Margin = new Padding(2, 2, 2, 2);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(230, 23);
            cmbKategori.TabIndex = 114;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lblHargaKg
            // 
            lblHargaKg.AutoSize = true;
            lblHargaKg.Location = new Point(87, 134);
            lblHargaKg.Margin = new Padding(2, 0, 2, 0);
            lblHargaKg.Name = "lblHargaKg";
            lblHargaKg.Size = new Size(45, 15);
            lblHargaKg.TabIndex = 115;
            lblHargaKg.Text = "Harga :";
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Location = new Point(332, 134);
            lblKg.Margin = new Padding(2, 0, 2, 0);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(25, 15);
            lblKg.TabIndex = 116;
            lblKg.Text = "/kg";
            // 
            // FormHargaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(738, 351);
            Controls.Add(lblKg);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormHargaAdmin";
            Text = "FormHargaAdmin";
            FormClosed += FormHargaAdmin_FormClosed;
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
        private Label lblKg;
    }
}