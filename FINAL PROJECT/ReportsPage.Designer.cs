namespace HRreports 
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();

            // ── Controls ─────────────────────────────────────────
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

            this.SuspendLayout();

            // ════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════
            this.Text = "HR Reports";
            this.Size = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Load += new System.EventHandler(this.ReportsPage_Load);

            // ════════════════════════════════════════════════════
            //  HEADER
            // ════════════════════════════════════════════════════
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 54, 120);
            this.pnlHeader.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblPageTitle.Text = "HR Reports";
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.Location = new System.Drawing.Point(220, 8);
            this.lblPageTitle.AutoSize = true;

            this.lblPageSubtitle.Text = "Generate and export recruitment reports";
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 200, 255);
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSubtitle.Location = new System.Drawing.Point(222, 42);
            this.lblPageSubtitle.AutoSize = true;

            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblPageSubtitle);

            // ════════════════════════════════════════════════════
            //  SIDEBAR
            // ════════════════════════════════════════════════════
            this.pnlSidebar.Location = new System.Drawing.Point(0, 70);
            this.pnlSidebar.Size = new System.Drawing.Size(210, 630);
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(22, 45, 85);
            this.pnlSidebar.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            this.lblSidebarTitle.Text = "REPORT TYPE";
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(120, 160, 220);
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.Location = new System.Drawing.Point(15, 20);
            this.lblSidebarTitle.AutoSize = true;

            // Helper to create sidebar buttons
            System.Windows.Forms.Button MakeSidebarBtn(string text, int y)
            {
                var btn = new System.Windows.Forms.Button();
                btn.Text = text;
                btn.Location = new System.Drawing.Point(0, y);
                btn.Size = new System.Drawing.Size(210, 48);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.BackColor = System.Drawing.Color.FromArgb(230, 236, 245);
                btn.ForeColor = System.Drawing.Color.FromArgb(50, 70, 100);
                btn.Font = new System.Drawing.Font("Segoe UI", 9F);
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor =
                    System.Drawing.Color.FromArgb(200, 215, 240);
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                return btn;
            }

            this.btnApplicantList = MakeSidebarBtn("👥  Applicant List", 45);
            this.btnPending = MakeSidebarBtn("⏳  Pending Applications", 93);
            this.btnInterviews = MakeSidebarBtn("🗓️  Interviews", 141);
            this.btnAcceptedRejected = MakeSidebarBtn("✅  Accepted / Rejected", 189);
            this.btnMissingReqs = MakeSidebarBtn("⚠️  Missing Requirements", 237);

            this.btnApplicantList.Click += new System.EventHandler(this.btnApplicantList_Click);
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            this.btnInterviews.Click += new System.EventHandler(this.btnInterviews_Click);
            this.btnAcceptedRejected.Click += new System.EventHandler(this.btnAcceptedRejected_Click);
            this.btnMissingReqs.Click += new System.EventHandler(this.btnMissingReqs_Click);

            // BACK button at bottom of sidebar
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.Location = new System.Drawing.Point(0, 560);
            this.btnBack.Size = new System.Drawing.Size(210, 45);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(10, 30, 70);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(160, 200, 255);
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.pnlSidebar.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebar.Controls.Add(this.btnApplicantList);
            this.pnlSidebar.Controls.Add(this.btnPending);
            this.pnlSidebar.Controls.Add(this.btnInterviews);
            this.pnlSidebar.Controls.Add(this.btnAcceptedRejected);
            this.pnlSidebar.Controls.Add(this.btnMissingReqs);
            this.pnlSidebar.Controls.Add(this.btnBack);

            // ════════════════════════════════════════════════════
            //  CONTENT PANEL (right side)
            // ════════════════════════════════════════════════════
            this.pnlContent.Location = new System.Drawing.Point(210, 70);
            this.pnlContent.Size = new System.Drawing.Size(890, 630);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlContent.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // ── Report Header strip ───────────────────────────
            this.pnlReportHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlReportHeader.Size = new System.Drawing.Size(890, 80);
            this.pnlReportHeader.BackColor = System.Drawing.Color.White;
            this.pnlReportHeader.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblReportTitle.Text = "📋 Applicant List";
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(0, 54, 120);
            this.lblReportTitle.Location = new System.Drawing.Point(15, 10);
            this.lblReportTitle.AutoSize = true;

            this.lblReportDesc.Text = "";
            this.lblReportDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReportDesc.ForeColor = System.Drawing.Color.FromArgb(110, 120, 140);
            this.lblReportDesc.Location = new System.Drawing.Point(15, 42);
            this.lblReportDesc.AutoSize = true;

            this.pnlReportHeader.Controls.Add(this.lblReportTitle);
            this.pnlReportHeader.Controls.Add(this.lblReportDesc);

            // ── Actions bar (Print / Export / Count) ─────────
            this.pnlActions.Location = new System.Drawing.Point(0, 80);
            this.pnlActions.Size = new System.Drawing.Size(890, 45);
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(235, 240, 248);
            this.pnlActions.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.btnPrint.Text = "🖨️ Print";
            this.btnPrint.Location = new System.Drawing.Point(10, 8);
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            this.btnExport.Text = "📥 Export CSV";
            this.btnExport.Location = new System.Drawing.Point(118, 8);
            this.btnExport.Size = new System.Drawing.Size(120, 30);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            this.lblRecordCount.Text = "Total Records: 0";
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110);
            this.lblRecordCount.Location = new System.Drawing.Point(260, 13);
            this.lblRecordCount.AutoSize = true;

            this.pnlActions.Controls.Add(this.btnPrint);
            this.pnlActions.Controls.Add(this.btnExport);
            this.pnlActions.Controls.Add(this.lblRecordCount);

            // ── DataGridView ──────────────────────────────────
            this.dgvReport.Location = new System.Drawing.Point(0, 125);
            this.dgvReport.Size = new System.Drawing.Size(890, 505);
            this.dgvReport.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ReadOnly = true;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;

            // Style the grid header
            this.dgvReport.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(0, 74, 153);
            this.dgvReport.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvReport.ColumnHeadersDefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvReport.ColumnHeadersHeight = 35;
            this.dgvReport.EnableHeadersVisualStyles = false;

            // Alternating row colors
            this.dgvReport.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(240, 245, 255);
            this.dgvReport.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(180, 210, 255);
            this.dgvReport.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(0, 40, 100);
            this.dgvReport.DefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvReport.RowTemplate.Height = 28;

            this.pnlContent.Controls.Add(this.pnlReportHeader);
            this.pnlContent.Controls.Add(this.pnlActions);
            this.pnlContent.Controls.Add(this.dgvReport);

            // ════════════════════════════════════════════════════
            //  ADD ALL TO FORM
            // ════════════════════════════════════════════════════
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlContent);

            this.ResumeLayout(false);

            // Set first button as active by default
            SetActiveButton(this.btnApplicantList);
        }

        // ── Control Declarations ──────────────────────────────
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
