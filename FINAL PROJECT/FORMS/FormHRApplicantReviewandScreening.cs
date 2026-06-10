using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRApplicantReviewandScreening : Form
    {
        private int _selectedApplicantID = 0;
        private int _selectedApplicationID = 0;

        public FormHRApplicantReviewandScreening()
        {
            InitializeComponent();
        }


        private void LoadApplicants(string search = "")
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            a.ApplicantID,
                            app.ApplicationID,
                            CONCAT(a.FirstName, ' ', a.LastName) AS Name,
                            jv.JobTitle AS Position,
                            aa.Email,
                            a.ContactNumber,
                            app.CurrentStatus AS Status
                        FROM Applicants a
                        INNER JOIN ApplicantAccounts aa ON a.ApplicantAccountID = aa.ApplicantAccountID
                        INNER JOIN Applications app ON a.ApplicantID = app.ApplicantID
                        INNER JOIN JobVacancies jv ON app.JobVacancyID = jv.JobVacancyID
                        WHERE app.CurrentStatus IN ('Submitted', 'Under Review', 'Shortlisted')";

                    if (!string.IsNullOrEmpty(search))
                        query += " AND (a.FirstName LIKE @Search OR a.LastName LIKE @Search)";

                    query += " ORDER BY app.ApplicationDate DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(search))
                        cmd.Parameters.AddWithValue("@Search", $"%{search}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvApplicants.DataSource = dt;

                    if (dgvApplicants.Columns["ApplicantID"] != null)
                        dgvApplicants.Columns["ApplicantID"].Visible = false;
                    if (dgvApplicants.Columns["ApplicationID"] != null)
                        dgvApplicants.Columns["ApplicationID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicants: " + ex.Message);
            }
        }

        private void LoadScreeningResults()
        {
            cmbResult.Items.Clear();
            cmbResult.Items.Add("Qualified");
            cmbResult.Items.Add("Not Qualified");
        }

        private void LoadDocuments(int applicantID)
        {
            lstDocuments.Items.Clear();
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT rt.RequirementName, ad.Status
                        FROM ApplicantDocuments ad
                        JOIN RequirementTypes rt ON ad.RequirementTypeID = rt.RequirementTypeID
                        WHERE ad.ApplicantID = @ApplicantID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string docName = reader["RequirementName"].ToString();
                        bool isSubmitted = reader["Status"].ToString() == "Submitted";
                        lstDocuments.Items.Add(docName, isSubmitted);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message);
            }
        }

        private void dgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvApplicants.Rows[e.RowIndex];

            _selectedApplicantID = Convert.ToInt32(row.Cells["ApplicantID"].Value);
            _selectedApplicationID = Convert.ToInt32(row.Cells["ApplicationID"].Value);

            txtApplicantName.Text = row.Cells["Name"].Value?.ToString();
            txtPosition.Text = row.Cells["Position"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString();
            txtStatus.Text = row.Cells["Status"].Value?.ToString();

            LoadDocuments(_selectedApplicantID);

            // Lock application for HR review
            LockApplicationForReview(_selectedApplicationID);
        }

        private void LockApplicationForReview(int applicationID)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Check current status
                    string checkQuery = "SELECT CurrentStatus, HRReviewStarted FROM Applications WHERE ApplicationID = @ID";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ID", applicationID);
                    MySqlDataReader reader = checkCmd.ExecuteReader();

                    string currentStatus = "";
                    bool hrStarted = false;

                    if (reader.Read())
                    {
                        currentStatus = reader["CurrentStatus"].ToString();
                        hrStarted = Convert.ToBoolean(reader["HRReviewStarted"]);
                    }
                    reader.Close();

                    // Only lock if Submitted and not yet reviewed
                    if (currentStatus == "Submitted" && !hrStarted)
                    {
                        string updateQuery = @"
                            UPDATE Applications 
                            SET CurrentStatus = 'Under Review', HRReviewStarted = TRUE 
                            WHERE ApplicationID = @ID";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@ID", applicationID);
                        updateCmd.ExecuteNonQuery();

                        // Record in history
                        string historyQuery = @"
                            INSERT INTO ApplicationStatusHistory 
                            (ApplicationID, StatusName, Remarks, ChangedBy)
                            VALUES (@AppID, 'Under Review', 'HR started reviewing application.', @UserID)";

                        MySqlCommand histCmd = new MySqlCommand(historyQuery, conn);
                        histCmd.Parameters.AddWithValue("@AppID", applicationID);
                        histCmd.Parameters.AddWithValue("@UserID", Session.UserID);
                        histCmd.ExecuteNonQuery();

                        txtStatus.Text = "Under Review";
                        MessageBox.Show("Application locked for review.");
                        LoadApplicants();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error locking application: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_selectedApplicationID == 0)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (cmbResult.SelectedItem == null)
            {
                MessageBox.Show("Please select a screening result.");
                return;
            }

            string result = cmbResult.SelectedItem.ToString();
            string remarks = rtbRemarks.Text.Trim();
            string newStatus = result == "Qualified" ? "Shortlisted" : "Rejected";

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        // Save screening result
                        string screeningQuery = @"
                            INSERT INTO ScreeningResults 
                            (ApplicationID, ScreenedBy, Result, Remarks)
                            VALUES (@AppID, @ScreenedBy, @Result, @Remarks)";

                        MySqlCommand screenCmd = new MySqlCommand(screeningQuery, conn, transaction);
                        screenCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        screenCmd.Parameters.AddWithValue("@ScreenedBy", Session.UserID);
                        screenCmd.Parameters.AddWithValue("@Result", result);
                        screenCmd.Parameters.AddWithValue("@Remarks", remarks);
                        screenCmd.ExecuteNonQuery();

                        // Update application status
                        string updateQuery = "UPDATE Applications SET CurrentStatus = @Status WHERE ApplicationID = @ID";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn, transaction);
                        updateCmd.Parameters.AddWithValue("@Status", newStatus);
                        updateCmd.Parameters.AddWithValue("@ID", _selectedApplicationID);
                        updateCmd.ExecuteNonQuery();

                        // Record history
                        string historyQuery = @"
                            INSERT INTO ApplicationStatusHistory 
                            (ApplicationID, StatusName, Remarks, ChangedBy)
                            VALUES (@AppID, @Status, @Remarks, @UserID)";

                        MySqlCommand histCmd = new MySqlCommand(historyQuery, conn, transaction);
                        histCmd.Parameters.AddWithValue("@AppID", _selectedApplicationID);
                        histCmd.Parameters.AddWithValue("@Status", newStatus);
                        histCmd.Parameters.AddWithValue("@Remarks", string.IsNullOrEmpty(remarks) ? "Screening completed." : remarks);
                        histCmd.Parameters.AddWithValue("@UserID", Session.UserID);
                        histCmd.ExecuteNonQuery();

                        transaction.Commit();

                        txtStatus.Text = newStatus;
                        MessageBox.Show("Screening saved successfully!");
                        rtbRemarks.Clear();
                        cmbResult.SelectedIndex = -1;
                        LoadApplicants();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving screening: " + ex.Message);
            }
        }

        private void btnViewDocument_Click(object sender, EventArgs e)
        {
            if (_selectedApplicantID == 0)
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            if (lstDocuments.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a document from the list first.");
                return;
            }

            string selectedDoc = lstDocuments.SelectedItem?.ToString();

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT ad.FilePath, ad.FileName
                FROM ApplicantDocuments ad
                JOIN RequirementTypes rt ON ad.RequirementTypeID = rt.RequirementTypeID
                WHERE ad.ApplicantID = @ApplicantID
                  AND rt.RequirementName = @DocName
                  AND ad.Status = 'Submitted'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApplicantID", _selectedApplicantID);
                    cmd.Parameters.AddWithValue("@DocName", selectedDoc);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string filePath = reader["FilePath"].ToString();
                        reader.Close();

                        if (string.IsNullOrEmpty(filePath))
                        {
                            MessageBox.Show("No file path found for this document.");
                            return;
                        }

                        if (!System.IO.File.Exists(filePath))
                        {
                            MessageBox.Show("File not found at path:\n" + filePath);
                            return;
                        }

                        // Open the file with the default associated program
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("This document has not been submitted yet.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening document: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadApplicants(txtSearch.Text.Trim());
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void lstDocuments_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormHRApplicantReviewandScreening_Load_1(object sender, EventArgs e)
        {
            LoadApplicants();
            LoadScreeningResults();

            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.MultiSelect = false;
            dgvApplicants.ReadOnly = true;

            dgvApplicants.SelectionChanged += (s, ev) =>
            {
                if (dgvApplicants.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvApplicants.SelectedRows[0];

                    _selectedApplicantID = Convert.ToInt32(row.Cells["ApplicantID"].Value);
                    _selectedApplicationID = Convert.ToInt32(row.Cells["ApplicationID"].Value);

                    txtApplicantName.Text = row.Cells["Name"].Value?.ToString();
                    txtPosition.Text = row.Cells["Position"].Value?.ToString();
                    txtEmail.Text = row.Cells["Email"].Value?.ToString();
                    txtContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString();
                    txtStatus.Text = row.Cells["Status"].Value?.ToString();

                    LoadDocuments(_selectedApplicantID);
                    LockApplicationForReview(_selectedApplicationID);
                }
            };
            btnSaveScreening.Click += button2_Click;
        }

        private void grpDocuments_Enter(object sender, EventArgs e)
        {

        }

        private void dgvApplicants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}