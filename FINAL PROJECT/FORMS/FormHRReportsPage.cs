using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRReportsPage : Form
    {
        private DataTable _currentReportData = null;
        private string _currentReportTitle = "";
        private int _printRowIndex = 0;

        public FormHRReportsPage()
        {
            InitializeComponent();
        }

        private void FormHRReportsPage_Load(object sender, EventArgs e)
        {
            LoadApplicantList();
        }

        // ── REPORT 1: APPLICANT LIST ──────────────────────────────────
        private void LoadApplicantList()
        {
            _currentReportTitle = "Applicant List";
            lblReportTitle.Text = "📋 Applicant List";
            lblReportDesc.Text = "All registered applicants and their current application status.";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            ap.ApplicantID                              AS 'ID',
                            CONCAT(ap.FirstName, ' ', ap.LastName)     AS 'Full Name',
                            ap.Email                                    AS 'Email',
                            ap.Phone                                    AS 'Phone',
                            COALESCE(a.CurrentStatus, 'No Application') AS 'Status',
                            COALESCE(jv.JobTitle, '—')                 AS 'Position Applied',
                            COALESCE(CAST(a.ApplicationDate AS CHAR), '—') AS 'Date Applied'
                        FROM Applicants ap
                        LEFT JOIN Applications a  ON ap.ApplicantID = a.ApplicantID
                        LEFT JOIN JobVacancies jv ON a.JobVacancyID = jv.JobVacancyID
                        ORDER BY ap.LastName, ap.FirstName";

                    DisplayReport(FetchTable(sql, conn));
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ── REPORT 2: PENDING APPLICATIONS ───────────────────────────
        private void LoadPendingApplications()
        {
            _currentReportTitle = "Pending Applications";
            lblReportTitle.Text = "⏳ Pending Applications";
            lblReportDesc.Text = "Applications awaiting HR review.";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            a.ApplicationID                            AS 'App ID',
                            CONCAT(ap.FirstName, ' ', ap.LastName)    AS 'Applicant Name',
                            ap.Email                                   AS 'Email',
                            jv.JobTitle                                AS 'Position',
                            jv.Department                              AS 'Department',
                            a.CurrentStatus                            AS 'Status',
                            CAST(a.ApplicationDate AS CHAR)            AS 'Date Applied'
                        FROM Applications a
                        INNER JOIN Applicants   ap ON a.ApplicantID  = ap.ApplicantID
                        INNER JOIN JobVacancies jv ON a.JobVacancyID = jv.JobVacancyID
                        WHERE a.CurrentStatus IN ('Pending', 'Submitted', 'Under Review')
                        ORDER BY a.ApplicationDate ASC";

                    DisplayReport(FetchTable(sql, conn));
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ── REPORT 3: INTERVIEWS ──────────────────────────────────────
        private void LoadInterviews()
        {
            _currentReportTitle = "Interview Schedule Report";
            lblReportTitle.Text = "🗓️ Interview Schedule Report";
            lblReportDesc.Text = "All scheduled, completed, and cancelled interviews.";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            isch.InterviewScheduleID                   AS 'Interview ID',
                            CONCAT(ap.FirstName, ' ', ap.LastName)     AS 'Applicant Name',
                            jv.JobTitle                                AS 'Position',
                            CAST(isch.InterviewDate AS CHAR)           AS 'Date & Time',
                            isch.Interviewer                           AS 'Interviewer',
                            COALESCE(it.InterviewTypeName, '—')        AS 'Type',
                            COALESCE(isch.ModeOrLocation, '—')         AS 'Mode/Location',
                            isch.Status                                AS 'Status'
                        FROM InterviewSchedules isch
                        INNER JOIN Applications a  ON isch.ApplicationID = a.ApplicationID
                        INNER JOIN Applicants   ap ON a.ApplicantID      = ap.ApplicantID
                        INNER JOIN JobVacancies jv ON a.JobVacancyID     = jv.JobVacancyID
                        LEFT JOIN  InterviewTypes it ON isch.InterviewTypeID = it.InterviewTypeID
                        ORDER BY isch.InterviewDate DESC";

                    DisplayReport(FetchTable(sql, conn));
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ── REPORT 4: ACCEPTED / REJECTED ────────────────────────────
        private void LoadAcceptedRejected()
        {
            _currentReportTitle = "Accepted / Rejected Applicants";
            lblReportTitle.Text = "✅ Accepted / Rejected Applicants";
            lblReportDesc.Text = "Final hiring decisions for all processed applicants.";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            CONCAT(ap.FirstName, ' ', ap.LastName)     AS 'Applicant Name',
                            ap.Email                                   AS 'Email',
                            jv.JobTitle                                AS 'Position',
                            jv.Department                              AS 'Department',
                            a.CurrentStatus                            AS 'Final Status',
                            CAST(a.ApplicationDate AS CHAR)            AS 'Application Date'
                        FROM Applications a
                        INNER JOIN Applicants   ap ON a.ApplicantID  = ap.ApplicantID
                        INNER JOIN JobVacancies jv ON a.JobVacancyID = jv.JobVacancyID
                        WHERE a.CurrentStatus IN ('Accepted', 'Rejected', 'For Final Review')
                        ORDER BY a.ApplicationDate DESC";

                    DisplayReport(FetchTable(sql, conn));
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ── REPORT 5: MISSING REQUIREMENTS ───────────────────────────
        private void LoadMissingRequirements()
        {
            _currentReportTitle = "Missing Requirements Report";
            lblReportTitle.Text = "⚠️ Missing Requirements Report";
            lblReportDesc.Text = "Applicants with incomplete or missing document submissions.";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            CONCAT(ap.FirstName, ' ', ap.LastName)         AS 'Applicant Name',
                            ap.Email                                       AS 'Email',
                            jv.JobTitle                                    AS 'Position',
                            rt.RequirementName                             AS 'Missing Requirement',
                            COALESCE(ad.Status, 'Not Submitted')           AS 'Document Status',
                            a.CurrentStatus                                AS 'Application Status'
                        FROM Applications a
                        INNER JOIN Applicants       ap ON a.ApplicantID         = ap.ApplicantID
                        INNER JOIN JobVacancies     jv ON a.JobVacancyID        = jv.JobVacancyID
                        CROSS JOIN RequirementTypes rt
                        LEFT JOIN  ApplicantDocuments ad
                               ON  ad.ApplicantID       = ap.ApplicantID
                               AND ad.RequirementTypeID = rt.RequirementTypeID
                        WHERE (ad.Status IS NULL OR ad.Status = 'Missing')
                          AND a.CurrentStatus NOT IN ('Rejected', 'Withdrawn')
                        ORDER BY ap.LastName, rt.RequirementName";

                    DisplayReport(FetchTable(sql, conn));
                }
            }
            catch (Exception ex) { ShowDbError(ex); }
        }

        // ── HELPERS ───────────────────────────────────────────────────
        private DataTable FetchTable(string sql, MySqlConnection conn)
        {
            var adapter = new MySqlDataAdapter(sql, conn);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void DisplayReport(DataTable table)
        {
            _currentReportData = table;
            dgvReport.DataSource = table;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            lblRecordCount.Text = table.Rows.Count > 0
                ? $"Total Records: {table.Rows.Count}"
                : "No records found.";
        }

        private void SetActiveButton(System.Windows.Forms.Button active)
        {
            Button[] all = { btnApplicantList, btnPending, btnInterviews, btnAcceptedRejected, btnMissingReqs };
            foreach (var b in all)
            {
                b.BackColor = Color.FromArgb(230, 236, 245);
                b.ForeColor = Color.FromArgb(50, 70, 100);
                b.FlatAppearance.BorderSize = 0;
            }
            active.BackColor = Color.FromArgb(0, 74, 153);
            active.ForeColor = Color.White;
        }

        private void ShowDbError(Exception ex)
        {
            MessageBox.Show("Database error:\n" + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ── EXPORT CSV ────────────────────────────────────────────────
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_currentReportData == null || _currentReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Export Report as CSV";
                dlg.Filter = "CSV Files (*.csv)|*.csv";
                dlg.FileName = _currentReportTitle.Replace(" ", "_") + "_" + DateTime.Now.ToString("yyyyMMdd");

                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var sb = new StringBuilder();
                    var headers = new string[_currentReportData.Columns.Count];
                    for (int i = 0; i < _currentReportData.Columns.Count; i++)
                        headers[i] = "\"" + _currentReportData.Columns[i].ColumnName + "\"";
                    sb.AppendLine(string.Join(",", headers));

                    foreach (DataRow row in _currentReportData.Rows)
                    {
                        var fields = new string[_currentReportData.Columns.Count];
                        for (int i = 0; i < _currentReportData.Columns.Count; i++)
                            fields[i] = "\"" + row[i].ToString().Replace("\"", "\"\"") + "\"";
                        sb.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Report exported successfully!\n" + dlg.FileName, "Export Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed:\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── PRINT ─────────────────────────────────────────────────────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_currentReportData == null || _currentReportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to print.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _printRowIndex = 0;
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

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            if (_printRowIndex == 0)
            {
                var titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
                var dateFont = new Font("Segoe UI", 8);
                e.Graphics.DrawString(_currentReportTitle, titleFont, Brushes.DarkBlue,
                    e.MarginBounds.Left, e.MarginBounds.Top);
                e.Graphics.DrawString("Generated: " + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt"),
                    dateFont, Brushes.Gray, e.MarginBounds.Left, e.MarginBounds.Top + 22);
            }

            float yPos = e.MarginBounds.Top + (_printRowIndex == 0 ? 50 : 0);
            float rowHeight = 20f;
            var dataFont = new Font("Segoe UI", 7);
            var headFont = new Font("Segoe UI", 7, FontStyle.Bold);
            int colCount = _currentReportData.Columns.Count;
            float colWidth = (float)e.MarginBounds.Width / colCount;

            // Header row
            float xPos = e.MarginBounds.Left;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 74, 153)),
                e.MarginBounds.Left, yPos, e.MarginBounds.Width, rowHeight);
            for (int c = 0; c < colCount; c++)
            {
                e.Graphics.DrawString(_currentReportData.Columns[c].ColumnName, headFont, Brushes.White,
                    new RectangleF(xPos + 2, yPos + 3, colWidth - 4, rowHeight));
                xPos += colWidth;
            }
            yPos += rowHeight;

            // Data rows
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

                e.Graphics.FillRectangle(brush, e.MarginBounds.Left, yPos, e.MarginBounds.Width, rowHeight);
                for (int c = 0; c < colCount; c++)
                {
                    e.Graphics.DrawString(_currentReportData.Rows[_printRowIndex][c].ToString(),
                        dataFont, Brushes.Black,
                        new RectangleF(xPos + 2, yPos + 3, colWidth - 4, rowHeight));
                    xPos += colWidth;
                }

                yPos += rowHeight;
                _printRowIndex++;
            }

            _printRowIndex = 0;
            e.HasMorePages = false;
        }

        // ── BUTTON CLICKS ─────────────────────────────────────────────
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

        // ── BACK BUTTON ───────────────────────────────────────────────
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // Uncomment and replace with your dashboard form:
            // new FormHRDashboard().Show();
        }
    }
}