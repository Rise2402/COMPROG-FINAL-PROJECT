namespace FINAL_PROJECT.FORMS
{
    partial class FormApplicantStatusTracking
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(38, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Applicant Status Tracking";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(40, 214);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Select Status:";
            // 
            // dgvApplications
            // 
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Location = new System.Drawing.Point(20, 47);
            this.dgvApplications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.RowHeadersWidth = 51;
            this.dgvApplications.Size = new System.Drawing.Size(559, 155);
            this.dgvApplications.TabIndex = 2;
            this.dgvApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplications_CellContentClick);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(112, 206);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(114, 21);
            this.cboStatus.TabIndex = 3;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(112, 245);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(113, 23);
            this.btnUpdateStatus.TabIndex = 4;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Location = new System.Drawing.Point(416, 245);
            this.btnViewHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(113, 23);
            this.btnViewHistory.TabIndex = 5;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(570, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(19, 18);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "X";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // FormApplicantStatusTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 292);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormApplicantStatusTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Status Tracking";
            this.Load += new System.EventHandler(this.FormApplicantStatusTracking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Label btnexit;
    }
}