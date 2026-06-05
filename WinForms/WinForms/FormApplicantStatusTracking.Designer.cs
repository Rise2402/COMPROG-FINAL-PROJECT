namespace WinForms
{
    partial class FormApplicantStatusTracking
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
            lblTitle = new Label();
            lblStatus = new Label();
            dgvApplications = new DataGridView();
            cboStatus = new ComboBox();
            btnUpdateStatus = new Button();
            btnViewHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(50, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Applicant Status Tracking";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(50, 247);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(96, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Select Status:";
            // 
            // dgvApplications
            // 
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Location = new Point(50, 42);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.Size = new Size(696, 188);
            dgvApplications.TabIndex = 2;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(145, 244);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 3;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(145, 354);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(151, 35);
            btnUpdateStatus.TabIndex = 4;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(556, 354);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(151, 35);
            btnViewHistory.TabIndex = 5;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            // 
            // FormApplicantStatusTracking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewHistory);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cboStatus);
            Controls.Add(dgvApplications);
            Controls.Add(lblStatus);
            Controls.Add(lblTitle);
            Name = "FormApplicantStatusTracking";
            Text = "FormApplicantStatusTracking";
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStatus;
        private DataGridView dgvApplications;
        private ComboBox cboStatus;
        private Button btnUpdateStatus;
        private Button btnViewHistory;
    }
}