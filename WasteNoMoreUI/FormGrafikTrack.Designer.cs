namespace WasteNoMoreUI
{
    partial class FormGrafikTrack
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnClose = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblGrafikTrack = new Label();
            lblTotalSampah = new Label();
            txtTotal = new TextBox();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Brown;
            btnClose.ForeColor = SystemColors.ControlLightLight;
            btnClose.Location = new Point(951, 591);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 36);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblGrafikTrack
            // 
            lblGrafikTrack.AutoSize = true;
            lblGrafikTrack.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrafikTrack.Location = new Point(504, 29);
            lblGrafikTrack.Margin = new Padding(2, 0, 2, 0);
            lblGrafikTrack.Name = "lblGrafikTrack";
            lblGrafikTrack.Size = new Size(137, 30);
            lblGrafikTrack.TabIndex = 72;
            lblGrafikTrack.Text = "Grafik Track";
            lblGrafikTrack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSampah
            // 
            lblTotalSampah.AutoSize = true;
            lblTotalSampah.Location = new Point(152, 597);
            lblTotalSampah.Margin = new Padding(2, 0, 2, 0);
            lblTotalSampah.Name = "lblTotalSampah";
            lblTotalSampah.Size = new Size(123, 25);
            lblTotalSampah.TabIndex = 73;
            lblTotalSampah.Text = "Total Sampah:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.GradientInactiveCaption;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Location = new Point(280, 597);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 24);
            txtTotal.TabIndex = 74;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // FormGrafikTrack
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1134, 648);
            Controls.Add(txtTotal);
            Controls.Add(lblTotalSampah);
            Controls.Add(lblGrafikTrack);
            Controls.Add(btnClose);
            Margin = new Padding(2);
            Name = "FormGrafikTrack";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGrafikTrack";
            Load += FormGrafikTrack_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblGrafikTrack;
        private Label lblTotalSampah;
        private TextBox txtTotal;
    }
}