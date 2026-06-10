using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRFinalDecision : Form
    {
        private int _selectedApplicationID = 0;
        private int _selectedApplicantID = 0;

        public FormHRFinalDecision()
        {
            InitializeComponent();
        }

        private void FormHRFinalDecision_Load(object sender, EventArgs e)
        {
            LoadApplicants();

            dgvApplicants.SelectionChanged += (s, ev) =>
            {
                if (dgvApplicants.SelectedRows.Count > 0)
                    PopulateFromRow(dgvApplicants.SelectedRows[0]);
            };
        }

        // ── LOAD applicants with status 'For Final Review' ────────────
        private void LoadApplicants(string search = "")
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT
                            app.ApplicationID,
                            app.ApplicantID,
                            CONCAT(a.FirstName, ' ', a.LastName)  AS ApplicantName,
                            jv.JobTitle                           AS Position,
                            a.ContactNumber,
                            aa.Email,
                            ie.Score,
                            ie.Result                             AS InterviewResult,
                            ie.Remarks                            AS InterviewRemarks
                        FROM Applications app
                        INNER JOIN Applicants a         ON app.ApplicantID        = a.ApplicantID
                        INNER JOIN ApplicantAccounts aa ON a.ApplicantAccountID   = aa.ApplicantAccountID
                        INNER JOIN JobVacancies jv      ON app.JobVacancyID       = jv.JobVacancyID
                        LEFT JOIN InterviewSchedules isch ON isch.ApplicationID   = app.ApplicationID
                            AND isch.Status = 'Completed'
                        LEFT JOIN InterviewEvaluations ie ON ie.InterviewScheduleID = isch.InterviewScheduleID
                        WHERE app.CurrentStatus = 'For Final Review'";

                    if (!string.IsNullOrEmpty(search))
                        query += " AND (a.FirstName LIKE @Search OR a.LastName LIKE @Search)";

                    query += " ORDER BY app.ApplicationDate DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(search))
                        cmd.Parameters.AddWithValue("@Search", $"%{search}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvApplicants.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvApplicants.Rows.Add(
                            row["ApplicationID"],
                            row["ApplicantName"],
                            row["Position"],
                            row["InterviewResult"].ToString() == "" ? "N/A" : row["InterviewResult"],
                            row["Score"].ToString() == "" ? "N/A" : row["Score"]
                        );

                        // Store hidden data in tag for later use
                        int idx = dgvApplicants.Rows.Count - 1;
                        dgvApplicants.Rows[idx].Tag = row;
                    }

                    // Auto-select first row
                    if (dgvApplicants.Rows.Count > 0)
                        dgvApplicants.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicants: " + ex.Message);
            }
        }

        private void PopulateFromRow(DataGridViewRow row)
        {
            if (row.Tag is DataRow data)
            {
                _selectedApplicationID = Convert.ToInt32(data["ApplicationID"]);
                _selectedApplicantID = Convert.ToInt32(data["ApplicantID"]);

                txtApplicantName.Text = data["ApplicantName"].ToString();
                txtPosition.Text = data["Position"].ToString();
                txtContactNumber.Text = data["ContactNumber"].ToString();
                txtEmail.Text = data["Email"].ToString();
                txtInterviewScore.Text = data["Score"].ToString() == "" ? "N/A" : data["Score"].ToString();
                txtInterviewResult.Text = data["InterviewResult"].ToString() == "" ? "N/A" : data["InterviewResult"].ToString();
                rtbInterviewRemarks.Text = data["InterviewRemarks"].ToString();
            }
        }

        // ── SEARCH ────────────────────────────────────────────────────
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadApplicants(txtSearch.Text.Trim());
        }

        // ── SAVE DECISION ─────────────────────────────────────────────
        private void btnSaveDecision_Click(object sender, EventArgs e)
        {
            if (_selectedApplicationID == 0)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (cmbDecision.SelectedItem == null)
            {
                MessageBox.Show("Please select a decision (Accepted or Rejected).");
                return;
            }

            string decision = cmbDecision.SelectedItem.ToString();
            string remarks = rtbRemarks.Text.Trim();

            string confirmMsg = $"Confirm decision: {decision} for {txtApplicantName.Text}?";
            if (MessageBox.Show(confirmMsg, "Confirm Decision",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        // Update application status
                        string updateQuery = @"
                            UPDATE Applications 
                            SET CurrentStatus = @Status 
                            WHERE ApplicationID = @AppID";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn, transaction);
                        updateCmd.Parameters.AddWithValue("@Status", decision);
                        updateCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        updateCmd.ExecuteNonQuery();

                        // Record in history
                        string historyQuery = @"
                            INSERT INTO ApplicationStatusHistory
                            (ApplicationID, StatusName, Remarks, ChangedBy)
                            VALUES (@AppID, @Status, @Remarks, @UserID)";

                        MySqlCommand histCmd = new MySqlCommand(historyQuery, conn, transaction);
                        histCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        histCmd.Parameters.AddWithValue("@Status", decision);
                        histCmd.Parameters.AddWithValue("@Remarks", string.IsNullOrEmpty(remarks)
                            ? $"Final decision: {decision}." : remarks);
                        histCmd.Parameters.AddWithValue("@UserID", Session.UserID);
                        histCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show($"Decision saved! Applicant has been marked as '{decision}'.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        LoadApplicants();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving decision: " + ex.Message);
            }
        }

        // ── CLEAR ─────────────────────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtApplicantName.Clear();
            txtPosition.Clear();
            txtContactNumber.Clear();
            txtEmail.Clear();
            txtInterviewScore.Clear();
            txtInterviewResult.Clear();
            rtbInterviewRemarks.Clear();
            rtbRemarks.Clear();
            cmbDecision.SelectedIndex = -1;
            txtSearch.Clear();
            _selectedApplicationID = 0;
            _selectedApplicantID = 0;
        }

        private void grpInterviewEvaluation_Enter(object sender, EventArgs e)
        {

        }
    }
}