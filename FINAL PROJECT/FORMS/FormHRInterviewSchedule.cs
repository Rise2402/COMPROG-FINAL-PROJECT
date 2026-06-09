using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRInterviewSchedule : Form
    {
        private int _selectedApplicationID = 0;

        public FormHRInterviewSchedule()
        {
            InitializeComponent();
        }

        private void FormHRInterviewSchedule_Load(object sender, EventArgs e)
        {
            LoadInterviewTypes();
            LoadApplications();

            // Set minimum date to today
            dtInterviewDate.MinDate = DateTime.Today;
            dtInterviewDate.Value = DateTime.Now.AddDays(1);

            // Load details on row selection
            dgvApplications.SelectionChanged += (s, ev) =>
            {
                if (dgvApplications.SelectedRows.Count > 0)
                    _selectedApplicationID = Convert.ToInt32(
                        dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            };
        }

        private void LoadInterviewTypes()
        {
            cboInterviewType.Items.Clear();
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT InterviewTypeID, InterviewTypeName FROM InterviewTypes";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cboInterviewType.Items.Add(new InterviewTypeItem(
                            Convert.ToInt32(reader["InterviewTypeID"]),
                            reader["InterviewTypeName"].ToString()
                        ));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading interview types: " + ex.Message);
            }
        }

        private void LoadApplications()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT
                            app.ApplicationID,
                            CONCAT(a.FirstName, ' ', a.LastName) AS ApplicantName,
                            jv.JobTitle AS Position,
                            app.CurrentStatus AS Status,
                            app.ApplicationDate
                        FROM Applications app
                        INNER JOIN Applicants a ON app.ApplicantID = a.ApplicantID
                        INNER JOIN JobVacancies jv ON app.JobVacancyID = jv.JobVacancyID
                        WHERE app.CurrentStatus = 'Shortlisted'
                        ORDER BY app.ApplicationDate DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvApplications.DataSource = dt;
                    dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvApplications.Columns["ApplicationID"] != null)
                        dgvApplications.Columns["ApplicationID"].Visible = false;

                    if (dgvApplications.Rows.Count > 0)
                    {
                        dgvApplications.Rows[0].Selected = true;
                        if (dgvApplications.Rows[0].Cells["ApplicationID"].Value != null)
                            _selectedApplicationID = Convert.ToInt32(dgvApplications.Rows[0].Cells["ApplicationID"].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message);
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (_selectedApplicationID == 0)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (cboInterviewType.SelectedItem == null)
            {
                MessageBox.Show("Please select an interview type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInterviewer.Text))
            {
                MessageBox.Show("Please enter the interviewer name.");
                return;
            }

            if (dtInterviewDate.Value < DateTime.Today)
            {
                MessageBox.Show("Interview date cannot be in the past.");
                return;
            }

            try
            {
                InterviewTypeItem selectedType = (InterviewTypeItem)cboInterviewType.SelectedItem;

                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        // Insert interview schedule
                        string scheduleQuery = @"
                            INSERT INTO InterviewSchedules
                            (ApplicationID, InterviewTypeID, InterviewDate, Interviewer, ModeOrLocation, Status)
                            VALUES (@AppID, @TypeID, @Date, @Interviewer, @Location, 'Scheduled')";

                        MySqlCommand schedCmd = new MySqlCommand(scheduleQuery, conn, transaction);
                        schedCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        schedCmd.Parameters.AddWithValue("@TypeID", selectedType.ID);
                        schedCmd.Parameters.AddWithValue("@Date", dtInterviewDate.Value);
                        schedCmd.Parameters.AddWithValue("@Interviewer", txtInterviewer.Text.Trim());
                        schedCmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim());
                        schedCmd.ExecuteNonQuery();

                        // Update application status to For Interview
                        string updateQuery = @"
                            UPDATE Applications 
                            SET CurrentStatus = 'For Interview' 
                            WHERE ApplicationID = @AppID";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn, transaction);
                        updateCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        updateCmd.ExecuteNonQuery();

                        // Record history
                        string historyQuery = @"
                            INSERT INTO ApplicationStatusHistory
                            (ApplicationID, StatusName, Remarks, ChangedBy)
                            VALUES (@AppID, 'For Interview', 'Interview scheduled.', @UserID)";

                        MySqlCommand histCmd = new MySqlCommand(historyQuery, conn, transaction);
                        histCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        histCmd.Parameters.AddWithValue("@UserID", Session.UserID);
                        histCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Interview scheduled successfully!");
                        txtInterviewer.Clear();
                        txtLocation.Clear();
                        cboInterviewType.SelectedIndex = -1;
                        dtInterviewDate.Value = DateTime.Now.AddDays(1);
                        _selectedApplicationID = 0;
                        LoadApplications();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scheduling interview: " + ex.Message);
            }
        }
    }

    // Helper class for ComboBox
    public class InterviewTypeItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public InterviewTypeItem(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString() => Name;
    }
}