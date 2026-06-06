using FINAL_PROJECT;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormApplicantStatusTracking : Form
    {
        public FormApplicantStatusTracking()
        {
            InitializeComponent();
        }

        private void FormApplicantStatusTracking_Load(object sender, EventArgs e)
        {
            LoadStatusCombo();
            LoadApplications();
        }

        private void LoadStatusCombo()
        {
            cboStatus.Items.Clear();

            cboStatus.Items.Add("Draft");
            cboStatus.Items.Add("Submitted");
            cboStatus.Items.Add("Under Review");
            cboStatus.Items.Add("Shortlisted");
            cboStatus.Items.Add("For Interview");
            cboStatus.Items.Add("For Assessment");
            cboStatus.Items.Add("For Final Review");
            cboStatus.Items.Add("Accepted");
            cboStatus.Items.Add("Rejected");
            cboStatus.Items.Add("Withdrawn");
        }

        private void LoadApplications()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT
                    a.ApplicationID,
                    CONCAT(ap.FirstName,' ',ap.LastName) AS ApplicantName,
                    j.JobTitle,
                    a.ApplicationDate,
                    a.CurrentStatus
                FROM Applications a
                INNER JOIN Applicants ap
                    ON a.ApplicantID = ap.ApplicantID
                INNER JOIN JobVacancies j
                    ON a.JobVacancyID = j.JobVacancyID
                ORDER BY a.ApplicationDate DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvApplications.DataSource = dt;
                dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvApplications.MultiSelect = false;
                dgvApplications.ReadOnly = true;
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an applicant.");
                return;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            int applicationID = Convert.ToInt32(
                dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);

            string status = cboStatus.SelectedItem.ToString();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string updateQuery = @"
                    UPDATE Applications
                    SET CurrentStatus = @status
                    WHERE ApplicationID = @id";

                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", applicationID);

                cmd.ExecuteNonQuery();

                string historyQuery = @"
                    INSERT INTO ApplicationStatusHistory
                    (
                        ApplicationID,
                        StatusName,
                        Remarks,
                        ChangedBy
                    )
                    VALUES
                    (
                        @appID,
                        @status,
                        'Status Updated',
                        NULL
                    )";

                MySqlCommand historyCmd =
                    new MySqlCommand(historyQuery, conn);

                historyCmd.Parameters.AddWithValue("@appID", applicationID);
                historyCmd.Parameters.AddWithValue("@status", status);

                historyCmd.ExecuteNonQuery();

                MessageBox.Show("Status updated successfully.");

                LoadApplications();
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            dgvHistory frm = new dgvHistory();
            frm.ShowDialog();
        }
    }
}