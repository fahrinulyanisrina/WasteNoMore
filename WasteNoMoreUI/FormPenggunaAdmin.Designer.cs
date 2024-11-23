namespace WasteNoMoreUI
{
    partial class FormPenggunaAdmin
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
            dgvUsers.Location = new Point(22, 111);
            dgvUsers.Margin = new Padding(6);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 82;
            dgvUsers.Size = new Size(860, 676);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 21);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 51);
            label1.TabIndex = 1;
            label1.Text = "List Data Pengguna ";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(22, 800);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 77);
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
            btnBack.Location = new Point(1256, 831);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 46);
            btnBack.TabIndex = 85;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // FormPenggunaAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1486, 960);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(dgvUsers);
            Margin = new Padding(6);
            Name = "FormPenggunaAdmin";
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