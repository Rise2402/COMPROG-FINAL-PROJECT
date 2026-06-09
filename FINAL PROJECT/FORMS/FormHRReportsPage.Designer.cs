namespace FINAL_PROJECT.FORMS
{
    partial class FormHRReportsPage
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.btnApplicantList = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnAcceptedRejected = new System.Windows.Forms.Button();
            this.btnMissingReqs = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlReportHeader = new System.Windows.Forms.Panel();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblReportDesc = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlReportHeader.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 54, 120);
            this.pnlHeader.Controls.Add(this.lblPageSubtitle);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
            this.pnlHeader.TabIndex = 0;

            // lblPageTitle
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(220, 8);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "HR Reports";

            // lblPageSubtitle
            this.lblPageSubtitle.AutoSize = true;
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 200, 255);
            this.lblPageSubtitle.Location = new System.Drawing.Point(222, 42);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Generate and export recruitment reports";

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(22, 45, 85);
            this.pnlSidebar.Controls.Add(this.btnBack);
            this.pnlSidebar.Controls.Add(this.btnMissingReqs);
            this.pnlSidebar.Controls.Add(this.btnAcceptedRejected);
            this.pnlSidebar.Controls.Add(this.btnInterviews);
            this.pnlSidebar.Controls.Add(this.btnPending);
            this.pnlSidebar.Controls.Add(this.btnApplicantList);
            this.pnlSidebar.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 70);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(210, 630);
            this.pnlSidebar.TabIndex = 1;

            // lblSidebarTitle
            this.lblSidebarTitle.AutoSize = true;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(120, 160, 220);
            this.lblSidebarTitle.Location = new System.Drawing.Point(15, 20);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "REPORT TYPE";

            // btnApplicantList
            this.btnApplicantList.BackColor = System.Drawing.Color.FromArgb(230, 236, 245);
            this.btnApplicantList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicantList.FlatAppearance.BorderSize = 0;
            this.btnApplicantList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 215, 240);
            this.btnApplicantList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicantList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApplicantList.ForeColor = System.Drawing.Color.FromArgb(50, 70, 100);
            this.btnApplicantList.Location = new System.Drawing.Point(0, 45);
            this.btnApplicantList.Name = "btnApplicantList";
            this.btnApplicantList.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnApplicantList.Size = new System.Drawing.Size(210, 48);
            this.btnApplicantList.TabIndex = 1;
            this.btnApplicantList.Text = "👥  Applicant List";
            this.btnApplicantList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicantList.UseVisualStyleBackColor = false;
            this.btnApplicantList.Click += new System.EventHandler(this.btnApplicantList_Click);

            // btnPending
            this.btnPending.BackColor = System.Drawing.Color.FromArgb(230, 236, 245);
            this.btnPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPending.FlatAppearance.BorderSize = 0;
            this.btnPending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 215, 240);
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPending.ForeColor = System.Drawing.Color.FromArgb(50, 70, 100);
            this.btnPending.Location = new System.Drawing.Point(0, 93);
            this.btnPending.Name = "btnPending";
            this.btnPending.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPending.Size = new System.Drawing.Size(210, 48);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "⏳  Pending Applications";
            this.btnPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPending.UseVisualStyleBackColor = false;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);

            // btnInterviews
            this.btnInterviews.BackColor = System.Drawing.Color.FromArgb(230, 236, 245);
            this.btnInterviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterviews.FlatAppearance.BorderSize = 0;
            this.btnInterviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 215, 240);
            this.btnInterviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterviews.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInterviews.ForeColor = System.Drawing.Color.FromArgb(50, 70, 100);
            this.btnInterviews.Location = new System.Drawing.Point(0, 141);
            this.btnInterviews.Name = "btnInterviews";
            this.btnInterviews.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInterviews.Size = new System.Drawing.Size(210, 48);
            this.btnInterviews.TabIndex = 3;
            this.btnInterviews.Text = "🗓️  Interviews";
            this.btnInterviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInterviews.UseVisualStyleBackColor = false;
            this.btnInterviews.Click += new System.EventHandler(this.btnInterviews_Click);

            // btnAcceptedRejected
            this.btnAcceptedRejected.BackColor = System.Drawing.Color.FromArgb(230, 236, 245);
            this.btnAcceptedRejected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptedRejected.FlatAppearance.BorderSize = 0;
            this.btnAcceptedRejected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 215, 240);
            this.btnAcceptedRejected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptedRejected.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAcceptedRejected.ForeColor = System.Drawing.Color.FromArgb(50, 70, 100);
            this.btnAcceptedRejected.Location = new System.Drawing.Point(0, 189);
            this.btnAcceptedRejected.Name = "btnAcceptedRejected";
            this.btnAcceptedRejected.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAcceptedRejected.Size = new System.Drawing.Size(210, 48);
            this.btnAcceptedRejected.TabIndex = 4;
            this.btnAcceptedRejected.Text = "✅  Accepted / Rejected";
            this.btnAcceptedRejected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceptedRejected.UseVisualStyleBackColor = false;
            this.btnAcceptedRejected.Click += new System.EventHandler(this.btnAcceptedRejected_Click);

            // btnMissingReqs
            this.btnMissingReqs.BackColor = System.Drawing.Color.FromArgb(230, 236, 245);
            this.btnMissingReqs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMissingReqs.FlatAppearance.BorderSize = 0;
            this.btnMissingReqs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(200, 215, 240);
            this.btnMissingReqs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMissingReqs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMissingReqs.ForeColor = System.Drawing.Color.FromArgb(50, 70, 100);
            this.btnMissingReqs.Location = new System.Drawing.Point(0, 237);
            this.btnMissingReqs.Name = "btnMissingReqs";
            this.btnMissingReqs.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMissingReqs.Size = new System.Drawing.Size(210, 48);
            this.btnMissingReqs.TabIndex = 5;
            this.btnMissingReqs.Text = "⚠️  Missing Requirements";
            this.btnMissingReqs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMissingReqs.UseVisualStyleBackColor = false;
            this.btnMissingReqs.Click += new System.EventHandler(this.btnMissingReqs_Click);

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(10, 30, 70);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(160, 200, 255);
            this.btnBack.Location = new System.Drawing.Point(0, 560);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(210, 45);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // pnlContent
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.dgvReport);
            this.pnlContent.Controls.Add(this.pnlActions);
            this.pnlContent.Controls.Add(this.pnlReportHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(210, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(890, 630);
            this.pnlContent.TabIndex = 2;

            // pnlReportHeader
            this.pnlReportHeader.BackColor = System.Drawing.Color.White;
            this.pnlReportHeader.Controls.Add(this.lblReportTitle);
            this.pnlReportHeader.Controls.Add(this.lblReportDesc);
            this.pnlReportHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlReportHeader.Name = "pnlReportHeader";
            this.pnlReportHeader.Size = new System.Drawing.Size(890, 80);
            this.pnlReportHeader.TabIndex = 0;

            // lblReportTitle
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(0, 54, 120);
            this.lblReportTitle.Location = new System.Drawing.Point(15, 10);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.TabIndex = 0;
            this.lblReportTitle.Text = "📋 Applicant List";

            // lblReportDesc
            this.lblReportDesc.AutoSize = true;
            this.lblReportDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReportDesc.ForeColor = System.Drawing.Color.FromArgb(110, 120, 140);
            this.lblReportDesc.Location = new System.Drawing.Point(15, 42);
            this.lblReportDesc.Name = "lblReportDesc";
            this.lblReportDesc.TabIndex = 1;
            this.lblReportDesc.Text = "";

            // pnlActions
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(235, 240, 248);
            this.pnlActions.Controls.Add(this.btnPrint);
            this.pnlActions.Controls.Add(this.btnExport);
            this.pnlActions.Controls.Add(this.lblRecordCount);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 80);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(890, 45);
            this.pnlActions.TabIndex = 1;

            // btnPrint
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(10, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "🖨️ Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // btnExport
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(118, 8);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 30);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "📥 Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            // lblRecordCount
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110);
            this.lblRecordCount.Location = new System.Drawing.Point(260, 13);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.TabIndex = 2;
            this.lblRecordCount.Text = "Total Records: 0";

            // dgvReport
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.dgvReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvReport.ColumnHeadersHeight = 35;
            this.dgvReport.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvReport.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.dgvReport.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(0, 40, 100);
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.Location = new System.Drawing.Point(0, 125);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowTemplate.Height = 28;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(890, 505);
            this.dgvReport.TabIndex = 2;

            // FormHRReportsPage
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormHRReportsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Reports";
            this.Load += new System.EventHandler(this.FormHRReportsPage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlReportHeader.ResumeLayout(false);
            this.pnlReportHeader.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Button btnApplicantList;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnAcceptedRejected;
        private System.Windows.Forms.Button btnMissingReqs;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlReportHeader;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblReportDesc;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}