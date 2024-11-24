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
            lblJudul = new Label();
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
            // lblJudul
            // 

            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(645, 42);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(402, 50);
            lblJudul.TabIndex = 83;
            lblJudul.Text = "Manajemen Kategori";

            // 
            // dgvKategori
            // 
            dgvKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKategori.BackgroundColor = SystemColors.ButtonHighlight;
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(60, 180);
            dgvKategori.Margin = new Padding(2, 1, 2, 1);
            dgvKategori.Name = "dgvKategori";
            dgvKategori.RowHeadersWidth = 82;
            dgvKategori.Size = new Size(740, 161);
            dgvKategori.TabIndex = 82;
            dgvKategori.CellContentClick += dgvKategori_CellContentClick;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdate.Location = new Point(600, 142);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(59, 20);
            lblUpdate.TabIndex = 81;
            lblUpdate.Text = "Update";
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDelete.Location = new Point(736, 142);
            lblDelete.Margin = new Padding(2, 0, 2, 0);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(53, 20);
            lblDelete.TabIndex = 80;
            lblDelete.Text = "Delete";
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInsert.Location = new Point(466, 141);
            lblInsert.Margin = new Padding(2, 0, 2, 0);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(47, 20);
            lblInsert.TabIndex = 79;
            lblInsert.Text = "Insert";
            // 
            // pbDelete
            // 
            pbDelete.Image = (Image)resources.GetObject("pbDelete.Image");
            pbDelete.Location = new Point(719, 74);
            pbDelete.Margin = new Padding(2, 1, 2, 1);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(81, 68);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 78;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            // 
            // pbUpdate
            // 
            pbUpdate.Image = (Image)resources.GetObject("pbUpdate.Image");
            pbUpdate.Location = new Point(588, 74);
            pbUpdate.Margin = new Padding(2, 1, 2, 1);
            pbUpdate.Name = "pbUpdate";
            pbUpdate.Size = new Size(81, 68);
            pbUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdate.TabIndex = 77;
            pbUpdate.TabStop = false;
            pbUpdate.Click += pbUpdate_Click;
            // 
            // pbInsert
            // 
            pbInsert.Image = (Image)resources.GetObject("pbInsert.Image");
            pbInsert.Location = new Point(446, 69);
            pbInsert.Margin = new Padding(2, 1, 2, 1);
            pbInsert.Name = "pbInsert";
            pbInsert.Size = new Size(88, 78);
            pbInsert.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInsert.TabIndex = 76;
            pbInsert.TabStop = false;
            pbInsert.Click += pbInsert_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.SteelBlue;
            btnLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(411, 355);
            btnLoad.Margin = new Padding(2, 1, 2, 1);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(81, 22);
            btnLoad.TabIndex = 75;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(139, 66);
            txtNama.Margin = new Padding(2, 1, 2, 1);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(230, 23);
            txtNama.TabIndex = 74;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(139, 100);
            txtDeskripsi.Margin = new Padding(2, 1, 2, 1);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(230, 73);
            txtDeskripsi.TabIndex = 73;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(62, 100);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 15);
            lblEmail.TabIndex = 72;
            lblEmail.Text = "Deskripsi :";
            // 
            // lblNamaPengguna
            // 
            lblNamaPengguna.AutoSize = true;
            lblNamaPengguna.Location = new Point(80, 67);
            lblNamaPengguna.Margin = new Padding(2, 0, 2, 0);
            lblNamaPengguna.Name = "lblNamaPengguna";
            lblNamaPengguna.Size = new Size(45, 15);
            lblNamaPengguna.TabIndex = 71;
            lblNamaPengguna.Text = "Nama :";
            // 
            // btnBack
            // 

            btnBack.BackColor = Color.Brown;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1335, 839);

            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 22);
            btnBack.TabIndex = 84;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormKategoriAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(738, 351);
            Controls.Add(btnBack);
            Controls.Add(lblJudul);
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
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormKategoriAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKategoriAdmin";
            FormClosed += FormKategoriAdmin_FormClosed;
            Load += FormKategoriAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInsert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
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