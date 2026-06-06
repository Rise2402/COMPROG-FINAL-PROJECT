using FINAL_PROJECT;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormApplicationPage : Form
    {
        private int _applicantId;
        private int _applicationId = -1;
        private string _currentStatus = "";

        private readonly string[] _lockedStatuses =
        {
            "Under Review", "Shortlisted", "For Interview",
            "For Assessment", "For Final Review",
            "Accepted", "Rejected", "Withdrawn"
        };

        public FormApplicationPage()
        {
            InitializeComponent();
            _applicantId = Session.ApplicantID;
        }

        private void MyApplicationPage_Load(object sender, EventArgs e)
        {
            LoadApplicationData();
        }

        private void LoadApplicationData()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            a.ApplicationID,
                            a.CurrentStatus,
                            a.ApplicationDate,
                            ap.FirstName,
                            ap.LastName,
                            ap.ContactNumber,
                            ap.AddressLine,
                            ap.Skills,
                            jv.JobTitle,
                            d.DepartmentName
                        FROM Applications a
                        INNER JOIN Applicants ap ON a.ApplicantID = ap.ApplicantID
                        INNER JOIN JobVacancies jv ON a.JobVacancyID = jv.JobVacancyID
                        INNER JOIN Departments d ON jv.DepartmentID = d.DepartmentID
                        WHERE a.ApplicantID = @ApplicantId
                        ORDER BY a.ApplicationDate DESC
                        LIMIT 1";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantId", _applicantId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _applicationId = reader.GetInt32("ApplicationID");
                                _currentStatus = reader.GetString("CurrentStatus");

                                lblApplicantName.Text =
                                    reader.GetString("FirstName") + " " +
                                    reader.GetString("LastName");
                                lblEmail.Text = Session.Email;
                                lblPhone.Text = reader["ContactNumber"].ToString();
                                lblAddress.Text = reader["AddressLine"].ToString();
                                lblSkills.Text = reader["Skills"].ToString();
                                lblJobApplied.Text =
                                    reader.GetString("JobTitle") + " — " +
                                    reader.GetString("DepartmentName");
                                lblStatus.Text = _currentStatus;
                                lblDateApplied.Text = reader.GetDateTime("ApplicationDate")
                                                            .ToString("MMMM dd, yyyy");

                                SetStatusColor(_currentStatus);

                                pnlNoApplication.Visible = false;
                                pnlView.Visible = true;
                                pnlEdit.Visible = false;

                                UpdateEditButton();
                            }
                            else
                            {
                                pnlNoApplication.Visible = true;
                                pnlView.Visible = false;
                                pnlEdit.Visible = false;
                                btnEditApplication.Enabled = false;
                                btnViewStatus.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application data:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetStatusColor(string status)
        {
            switch (status)
            {
                case "Draft":
                    lblStatus.ForeColor = Color.Gray;
                    lblStatus.BackColor = Color.FromArgb(240, 240, 240);
                    break;
                case "Submitted":
                    lblStatus.ForeColor = Color.FromArgb(0, 100, 200);
                    lblStatus.BackColor = Color.FromArgb(220, 235, 255);
                    break;
                case "Under Review":
                    lblStatus.ForeColor = Color.FromArgb(180, 100, 0);
                    lblStatus.BackColor = Color.FromArgb(255, 243, 205);
                    break;
                case "Shortlisted":
                    lblStatus.ForeColor = Color.FromArgb(0, 128, 0);
                    lblStatus.BackColor = Color.FromArgb(220, 255, 220);
                    break;
                case "Accepted":
                    lblStatus.ForeColor = Color.White;
                    lblStatus.BackColor = Color.FromArgb(0, 150, 0);
                    break;
                case "Rejected":
                    lblStatus.ForeColor = Color.White;
                    lblStatus.BackColor = Color.FromArgb(200, 0, 0);
                    break;
                default:
                    lblStatus.ForeColor = Color.Black;
                    lblStatus.BackColor = Color.LightGray;
                    break;
            }
        }

        private void UpdateEditButton()
        {
            bool isLocked = Array.Exists(_lockedStatuses,
                s => s.Equals(_currentStatus, StringComparison.OrdinalIgnoreCase));
            btnEditApplication.Enabled = !isLocked;
        }

        private void btnEditApplication_Click(object sender, EventArgs e)
        {
            if (_applicationId == -1) return;

            // Check if HR has started review
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string checkSql = "SELECT HRReviewStarted FROM Applications WHERE ApplicationID = @ID";
                    using (var cmd = new MySqlCommand(checkSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", _applicationId);
                        bool hrStarted = Convert.ToBoolean(cmd.ExecuteScalar());
                        if (hrStarted)
                        {
                            MessageBox.Show("Your application is locked for editing because HR has started reviewing it.",
                                "Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

            // Populate edit fields
            txtEditFirstName.Text = lblApplicantName.Text.Split(' ')[0];
            txtEditLastName.Text = lblApplicantName.Text.Contains(" ")
                ? lblApplicantName.Text.Substring(lblApplicantName.Text.IndexOf(' ') + 1)
                : "";
            txtEditEmail.Text = lblEmail.Text;
            txtEditPhone.Text = lblPhone.Text;
            txtEditAddress.Text = lblAddress.Text;
            txtEditSkills.Text = lblSkills.Text;

            pnlView.Visible = false;
            pnlEdit.Visible = true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_applicationId == -1) return;

            if (string.IsNullOrWhiteSpace(txtEditFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtEditLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEditEmail.Text))
            {
                MessageBox.Show("First Name, Last Name, and Email are required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string updateSql = @"
                                UPDATE Applicants SET
                                    FirstName = @FirstName,
                                    LastName = @LastName,
                                    ContactNumber = @Phone,
                                    AddressLine = @Address,
                                    Skills = @Skills
                                WHERE ApplicantID = @ApplicantId";

                            using (var cmd = new MySqlCommand(updateSql, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@FirstName", txtEditFirstName.Text.Trim());
                                cmd.Parameters.AddWithValue("@LastName", txtEditLastName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Phone", txtEditPhone.Text.Trim());
                                cmd.Parameters.AddWithValue("@Address", txtEditAddress.Text.Trim());
                                cmd.Parameters.AddWithValue("@Skills", txtEditSkills.Text.Trim());
                                cmd.Parameters.AddWithValue("@ApplicantId", _applicantId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            // Update session name
                            Session.FullName = txtEditFirstName.Text.Trim() + " " + txtEditLastName.Text.Trim();

                            MessageBox.Show("Changes saved successfully!",
                                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            pnlEdit.Visible = false;
                            pnlView.Visible = true;
                           
                            LoadApplicationData();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            pnlView.Visible = true;
          
        }

       

        private void btnBrowseJobs_Click(object sender, EventArgs e)
        {
            FormJobVacancies jobsForm = new FormJobVacancies();
            jobsForm.Show();
    
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_applicationId == -1) return;

            var confirm = MessageBox.Show(
                "Are you sure you want to submit your application?\n" +
                "You can still edit it until HR starts reviewing.",
                "Confirm Submission",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Update status to Submitted
                            string updateSql = @"
                                UPDATE Applications
                                SET CurrentStatus = 'Submitted'
                                WHERE ApplicationID = @ApplicationId";

                            using (var cmd = new MySqlCommand(updateSql, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ApplicationId", _applicationId);
                                cmd.ExecuteNonQuery();
                            }

                            // Log to ApplicationStatusHistory
                            string historySql = @"
                                INSERT INTO ApplicationStatusHistory
                                    (ApplicationID, StatusName, Remarks, ChangedBy)
                                VALUES
                                    (@ApplicationId, 'Submitted', 'Application submitted by applicant.', NULL)";

                            using (var cmd = new MySqlCommand(historySql, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ApplicationId", _applicationId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Your application has been submitted successfully!",
                                "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadApplicationData();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting application:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            FormApplicantStatusTracking statusForm = new FormApplicantStatusTracking();
            statusForm.Show();
        
        }

        private void lblNoAppIcon_Click(object sender, EventArgs e)
        {

        }

        private void pnlNoApplication_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}