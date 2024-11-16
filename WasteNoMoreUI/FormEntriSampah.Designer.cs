namespace WasteNoMoreUI
{
    partial class FormEntriSampah
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
            lblJudul = new Label();
            cmbKategori = new ComboBox();
            txtBerat = new TextBox();
            lblKg = new Label();
            lblBerat = new Label();
            lblKategori = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(366, 127);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(490, 37);
            lblJudul.TabIndex = 26;
            lblJudul.Text = "Masukkan Data Sampah Terbaru Anda!";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(538, 231);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(242, 40);
            cmbKategori.TabIndex = 24;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // txtBerat
            // 
            txtBerat.Location = new Point(538, 304);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(141, 39);
            txtBerat.TabIndex = 23;
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Location = new Point(704, 307);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(40, 32);
            lblKg.TabIndex = 22;
            lblKg.Text = "kg";
            // 
            // lblBerat
            // 
            lblBerat.AutoSize = true;
            lblBerat.Location = new Point(357, 304);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(174, 32);
            lblBerat.TabIndex = 21;
            lblBerat.Text = "Berat Sampah :";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(416, 231);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(115, 32);
            lblKategori.TabIndex = 20;
            lblKategori.Text = "Kategori :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 127);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(408, 431);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(643, 431);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormEntriSampah
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1211, 681);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblJudul);
            Controls.Add(cmbKategori);
            Controls.Add(txtBerat);
            Controls.Add(lblKg);
            Controls.Add(lblBerat);
            Controls.Add(lblKategori);
            Controls.Add(label1);
            Name = "FormEntriSampah";
            Text = "FormEntriSampah";
            Load += FormEntriSampah_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblJudul;
        private ComboBox cmbKategori;
        private TextBox txtBerat;
        private Label lblKg;
        private Label lblBerat;
        private Label lblKategori;
        private Label label1;
        private Button btnCancel;
        private Button btnAdd;
    }
}