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
            label5 = new Label();
            cmbKategori = new ComboBox();
            txtBerat = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(366, 127);
            label5.Name = "label5";
            label5.Size = new Size(490, 37);
            label5.TabIndex = 26;
            label5.Text = "Masukkan Data Sampah Terbaru Anda!";
            label5.Click += label5_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "Organik", "Anorganik", "B3", "Kertas", "Residu" });
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(704, 307);
            label4.Name = "label4";
            label4.Size = new Size(40, 32);
            label4.TabIndex = 22;
            label4.Text = "kg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 304);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 21;
            label3.Text = "Berat Sampah :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 231);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 20;
            label2.Text = "Kategori :";
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
            btnAdd.BackColor = SystemColors.HotTrack;
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
            Controls.Add(label5);
            Controls.Add(cmbKategori);
            Controls.Add(txtBerat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEntriSampah";
            Text = "FormEntriSampah";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private ComboBox cmbKategori;
        private TextBox txtBerat;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnAdd;
    }
}