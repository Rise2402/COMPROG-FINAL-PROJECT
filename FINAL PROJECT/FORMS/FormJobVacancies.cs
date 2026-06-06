using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormJobVacancies : Form
    {
        private DataTable jobsTable = new DataTable();
        private int selectedJobVacancyID = 0;

        public FormJobVacancies()
        {
            InitializeComponent();
        }

        private void LoadJobs(string keyword = "")
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            jv.JobVacancyID,
                            jv.JobTitle AS Position,
                            d.DepartmentName AS Department,
                            et.EmploymentTypeName AS EmploymentType,
                            jv.Status,
                            jv.Qualifications,
                            jv.Description
                        FROM JobVacancies jv
                        JOIN Departments d ON jv.DepartmentID = d.DepartmentID
                        JOIN EmploymentTypes et ON jv.EmploymentTypeID = et.EmploymentTypeID
                        WHERE jv.Status = 'Open'";

                    if (!string.IsNullOrEmpty(keyword))
                        query += " AND (jv.JobTitle LIKE @Keyword OR d.DepartmentName LIKE @Keyword)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(keyword))
                        cmd.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    jobsTable = new DataTable();
                    adapter.Fill(jobsTable);

                    dgvJobs.DataSource = jobsTable;
                    dgvJobs.ReadOnly = true;
                    dgvJobs.AllowUserToAddRows = false;
                    dgvJobs.AllowUserToDeleteRows = false;
                    dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvJobs.Columns["JobVacancyID"] != null)
                        dgvJobs.Columns["JobVacancyID"].Visible = false;

                    if (dgvJobs.Rows.Count > 0)
                    {
                        dgvJobs.Rows[0].Selected = true;
                        DisplayJobDetails(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading jobs: " + ex.Message);
            }
        }

        private void DisplayJobDetails(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= jobsTable.Rows.Count) return;

            DataRow row = jobsTable.Rows[rowIndex];

            selectedJobVacancyID = Convert.ToInt32(row["JobVacancyID"]);
            txtPosition.Text = row["Position"].ToString();
            txtDepartment.Text = row["Department"].ToString();
            txtEmploymentType.Text = row["EmploymentType"].ToString();
            txtStatus.Text = row["Status"].ToString();
            rtbQualifications.Text = row["Qualifications"].ToString();

            // Load requirements from RequirementTypes
            lstRequirements.Items.Clear();
            lstRequirements.Items.Add("Resume");
            lstRequirements.Items.Add("Government ID");
            lstRequirements.Items.Add("Transcript of Records");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                DisplayJobDetails(e.RowIndex);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadJobs(txtSearch.Text.Trim());
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (selectedJobVacancyID == 0)
            {
                MessageBox.Show("Please select a job first.", "No Job Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Session.ApplicantID == 0)
            {
                MessageBox.Show("Please complete your profile first before applying.");
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Check duplicate application
                    string checkQuery = @"
                        SELECT COUNT(*) FROM Applications 
                        WHERE ApplicantID = @ApplicantID 
                        AND JobVacancyID = @JobVacancyID";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ApplicantID", Session.ApplicantID);
                    checkCmd.Parameters.AddWithValue("@JobVacancyID", selectedJobVacancyID);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        MessageBox.Show("You have already applied for this job!",
                            "Duplicate Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert application as Draft
                    string applyQuery = @"
                        INSERT INTO Applications (ApplicantID, JobVacancyID, CurrentStatus)
                        VALUES (@ApplicantID, @JobVacancyID, 'Draft')";

                    MySqlCommand applyCmd = new MySqlCommand(applyQuery, conn);
                    applyCmd.Parameters.AddWithValue("@ApplicantID", Session.ApplicantID);
                    applyCmd.Parameters.AddWithValue("@JobVacancyID", selectedJobVacancyID);
                    applyCmd.ExecuteNonQuery();

                    int applicationID = Convert.ToInt32(applyCmd.LastInsertedId);

                    // Record status history
                    string historyQuery = @"
                        INSERT INTO ApplicationStatusHistory 
                        (ApplicationID, StatusName, Remarks, ChangedBy)
                        VALUES (@AppID, 'Draft', 'Application created.', NULL)";

                    MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn);
                    historyCmd.Parameters.AddWithValue("@AppID", applicationID);
                    historyCmd.ExecuteNonQuery();

                    MessageBox.Show($"Application submitted for {txtPosition.Text}!",
                        "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying: " + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void rtbQualifications_TextChanged(object sender, EventArgs e) { }
        private void lstRequirements_SelectedIndexChanged(object sender, EventArgs e) { }

        private void FormJobVacancies_Load_1(object sender, EventArgs e)
        {
            LoadJobs();
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DisplayJobDetails(e.RowIndex);
            }
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {
            btnApply_Click(sender, e);
        }
    }
}