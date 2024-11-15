namespace WasteNoMoreUI
{
    partial class FormKategoriAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKategoriAdmin));
            label2 = new Label();
            dgvKategori = new DataGridView();
            lblUpdate = new Label();
            lblDelete = new Label();
            lblInsert = new Label();
            pbDelete = new PictureBox();
            pbUpdate = new PictureBox();
            pbInsert = new PictureBox();
            btnLoad = new Button();
            txtNama = new TextBox();
            txtDeskripsi = new TextBox();
            lblEmail = new Label();
            lblNamaPengguna = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInsert).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(701, 31);
            label2.Name = "label2";
            label2.Size = new Size(213, 50);
            label2.TabIndex = 83;
            label2.Text = "KATEGORI";
            // 
            // dgvKategori
            // 
            dgvKategori.BackgroundColor = SystemColors.ButtonHighlight;
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(111, 385);
            dgvKategori.Name = "dgvKategori";
            dgvKategori.RowHeadersWidth = 82;
            dgvKategori.Size = new Size(1374, 344);
            dgvKategori.TabIndex = 82;
            dgvKategori.CellContentClick += dgvKategori_CellContentClick;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(1114, 304);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(111, 40);
            lblUpdate.TabIndex = 81;
            lblUpdate.Text = "Update";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(1367, 304);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(101, 40);
            lblDelete.TabIndex = 80;
            lblDelete.Text = "Delete";
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(865, 301);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(92, 40);
            lblInsert.TabIndex = 79;
            lblInsert.Text = "Insert";
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(1335, 157);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(150, 144);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 78;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            // 
            // pbUpdate
            // 
            pbUpdate.Image = (Image)resources.GetObject("pbUpdate.Image");
            pbUpdate.Location = new Point(1092, 157);
            pbUpdate.Name = "pbUpdate";
            pbUpdate.Size = new Size(150, 144);
            pbUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdate.TabIndex = 77;
            pbUpdate.TabStop = false;
            pbUpdate.Click += pbUpdate_Click;
            // 
            // pbInsert
            // 
            pbInsert.Image = (Image)resources.GetObject("pbInsert.Image");
            pbInsert.Location = new Point(829, 147);
            pbInsert.Name = "pbInsert";
            pbInsert.Size = new Size(164, 167);
            pbInsert.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInsert.TabIndex = 76;
            pbInsert.TabStop = false;
            pbInsert.Click += pbInsert_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.Highlight;
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(764, 758);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 46);
            btnLoad.TabIndex = 75;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(258, 140);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(423, 39);
            txtNama.TabIndex = 74;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(258, 213);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(423, 151);
            txtDeskripsi.TabIndex = 73;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(116, 213);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(122, 32);
            lblEmail.TabIndex = 72;
            lblEmail.Text = "Deskripsi :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(149, 143);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(89, 32);
            lblNamaPengguna.TabIndex = 71;
            lblNamaPengguna.Text = "Nama :";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLight;
            btnBack.Location = new Point(1335, 839);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 46);
            btnBack.TabIndex = 84;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormKategoriAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1598, 911);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(dgvKategori);
            Controls.Add(lblUpdate);
            Controls.Add(lblDelete);
            Controls.Add(lblInsert);
            Controls.Add(pbDelete);
            Controls.Add(pbUpdate);
            Controls.Add(pbInsert);
            Controls.Add(btnLoad);
            Controls.Add(txtNama);
            Controls.Add(txtDeskripsi);
            Controls.Add(lblEmail);
            Controls.Add(lblNamaPengguna);
            Name = "FormKategoriAdmin";
            Text = "FormKategoriAdmin";
            Load += FormKategoriAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInsert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvKategori;
        private Label lblUpdate;
        private Label lblDelete;
        private Label lblInsert;
        private PictureBox pbDelete;
        private PictureBox pbUpdate;
        private PictureBox pbInsert;
        private Button btnLoad;
        private TextBox txtNama;
        private TextBox txtDeskripsi;
        private Label lblEmail;
        private Label lblNamaPengguna;
        private Button btnBack;
    }
}