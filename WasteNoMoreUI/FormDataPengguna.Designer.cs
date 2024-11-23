namespace WasteNoMoreUI
{
    partial class FormDataPengguna
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnChange = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblNama = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            tbNama = new TextBox();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Data Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 116);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 163);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(295, 207);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(166, 38);
            btnChange.TabIndex = 5;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 66);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 6;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 116);
            label7.Name = "label7";
            label7.Size = new Size(10, 15);
            label7.TabIndex = 7;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 163);
            label8.Name = "label8";
            label8.Size = new Size(10, 15);
            label8.TabIndex = 8;
            label8.Text = ":";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(156, 66);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(44, 15);
            lblNama.TabIndex = 10;
            lblNama.Text = "label10";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(156, 116);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(44, 15);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "label11";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(156, 163);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "label12";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(295, 58);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(171, 23);
            tbNama.TabIndex = 14;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(295, 155);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(171, 23);
            tbEmail.TabIndex = 16;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(295, 108);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(171, 23);
            tbUsername.TabIndex = 17;
            // 
            // FormDataPengguna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(498, 265);
            Controls.Add(tbUsername);
            Controls.Add(tbEmail);
            Controls.Add(tbNama);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblNama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnChange);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDataPengguna";
            Text = "FormDataPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChange;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblNama;
        private Label lblUsername;
        private Label lblEmail;
        private TextBox tbNama;
        private TextBox tbEmail;
        private TextBox tbUsername;
    }
}