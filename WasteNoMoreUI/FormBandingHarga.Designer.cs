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
            btnCancelBanding.Location = new Point(780, 275);
            btnCancelBanding.Margin = new Padding(2);
            btnCancelBanding.Name = "btnCancelBanding";
            btnCancelBanding.Size = new Size(115, 36);
            btnCancelBanding.TabIndex = 50;
            btnCancelBanding.Text = "Cancel";
            btnCancelBanding.UseVisualStyleBackColor = false;
            btnCancelBanding.Click += btnCancelBanding_Click;
            // 
            // btnBandingkan
            // 
            btnBandingkan.BackColor = SystemColors.HotTrack;
            btnBandingkan.ForeColor = SystemColors.ButtonHighlight;
            btnBandingkan.Location = new Point(964, 275);
            btnBandingkan.Margin = new Padding(2);
            btnBandingkan.Name = "btnBandingkan";
            btnBandingkan.Size = new Size(115, 36);
            btnBandingkan.TabIndex = 49;
            btnBandingkan.Text = "Bandingkan";
            btnBandingkan.UseVisualStyleBackColor = false;
            btnBandingkan.Click += btnBandingkan_Click;
            // 
            // lblBandingHarga
            // 
            lblBandingHarga.AutoSize = true;
            lblBandingHarga.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBandingHarga.Location = new Point(492, 65);
            lblBandingHarga.Margin = new Padding(2, 0, 2, 0);
            lblBandingHarga.Name = "lblBandingHarga";
            lblBandingHarga.Size = new Size(279, 30);
            lblBandingHarga.TabIndex = 48;
            lblBandingHarga.Text = "Bandingkan Harga Sampah!";
            // 
            // txtKuantitas
            // 
            txtKuantitas.Location = new Point(919, 167);
            txtKuantitas.Margin = new Padding(2);
            txtKuantitas.Name = "txtKuantitas";
            txtKuantitas.Size = new Size(109, 31);
            txtKuantitas.TabIndex = 46;
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Location = new Point(1047, 169);
            lblKg.Margin = new Padding(2, 0, 2, 0);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(32, 25);
            lblKg.TabIndex = 45;
            lblKg.Text = "kg";
            // 
            // lblBeratBanding
            // 
            lblBeratBanding.AutoSize = true;
            lblBeratBanding.Location = new Point(780, 167);
            lblBeratBanding.Margin = new Padding(2, 0, 2, 0);
            lblBeratBanding.Name = "lblBeratBanding";
            lblBeratBanding.Size = new Size(131, 25);
            lblBeratBanding.TabIndex = 44;
            lblBeratBanding.Text = "Berat Sampah :";
            // 
            // lblKategoriBanding
            // 
            lblKategoriBanding.AutoSize = true;
            lblKategoriBanding.Location = new Point(416, 167);
            lblKategoriBanding.Margin = new Padding(2, 0, 2, 0);
            lblKategoriBanding.Name = "lblKategoriBanding";
            lblKategoriBanding.Size = new Size(87, 25);
            lblKategoriBanding.TabIndex = 43;
            lblKategoriBanding.Text = "Kategori :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 42;
            // 
            // dgvBandingHarga
            // 
            dgvBandingHarga.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvBandingHarga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBandingHarga.Location = new Point(84, 380);
            dgvBandingHarga.Name = "dgvBandingHarga";
            dgvBandingHarga.RowHeadersWidth = 62;
            dgvBandingHarga.Size = new Size(1037, 187);
            dgvBandingHarga.TabIndex = 52;
            dgvBandingHarga.CellContentClick += dgvBandingHarga_CellContentClick;
            // 
            // lblAplikasiBanding
            // 
            lblAplikasiBanding.AutoSize = true;
            lblAplikasiBanding.Location = new Point(84, 167);
            lblAplikasiBanding.Margin = new Padding(2, 0, 2, 0);
            lblAplikasiBanding.Name = "lblAplikasiBanding";
            lblAplikasiBanding.Size = new Size(82, 25);
            lblAplikasiBanding.TabIndex = 54;
            lblAplikasiBanding.Text = "Aplikasi :";
            // 
            // clbAplikasi
            // 
            clbAplikasi.FormattingEnabled = true;
            clbAplikasi.Location = new Point(171, 167);
            clbAplikasi.Name = "clbAplikasi";
            clbAplikasi.Size = new Size(187, 144);
            clbAplikasi.TabIndex = 55;
            clbAplikasi.SelectedIndexChanged += clbAplikasi_SelectedIndexChanged;
            // 
            // clbKategori
            // 
            clbKategori.FormattingEnabled = true;
            clbKategori.Location = new Point(507, 167);
            clbKategori.Name = "clbKategori";
            clbKategori.Size = new Size(187, 144);
            clbKategori.TabIndex = 56;
            clbKategori.SelectedIndexChanged += clbKategori_SelectedIndexChanged;
            // 
            // FormBandingHarga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1195, 683);
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
            Name = "FormBandingHarga";
            Text = "FormBandingHarga";
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