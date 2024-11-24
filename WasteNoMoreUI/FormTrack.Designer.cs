namespace WasteNoMoreUI
{
    partial class FormTrack
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
            btnCancel = new Button();
            btnTrack = new Button();
            dtpAkhir = new DateTimePicker();
            label1 = new Label();
            dtpAwal = new DateTimePicker();
            cmbKategori = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDarkDark;
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(186, 197);
            btnCancel.Margin = new Padding(1, 1, 1, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 22);
            btnCancel.TabIndex = 50;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnTrack
            // 
            btnTrack.BackColor = SystemColors.HotTrack;
            btnTrack.ForeColor = SystemColors.ControlLightLight;
            btnTrack.Location = new Point(281, 197);
            btnTrack.Margin = new Padding(1, 1, 1, 1);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(80, 22);
            btnTrack.TabIndex = 49;
            btnTrack.Text = "Track";
            btnTrack.UseVisualStyleBackColor = false;
            btnTrack.Click += btnTrack_Click;
            // 
            // dtpAkhir
            // 
            dtpAkhir.Location = new Point(220, 143);
            dtpAkhir.Margin = new Padding(1, 1, 1, 1);
            dtpAkhir.Name = "dtpAkhir";
            dtpAkhir.Size = new Size(218, 23);
            dtpAkhir.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 146);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 47;
            label1.Text = "Akhir :";
            // 
            // dtpAwal
            // 
            dtpAwal.Location = new Point(220, 106);
            dtpAwal.Margin = new Padding(1, 1, 1, 1);
            dtpAwal.Name = "dtpAwal";
            dtpAwal.Size = new Size(218, 23);
            dtpAwal.TabIndex = 46;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(220, 71);
            cmbKategori.Margin = new Padding(1, 1, 1, 1);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(132, 23);
            cmbKategori.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 109);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 44;
            label3.Text = "Awal :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 71);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 43;
            label2.Text = "Kategori :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(230, 30);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 42;
            label6.Text = "Track Sampah";
            // 
            // FormTrack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(590, 276);
            Controls.Add(btnCancel);
            Controls.Add(btnTrack);
            Controls.Add(dtpAkhir);
            Controls.Add(label1);
            Controls.Add(dtpAwal);
            Controls.Add(cmbKategori);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Margin = new Padding(1, 1, 1, 1);
            Name = "FormTrack";
            Text = "FormTrack";
            FormClosed += FormTrack_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnTrack;
        private DateTimePicker dtpAkhir;
        private Label label1;
        private DateTimePicker dtpAwal;
        private ComboBox cmbKategori;
        private Label label3;
        private Label label2;
        private Label label6;
    }
}