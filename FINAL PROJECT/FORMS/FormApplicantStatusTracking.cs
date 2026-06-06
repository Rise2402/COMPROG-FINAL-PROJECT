using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

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

            // Hide HR controls — applicants can only view
            btnUpdateStatus.Visible = false;
            cboStatus.Visible = false;
            lblStatus.Visible = false;
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
            try
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
                        INNER JOIN Applicants ap ON a.ApplicantID = ap.ApplicantID
                        INNER JOIN JobVacancies j ON a.JobVacancyID = j.JobVacancyID
                        WHERE a.ApplicantID = @ApplicantID
                        ORDER BY a.ApplicationDate DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@ApplicantID", Session.ApplicantID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvApplications.DataSource = dt;
                    dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvApplications.MultiSelect = false;
                    dgvApplications.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            // HR only - hidden from applicants
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application.");
                return;
            }

            int applicationID = Convert.ToInt32(
                dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);

            FormStatusHistory frm = new FormStatusHistory(applicationID);
            frm.ShowDialog();
        }
    }
}