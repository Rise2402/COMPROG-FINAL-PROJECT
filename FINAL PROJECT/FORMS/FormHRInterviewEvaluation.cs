using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRInterviewEvaluation : Form
    {
        private int _selectedScheduleID = 0;
        private int _selectedApplicationID = 0;

        public FormHRInterviewEvaluation()
        {
            InitializeComponent();
        }

        private void FormHRInterviewEvaluation_Load(object sender, EventArgs e)
        {
            cboResult.Items.Clear();
            cboResult.Items.Add("Pass");
            cboResult.Items.Add("Fail");

            LoadSchedules();

            dgvSchedules.SelectionChanged += (s, ev) =>
            {
                if (dgvSchedules.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvSchedules.SelectedRows[0];
                    if (row.Cells["InterviewScheduleID"].Value != null)
                        _selectedScheduleID = Convert.ToInt32(row.Cells["InterviewScheduleID"].Value);
                    if (row.Cells["ApplicationID"].Value != null)
                        _selectedApplicationID = Convert.ToInt32(row.Cells["ApplicationID"].Value);
                }
            };
        }

        private void LoadSchedules()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            isch.InterviewScheduleID,
                            isch.ApplicationID,
                            CONCAT(a.FirstName, ' ', a.LastName) AS ApplicantName,
                            jv.JobTitle AS Position,
                            it.InterviewTypeName AS InterviewType,
                            isch.InterviewDate,
                            isch.Interviewer,
                            isch.ModeOrLocation,
                            isch.Status
                        FROM InterviewSchedules isch
                        INNER JOIN Applications app ON isch.ApplicationID = app.ApplicationID
                        INNER JOIN Applicants a ON app.ApplicantID = a.ApplicantID
                        INNER JOIN JobVacancies jv ON app.JobVacancyID = jv.JobVacancyID
                        LEFT JOIN InterviewTypes it ON isch.InterviewTypeID = it.InterviewTypeID
                        WHERE isch.Status = 'Scheduled'
                        ORDER BY isch.InterviewDate ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSchedules.DataSource = dt;
                    dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvSchedules.Columns["InterviewScheduleID"] != null)
                        dgvSchedules.Columns["InterviewScheduleID"].Visible = false;
                    if (dgvSchedules.Columns["ApplicationID"] != null)
                        dgvSchedules.Columns["ApplicationID"].Visible = false;

                    // Auto-select first row
                    if (dgvSchedules.Rows.Count > 0)
                    {
                        dgvSchedules.Rows[0].Selected = true;
                        _selectedScheduleID = Convert.ToInt32(dgvSchedules.Rows[0].Cells["InterviewScheduleID"].Value);
                        _selectedApplicationID = Convert.ToInt32(dgvSchedules.Rows[0].Cells["ApplicationID"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedules: " + ex.Message);
            }
        }

        private void btnSaveEvaluation_Click(object sender, EventArgs e)
        {
            if (_selectedScheduleID == 0)
            {
                MessageBox.Show("Please select an interview schedule first.");
                return;
            }

            if (!decimal.TryParse(txtScore.Text.Trim(), out decimal score) || score < 0 || score > 100)
            {
                MessageBox.Show("Please enter a valid score between 0 and 100.");
                return;
            }

            if (cboResult.SelectedItem == null)
            {
                MessageBox.Show("Please select a result (Pass/Fail).");
                return;
            }

            string result = cboResult.SelectedItem.ToString();
            string remarks = txtRemarks.Text.Trim();
            string recommendation = txtRecommendation.Text.Trim();
            string newStatus = result == "Pass" ? "For Final Review" : "Rejected";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        // Save evaluation
                        string evalQuery = @"
                            INSERT INTO InterviewEvaluations
                            (InterviewScheduleID, Score, Remarks, Result, Recommendation, EvaluatedBy)
                            VALUES (@ScheduleID, @Score, @Remarks, @Result, @Recommendation, @EvaluatedBy)";

                        MySqlCommand evalCmd = new MySqlCommand(evalQuery, conn, transaction);
                        evalCmd.Parameters.AddWithValue("@ScheduleID", _selectedScheduleID);
                        evalCmd.Parameters.AddWithValue("@Score", score);
                        evalCmd.Parameters.AddWithValue("@Remarks", remarks);
                        evalCmd.Parameters.AddWithValue("@Result", result);
                        evalCmd.Parameters.AddWithValue("@Recommendation", recommendation);
                        evalCmd.Parameters.AddWithValue("@EvaluatedBy", Session.UserID);
                        evalCmd.ExecuteNonQuery();

                        // Update interview schedule status to Completed
                        string updateScheduleQuery = @"
                            UPDATE InterviewSchedules 
                            SET Status = 'Completed' 
                            WHERE InterviewScheduleID = @ID";

                        MySqlCommand schedCmd = new MySqlCommand(updateScheduleQuery, conn, transaction);
                        schedCmd.Parameters.AddWithValue("@ID", _selectedScheduleID);
                        schedCmd.ExecuteNonQuery();

                        // Update application status
                        string updateAppQuery = @"
                            UPDATE Applications 
                            SET CurrentStatus = @Status 
                            WHERE ApplicationID = @AppID";

                        MySqlCommand appCmd = new MySqlCommand(updateAppQuery, conn, transaction);
                        appCmd.Parameters.AddWithValue("@Status", newStatus);
                        appCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        appCmd.ExecuteNonQuery();

                        // Record history
                        string historyQuery = @"
                            INSERT INTO ApplicationStatusHistory
                            (ApplicationID, StatusName, Remarks, ChangedBy)
                            VALUES (@AppID, @Status, @Remarks, @UserID)";

                        MySqlCommand histCmd = new MySqlCommand(historyQuery, conn, transaction);
                        histCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        histCmd.Parameters.AddWithValue("@Status", newStatus);
                        histCmd.Parameters.AddWithValue("@Remarks", string.IsNullOrEmpty(remarks) ? "Interview evaluation completed." : remarks);
                        histCmd.Parameters.AddWithValue("@UserID", Session.UserID);
                        histCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show($"Evaluation saved! Applicant status updated to '{newStatus}'.");
                        txtScore.Clear();
                        txtRemarks.Clear();
                        txtRecommendation.Clear();
                        cboResult.SelectedIndex = -1;
                        _selectedScheduleID = 0;
                        _selectedApplicationID = 0;
                        LoadSchedules();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving evaluation: " + ex.Message);
            }
        }
    }
}