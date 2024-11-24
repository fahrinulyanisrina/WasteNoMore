namespace WasteNoMoreUI
{
    partial class FormPenggunaAdmin1
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
            dgvUsers = new DataGridView();
            label1 = new Label();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 52);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 82;
            dgvUsers.Size = new Size(463, 317);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 10);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "List Data Pengguna ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Brown;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(676, 390);
            btnBack.Margin = new Padding(2, 1, 2, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 22);
            btnBack.TabIndex = 85;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // FormPenggunaAdmin1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(738, 418);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(dgvUsers);
            Name = "FormPenggunaAdmin1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPenggunaAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Label label1;
        private Button btnDelete;
        private Button btnBack;
    }
}