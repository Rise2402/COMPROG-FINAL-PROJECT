using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRreports
{
    public partial class Form1 : Form
    {
        // --------------------------------------------------------
        //  CONNECTION STRING
        //  Replace with shared DB connection string or helper class.
        //  Example: private readonly string _connString = DBHelper.ConnString;
        // --------------------------------------------------------
        private readonly string _connString =
            "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=;";

        // Holds the currently displayed report data for printing
        private DataTable _currentReportData = null;
        private string _currentReportTitle = "";

        // ============================================================
        //  CONSTRUCTOR
        //  Pass HR user's ID/name if needed for audit.
        //  Example: new Form1(hrUserId).Show();
        // ============================================================
        public Form1()
        {
            InitializeComponent();
        }

        // ============================================================
        //  FORM LOAD
        // ============================================================
        private void ReportsPage_Load(object sender, EventArgs e)
        {
            // Load applicant list by default
            LoadApplicantList();
        }

        // ============================================================
        //  REPORT 1: APPLICANT LIST
        //  Shows all applicants with their current application status
        // ============================================================
        private void LoadApplicantList()
        {
            _currentReportTitle = "Applicant List";
            lblReportTitle.Text = "📋 Applicant List";
            lblReportDesc.Text = "All registered applicants and their current application status.";

            try
            {
                using (var conn = new MySqlConnection(_connString))
                {
                    conn.Open();

                    // ------------------------------------------------
                    //  Verify column name, match Applicants, Applications, JobVacancies
                    //  tables exactly.
                    // ------------------------------------------------
                    string sql = @"
                        SELECT
                            ap.ApplicantId       AS 'ID',
                            CONCAT(ap.FirstName, ' ', ap.LastName) AS 'Full Name',
                            ap.Email             AS 'Email',
                            ap.Phone             AS 'Phone',
                            COALESCE(a.Status, 'No Application') AS 'Status',
                            COALESCE(jv.JobTitle, '—')           AS 'Position Applied',
                            COALESCE(CAST(a.DateApplied AS CHAR), '—') AS 'Date Applied'
                        FROM Applicants ap
                        LEFT JOIN Applications a  ON ap.ApplicantId = a.ApplicantId
                        LEFT JOIN JobVacancies jv ON a.JobVacancyId = jv.JobVacancyId
                        ORDER BY ap.LastName, ap.FirstName";

                    var adapter = new MySqlDataAdapter(sql, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    DisplayReport(table);
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ============================================================
        //  REPORT 2: PENDING APPLICATIONS
        //  Shows applications in Draft or Submitted status
        // ============================================================
        private void LoadPendingApplications()
        {
            _currentReportTitle = "Pending Applications";
            lblReportTitle.Text = "⏳ Pending Applications";
            lblReportDesc.Text = "Applications in Draft or Submitted status awaiting HR review.";

            try
            {
                using (var conn = new MySqlConnection(_connString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            a.ApplicationId      AS 'App ID',
                            CONCAT(ap.FirstName, ' ', ap.LastName) AS 'Applicant Name',
                            ap.Email             AS 'Email',
                            jv.JobTitle          AS 'Position',
                            jv.Department        AS 'Department',
                            a.Status             AS 'Status',
                            CAST(a.DateApplied AS CHAR) AS 'Date Applied'
                        FROM Applications a
                        INNER JOIN Applicants   ap ON a.ApplicantId  = ap.ApplicantId
                        INNER JOIN JobVacancies jv ON a.JobVacancyId = jv.JobVacancyId
                        WHERE a.Status IN ('Draft', 'Submitted')
                        ORDER BY a.DateApplied ASC";

                    var adapter = new MySqlDataAdapter(sql, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    DisplayReport(table);
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ============================================================
        //  REPORT 3: INTERVIEWS
        //  Shows all scheduled, completed, and cancelled interviews
        // ============================================================
        private void LoadInterviews()
        {
            _currentReportTitle = "Interview Schedule Report";
            lblReportTitle.Text = "🗓️ Interview Schedule Report";
            lblReportDesc.Text = "All scheduled, completed, and cancelled interviews.";

            try
            {
                using (var conn = new MySqlConnection(_connString))
                {
                    conn.Open();

                    // ------------------------------------------------
                    //  TODO (Leader / DB Person): Verify column names
                    //  match your InterviewSchedules table.
                    //  Expected columns:
                    //    InterviewId, ApplicationId, InterviewDate,
                    //    InterviewTime, Interviewer, Mode, Location, Status
                    // ------------------------------------------------
                    string sql = @"
                        SELECT
                            i.InterviewId        AS 'Interview ID',
                            CONCAT(ap.FirstName, ' ', ap.LastName) AS 'Applicant Name',
                            jv.JobTitle          AS 'Position',
                            CAST(i.InterviewDate AS CHAR) AS 'Date',
                            CAST(i.InterviewTime AS CHAR) AS 'Time',
                            i.Interviewer        AS 'Interviewer',
                            i.Mode               AS 'Mode',
                            COALESCE(i.Location, '—') AS 'Location',
                            i.Status             AS 'Status'
                        FROM InterviewSchedules i
                        INNER JOIN Applications a  ON i.ApplicationId = a.ApplicationId
                        INNER JOIN Applicants   ap ON a.ApplicantId   = ap.ApplicantId
                        INNER JOIN JobVacancies jv ON a.JobVacancyId  = jv.JobVacancyId
                        ORDER BY i.InterviewDate DESC, i.InterviewTime DESC";

                    var adapter = new MySqlDataAdapter(sql, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    DisplayReport(table);
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ============================================================
        //  REPORT 4: ACCEPTED / REJECTED APPLICANTS
        //  Shows final hiring decisions
        // ============================================================
        private void LoadAcceptedRejected()
        {
            _currentReportTitle = "Accepted / Rejected Applicants";
            lblReportTitle.Text = "✅ Accepted / Rejected Applicants";
            lblReportDesc.Text = "Final hiring decisions for all processed applicants.";

            try
            {
                using (var conn = new MySqlConnection(_connString))
                {
                    conn.Open();

                    // ------------------------------------------------
                    //  TODO (Leader / DB Person): Verify column names
                    //  match your HiringDecisions table.
                    //  Expected columns:
                    //    HiringDecisionId, ApplicationId, Decision,
                    //    Remarks, DecidedBy, DecisionDate
                    // ------------------------------------------------
                    string sql = @"
                        SELECT
                            CONCAT(ap.FirstName, ' ', ap.LastName) AS 'Applicant Name',
                            ap.Email             AS 'Email',
                            jv.JobTitle          AS 'Position',
                            jv.Department        AS 'Department',
                            a.Status             AS 'Final Status',
                            COALESCE(hd.Remarks, '—') AS 'Remarks',
                            COALESCE(hd.DecidedBy, '—') AS 'Decided By',
                            COALESCE(CAST(hd.DecisionDate AS CHAR), '—') AS 'Decision Date'
                        FROM Applications a
                        INNER JOIN Applicants   ap ON a.ApplicantId  = ap.ApplicantId
                        INNER JOIN JobVacancies jv ON a.JobVacancyId = jv.JobVacancyId
                        LEFT JOIN  HiringDecisions hd ON a.ApplicationId = hd.ApplicationId
                        WHERE a.Status IN ('Accepted', 'Rejected')
                        ORDER BY hd.DecisionDate DESC";

                    var adapter = new MySqlDataAdapter(sql, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    DisplayReport(table);
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ============================================================
        //  REPORT 5: MISSING REQUIREMENTS
        //  Shows applicants with incomplete document submissions
        // ============================================================
        private void LoadMissingRequirements()
        {
            _currentReportTitle = "Missing Requirements Report";
            lblReportTitle.Text = "⚠️ Missing Requirements Report";
            lblReportDesc.Text = "Applicants with incomplete or missing document submissions.";

            try
            {
                using (var conn = new MySqlConnection(_connString))
                {
                    conn.Open();

                    // ------------------------------------------------
                    //  Verify column name, match ApplicantDocuments + RequirementTypes
                    //  tables.
                    //  Expected columns:
                    //    ApplicantDocuments: ApplicantId, RequirementTypeId, Status
                    //    RequirementTypes:   RequirementTypeId, RequirementName
                    // ------------------------------------------------
                    string sql = @"
                        SELECT
                            CONCAT(ap.FirstName, ' ', ap.LastName) AS 'Applicant Name',
                            ap.Email             AS 'Email',
                            jv.JobTitle          AS 'Position',
                            rt.RequirementName   AS 'Missing Requirement',
                            COALESCE(ad.Status, 'Not Submitted') AS 'Document Status',
                            a.Status             AS 'Application Status'
                        FROM Applications a
                        INNER JOIN Applicants      ap ON a.ApplicantId      = ap.ApplicantId
                        INNER JOIN JobVacancies    jv ON a.JobVacancyId     = jv.JobVacancyId
                        CROSS JOIN RequirementTypes rt
                        LEFT JOIN  ApplicantDocuments ad
                               ON  ad.ApplicantId        = ap.ApplicantId
                               AND ad.RequirementTypeId  = rt.RequirementTypeId
                        WHERE (ad.Status IS NULL OR ad.Status = 'Missing')
                          AND a.Status NOT IN ('Rejected', 'Withdrawn')
                        ORDER BY ap.LastName, rt.RequirementName";

                    var adapter = new MySqlDataAdapter(sql, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    DisplayReport(table);
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ============================================================
        //  DISPLAY REPORT IN DATAGRIDVIEW
        // ============================================================
        private void DisplayReport(DataTable table)
        {
            _currentReportData = table;
            dgvReport.DataSource = table;
            lblRecordCount.Text = $"Total Records: {table.Rows.Count}";

            // Style the grid
            dgvReport.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            if (table.Rows.Count == 0)
            {
                lblRecordCount.Text = "No records found.";
            }
        }

        // ============================================================
        //  EXPORT TO CSV
        // ============================================================
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_currentReportData == null || _currentReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Export Report as CSV";
                dlg.Filter = "CSV Files (*.csv)|*.csv";
                dlg.FileName = _currentReportTitle.Replace(" ", "_") +
                                 "_" + DateTime.Now.ToString("yyyyMMdd");

                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var sb = new StringBuilder();

                    // Header row
                    var headers = new string[_currentReportData.Columns.Count];
                    for (int i = 0; i < _currentReportData.Columns.Count; i++)
                        headers[i] = "\"" + _currentReportData.Columns[i].ColumnName + "\"";
                    sb.AppendLine(string.Join(",", headers));

                    // Data rows
                    foreach (DataRow row in _currentReportData.Rows)
                    {
                        var fields = new string[_currentReportData.Columns.Count];
                        for (int i = 0; i < _currentReportData.Columns.Count; i++)
                            fields[i] = "\"" + row[i].ToString().Replace("\"", "\"\"") + "\"";
                        sb.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);

                    MessageBox.Show(
                        "Report exported successfully!\n" + dlg.FileName,
                        "Export Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ============================================================
        //  PRINT REPORT
        // ============================================================
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_currentReportData == null || _currentReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to print.", "Print",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pd = new PrintDocument();
            pd.PrintPage += PrintPage;

            using (var preview = new PrintPreviewDialog())
            {
                preview.Document = pd;
                preview.Width = 1000;
                preview.Height = 700;
                preview.ShowDialog();
            }
        }

        // Tracks which row we're printing across pages
        private int _printRowIndex = 0;

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            if (_printRowIndex == 0)
            {
                // Print title and date
                var titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
                var dateFont = new Font("Segoe UI", 8);
                e.Graphics.DrawString(_currentReportTitle, titleFont,
                    Brushes.DarkBlue, e.MarginBounds.Left, e.MarginBounds.Top);
                e.Graphics.DrawString(
                    "Generated: " + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt"),
                    dateFont, Brushes.Gray,
                    e.MarginBounds.Left, e.MarginBounds.Top + 22);
            }

            float yPos = e.MarginBounds.Top + (_printRowIndex == 0 ? 50 : 0);
            float rowHeight = 20f;
            var dataFont = new Font("Segoe UI", 7);
            var headFont = new Font("Segoe UI", 7, FontStyle.Bold);

            int colCount = _currentReportData.Columns.Count;
            float colWidth = (float)e.MarginBounds.Width / colCount;

            // Print header row once per page
            float xPos = e.MarginBounds.Left;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 74, 153)),
                e.MarginBounds.Left, yPos, e.MarginBounds.Width, rowHeight);

            for (int c = 0; c < colCount; c++)
            {
                e.Graphics.DrawString(
                    _currentReportData.Columns[c].ColumnName,
                    headFont, Brushes.White,
                    new RectangleF(xPos + 2, yPos + 3, colWidth - 4, rowHeight));
                xPos += colWidth;
            }
            yPos += rowHeight;

            // Print data rows
            while (_printRowIndex < _currentReportData.Rows.Count)
            {
                if (yPos + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                xPos = e.MarginBounds.Left;
                var brush = _printRowIndex % 2 == 0
                    ? Brushes.White
                    : new SolidBrush(Color.FromArgb(240, 245, 255));

                e.Graphics.FillRectangle(brush,
                    e.MarginBounds.Left, yPos, e.MarginBounds.Width, rowHeight);

                for (int c = 0; c < colCount; c++)
                {
                    e.Graphics.DrawString(
                        _currentReportData.Rows[_printRowIndex][c].ToString(),
                        dataFont, Brushes.Black,
                        new RectangleF(xPos + 2, yPos + 3, colWidth - 4, rowHeight));
                    xPos += colWidth;
                }

                yPos += rowHeight;
                _printRowIndex++;
            }

            _printRowIndex = 0; // reset for next print
            e.HasMorePages = false;
        }

        // ============================================================
        //  REPORT BUTTON CLICKS
        // ============================================================
        private void btnApplicantList_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnApplicantList);
            LoadApplicantList();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPending);
            LoadPendingApplications();
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnInterviews);
            LoadInterviews();
        }

        private void btnAcceptedRejected_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAcceptedRejected);
            LoadAcceptedRejected();
        }

        private void btnMissingReqs_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnMissingReqs);
            LoadMissingRequirements();
        }

        // ============================================================
        //  BACK BUTTON
        //  Wire to HR Dashboard.
        //  Example: new HRDashboard(hrUserId).Show(); this.Close();
        // ============================================================
        private void btnBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "[TODO] Navigate back to HR Dashboard here.\n" +
                "Leader: connect this to your HRDashboard form.",
                "Navigation Placeholder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Uncomment when ready:
            // new HRDashboard().Show();
            // this.Close();
        }

        // ============================================================
        //  HELPER: HIGHLIGHT ACTIVE REPORT BUTTON
        // ============================================================
        private void SetActiveButton(System.Windows.Forms.Button active)
        {
            Button[] all = {
                btnApplicantList, btnPending, btnInterviews,
                btnAcceptedRejected, btnMissingReqs
            };

            foreach (var b in all)
            {
                b.BackColor = Color.FromArgb(230, 236, 245);
                b.ForeColor = Color.FromArgb(50, 70, 100);
                b.FlatAppearance.BorderSize = 0;
            }

            active.BackColor = Color.FromArgb(0, 74, 153);
            active.ForeColor = Color.White;
        }

        // ============================================================
        //  HELPER: SHOW DATABASE ERROR
        // ============================================================
        private void ShowDbError(Exception ex)
        {
            MessageBox.Show(
                "Database error:\n" + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}