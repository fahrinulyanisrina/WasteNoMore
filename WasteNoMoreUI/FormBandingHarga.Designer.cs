namespace WasteNoMoreUI
{
    partial class FormBandingHarga
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
            btnCancelBanding = new Button();
            btnBandingkan = new Button();
            lblBandingHarga = new Label();
            txtKuantitas = new TextBox();
            lblKg = new Label();
            lblBeratBanding = new Label();
            lblKategoriBanding = new Label();
            label1 = new Label();
            dgvBandingHarga = new DataGridView();
            lblAplikasiBanding = new Label();
            clbAplikasi = new CheckedListBox();
            clbKategori = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvBandingHarga).BeginInit();
            SuspendLayout();
            // 
            // btnCancelBanding
            // 
            btnCancelBanding.BackColor = SystemColors.ControlDarkDark;
            btnCancelBanding.ForeColor = SystemColors.ButtonHighlight;
            btnCancelBanding.Location = new Point(546, 165);
            btnCancelBanding.Margin = new Padding(1, 1, 1, 1);
            btnCancelBanding.Name = "btnCancelBanding";
            btnCancelBanding.Size = new Size(80, 22);
            btnCancelBanding.TabIndex = 50;
            btnCancelBanding.Text = "Cancel";
            btnCancelBanding.UseVisualStyleBackColor = false;
            btnCancelBanding.Click += btnCancelBanding_Click;
            // 
            // btnBandingkan
            // 
            btnBandingkan.BackColor = SystemColors.HotTrack;
            btnBandingkan.ForeColor = SystemColors.ButtonHighlight;
            btnBandingkan.Location = new Point(675, 165);
            btnBandingkan.Margin = new Padding(1, 1, 1, 1);
            btnBandingkan.Name = "btnBandingkan";
            btnBandingkan.Size = new Size(80, 22);
            btnBandingkan.TabIndex = 49;
            btnBandingkan.Text = "Bandingkan";
            btnBandingkan.UseVisualStyleBackColor = false;
            btnBandingkan.Click += btnBandingkan_Click;
            // 
            // lblBandingHarga
            // 
            lblBandingHarga.AutoSize = true;
            lblBandingHarga.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBandingHarga.Location = new Point(344, 39);
            lblBandingHarga.Margin = new Padding(1, 0, 1, 0);
            lblBandingHarga.Name = "lblBandingHarga";
            lblBandingHarga.Size = new Size(181, 19);
            lblBandingHarga.TabIndex = 48;
            lblBandingHarga.Text = "Bandingkan Harga Sampah!";
            // 
            // txtKuantitas
            // 
            txtKuantitas.Location = new Point(643, 100);
            txtKuantitas.Margin = new Padding(1, 1, 1, 1);
            txtKuantitas.Name = "txtKuantitas";
            txtKuantitas.Size = new Size(78, 23);
            txtKuantitas.TabIndex = 46;
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Location = new Point(733, 101);
            lblKg.Margin = new Padding(1, 0, 1, 0);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(20, 15);
            lblKg.TabIndex = 45;
            lblKg.Text = "kg";
            // 
            // lblBeratBanding
            // 
            lblBeratBanding.AutoSize = true;
            lblBeratBanding.Location = new Point(546, 100);
            lblBeratBanding.Margin = new Padding(1, 0, 1, 0);
            lblBeratBanding.Name = "lblBeratBanding";
            lblBeratBanding.Size = new Size(86, 15);
            lblBeratBanding.TabIndex = 44;
            lblBeratBanding.Text = "Berat Sampah :";
            // 
            // lblKategoriBanding
            // 
            lblKategoriBanding.AutoSize = true;
            lblKategoriBanding.Location = new Point(291, 100);
            lblKategoriBanding.Margin = new Padding(1, 0, 1, 0);
            lblKategoriBanding.Name = "lblKategoriBanding";
            lblKategoriBanding.Size = new Size(57, 15);
            lblKategoriBanding.TabIndex = 43;
            lblKategoriBanding.Text = "Kategori :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 39);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 42;
            // 
            // dgvBandingHarga
            // 
            dgvBandingHarga.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvBandingHarga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBandingHarga.Location = new Point(59, 228);
            dgvBandingHarga.Margin = new Padding(2, 2, 2, 2);
            dgvBandingHarga.Name = "dgvBandingHarga";
            dgvBandingHarga.RowHeadersWidth = 62;
            dgvBandingHarga.Size = new Size(726, 112);
            dgvBandingHarga.TabIndex = 52;
            dgvBandingHarga.CellContentClick += dgvBandingHarga_CellContentClick;
            // 
            // lblAplikasiBanding
            // 
            lblAplikasiBanding.AutoSize = true;
            lblAplikasiBanding.Location = new Point(59, 100);
            lblAplikasiBanding.Margin = new Padding(1, 0, 1, 0);
            lblAplikasiBanding.Name = "lblAplikasiBanding";
            lblAplikasiBanding.Size = new Size(54, 15);
            lblAplikasiBanding.TabIndex = 54;
            lblAplikasiBanding.Text = "Aplikasi :";
            // 
            // clbAplikasi
            // 
            clbAplikasi.FormattingEnabled = true;
            clbAplikasi.Location = new Point(120, 100);
            clbAplikasi.Margin = new Padding(2, 2, 2, 2);
            clbAplikasi.Name = "clbAplikasi";
            clbAplikasi.Size = new Size(132, 76);
            clbAplikasi.TabIndex = 55;
            clbAplikasi.SelectedIndexChanged += clbAplikasi_SelectedIndexChanged;
            // 
            // clbKategori
            // 
            clbKategori.FormattingEnabled = true;
            clbKategori.Location = new Point(355, 100);
            clbKategori.Margin = new Padding(2, 2, 2, 2);
            clbKategori.Name = "clbKategori";
            clbKategori.Size = new Size(132, 76);
            clbKategori.TabIndex = 56;
            clbKategori.SelectedIndexChanged += clbKategori_SelectedIndexChanged;
            // 
            // FormBandingHarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(836, 410);
            Controls.Add(clbKategori);
            Controls.Add(clbAplikasi);
            Controls.Add(lblAplikasiBanding);
            Controls.Add(dgvBandingHarga);
            Controls.Add(btnCancelBanding);
            Controls.Add(btnBandingkan);
            Controls.Add(lblBandingHarga);
            Controls.Add(txtKuantitas);
            Controls.Add(lblKg);
            Controls.Add(lblBeratBanding);
            Controls.Add(lblKategoriBanding);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormBandingHarga";
            Text = "FormBandingHarga";
            FormClosed += FormBandingHarga_FormClosed;
            Load += FormBandingHarga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBandingHarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelBanding;
        private Button btnBandingkan;
        private Label lblBandingHarga;
        private TextBox txtKuantitas;
        private Label lblKg;
        private Label lblBeratBanding;
        private Label lblKategoriBanding;
        private Label label1;
        private DataGridView dgvBandingHarga;
        private Label lblAplikasiBanding;
        private CheckedListBox clbAplikasi;
        private CheckedListBox clbKategori;
    }
}