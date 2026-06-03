// ============================================================
//  MyApplicationPage.cs
//  Assigned to: Zee (Marienor)
//  Part of: HR Applicant Process Windows Application
//
//  NAMESPACE: Change "MyApplicationPage" below to match your
//             group's actual namespace (check any other .cs file)
// ============================================================

using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyApplicationPage   // <<< CHANGE THIS to your group's namespace
{
    public partial class Form1 : Form
    {
        // --------------------------------------------------------
        //  CONNECTION STRING — update to match your group's DB
        // --------------------------------------------------------
        private readonly string _connString =
            "Server=localhost;Database=hr_applicant_db;Uid=root;Pwd=;";

        // --------------------------------------------------------
        //  TODO (Leader / DB Person): Replace the line above with
        //  your group's shared DB helper, e.g.:
        //      private readonly string _connString = DBHelper.ConnString;
        // --------------------------------------------------------

        // The logged-in applicant's ID.
        // TODO (Leader): Pass this in from your session/login form.
        //   Example in your login form's button click:
        //     new MyApplicationPage(SessionManager.ApplicantId).Show();
        private int _applicantId;

        // Holds the loaded application data
        private int _applicationId = -1;
        private string _currentStatus = "";
        private bool _isEditMode = false;

        // Statuses where editing is NOT allowed (per capstone rules)
        private readonly string[] _lockedStatuses =
        {
            "Under Review", "Shortlisted", "For Interview",
            "For Assessment", "For Final Review",
            "Accepted", "Rejected", "Withdrawn"
        };

        // ============================================================
        //  CONSTRUCTOR
        // ============================================================
        public Form1(int applicantId)
        {
            InitializeComponent();
            _applicantId = applicantId;
        }

        // ============================================================
        //  FORM LOAD — automatically shows the application
        // ============================================================
        private void MyApplicationPage_Load(object sender, EventArgs e)
        {
            LoadApplicationData();
        }

        // ============================================================
        //  LOAD APPLICATION DATA FROM DATABASE
        // ============================================================
        private void LoadApplicationData()
        {
            try
            {
                using (var conn = new MySqlConnection(_connString))
                {
                    conn.Open();

                    // ------------------------------------------------
                    //  TODO (Leader / DB Person): Verify column names
                    //  match your actual Applications + Applicants tables.
                    //
                    //  Expected tables (from capstone requirements):
                    //    Applications (ApplicationId, ApplicantId,
                    //                  JobVacancyId, Status, DateApplied)
                    //    Applicants   (ApplicantId, FirstName, LastName,
                    //                  Email, Phone, Address, Skills)
                    //    JobVacancies (JobVacancyId, JobTitle, Department)
                    // ------------------------------------------------
                    string sql = @"
                        SELECT
                            a.ApplicationId,
                            a.Status,
                            a.DateApplied,
                            ap.FirstName,
                            ap.LastName,
                            ap.Email,
                            ap.Phone,
                            ap.Address,
                            ap.Skills,
                            jv.JobTitle,
                            jv.Department
                        FROM Applications a
                        INNER JOIN Applicants ap ON a.ApplicantId = ap.ApplicantId
                        INNER JOIN JobVacancies jv ON a.JobVacancyId = jv.JobVacancyId
                        WHERE a.ApplicantId = @ApplicantId
                        ORDER BY a.DateApplied DESC
                        LIMIT 1";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantId", _applicantId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _applicationId = reader.GetInt32("ApplicationId");
                                _currentStatus = reader.GetString("Status");

                                // Populate VIEW panel
                                lblApplicantName.Text =
                                    reader.GetString("FirstName") + " " +
                                    reader.GetString("LastName");
                                lblEmail.Text = reader.GetString("Email");
                                lblPhone.Text = reader.GetString("Phone");
                                lblAddress.Text = reader.GetString("Address");
                                lblSkills.Text = reader.GetString("Skills");
                                lblJobApplied.Text =
                                    reader.GetString("JobTitle") + " — " +
                                    reader.GetString("Department");
                                lblStatus.Text = _currentStatus;
                                lblDateApplied.Text = reader.GetDateTime("DateApplied")
                                                           .ToString("MMMM dd, yyyy");

                                // Color-code status badge
                                SetStatusColor(_currentStatus);

                                // Show the view panel, hide "no application" panel
                                pnlNoApplication.Visible = false;
                                pnlView.Visible = true;
                                pnlEdit.Visible = false;

                                UpdateEditButton();
                            }
                            else
                            {
                                // Applicant has no application yet
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
                MessageBox.Show(
                    "Error loading application data:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        //  STATUS BADGE COLOR
        // ============================================================
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
                case "For Interview":
                case "For Assessment":
                    lblStatus.ForeColor = Color.FromArgb(0, 130, 80);
                    lblStatus.BackColor = Color.FromArgb(210, 245, 225);
                    break;
                case "Accepted":
                    lblStatus.ForeColor = Color.White;
                    lblStatus.BackColor = Color.FromArgb(0, 160, 80);
                    break;
                case "Rejected":
                case "Withdrawn":
                    lblStatus.ForeColor = Color.White;
                    lblStatus.BackColor = Color.FromArgb(200, 50, 50);
                    break;
                default:
                    lblStatus.ForeColor = Color.Black;
                    lblStatus.BackColor = Color.LightGray;
                    break;
            }
        }

        // ============================================================
        //  ENABLE / DISABLE EDIT BUTTON BASED ON STATUS
        // ============================================================
        private void UpdateEditButton()
        {
            bool isLocked = Array.Exists(
                _lockedStatuses,
                s => s.Equals(_currentStatus, StringComparison.OrdinalIgnoreCase));

            btnEditApplication.Enabled = !isLocked;

            if (isLocked)
            {
                btnEditApplication.Text = "🔒 Edit Locked";
                btnEditApplication.BackColor = Color.FromArgb(200, 200, 200);
                toolTip1.SetToolTip(
                    btnEditApplication,
                    "Editing is locked once HR starts reviewing your application.");
            }
            else
            {
                btnEditApplication.Text = "✏️ Edit Application";
                btnEditApplication.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        // ============================================================
        //  BUTTON: EDIT APPLICATION
        // ============================================================
        private void btnEditApplication_Click(object sender, EventArgs e)
        {
            if (_applicationId == -1) return;

            // Double-check lock from DB (in case status changed server-side)
            bool isLocked = Array.Exists(
                _lockedStatuses,
                s => s.Equals(_currentStatus, StringComparison.OrdinalIgnoreCase));

            if (isLocked)
            {
                MessageBox.Show(
                    "Your application is currently locked for editing.\n" +
                    "Status: " + _currentStatus,
                    "Edit Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Pre-fill edit fields from view labels
            txtEditFirstName.Text = lblApplicantName.Text.Split(' ')[0];
            txtEditLastName.Text = lblApplicantName.Text.Contains(" ")
                ? lblApplicantName.Text.Substring(lblApplicantName.Text.IndexOf(' ') + 1)
                : "";
            txtEditEmail.Text = lblEmail.Text;
            txtEditPhone.Text = lblPhone.Text;
            txtEditAddress.Text = lblAddress.Text;
            txtEditSkills.Text = lblSkills.Text;

            // Switch panels
            pnlView.Visible = false;
            pnlEdit.Visible = true;
            _isEditMode = true;
        }

        // ============================================================
        //  BUTTON: SAVE (inside edit panel)
        // ============================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            // --- Basic Validation ---
            if (string.IsNullOrWhiteSpace(txtEditFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtEditLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEditEmail.Text))
            {
                MessageBox.Show(
                    "First name, last name, and email are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(_connString))
                {
                    conn.Open();

                    // ------------------------------------------------
                    //  TODO (Leader / DB Person): Confirm column names
                    //  in your Applicants table match these.
                    // ------------------------------------------------
                    string sql = @"
                        UPDATE Applicants SET
                            FirstName = @FirstName,
                            LastName  = @LastName,
                            Email     = @Email,
                            Phone     = @Phone,
                            Address   = @Address,
                            Skills    = @Skills
                        WHERE ApplicantId = @ApplicantId";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtEditFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtEditLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEditEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtEditPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtEditAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@Skills", txtEditSkills.Text.Trim());
                        cmd.Parameters.AddWithValue("@ApplicantId", _applicantId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show(
                                "Application updated successfully!",
                                "Saved",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Refresh and return to view mode
                            pnlEdit.Visible = false;
                            pnlView.Visible = true;
                            _isEditMode = false;
                            LoadApplicationData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving changes:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        //  BUTTON: CANCEL EDIT
        // ============================================================
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            pnlView.Visible = true;
            _isEditMode = false;
        }

        // ============================================================
        //  BUTTON: VIEW STATUS
        //  TODO (Leader): Wire this to whoever built ApplicationStatusPage
        //
        //  Example:
        //    new ApplicationStatusPage(_applicantId, _applicationId).Show();
        //    this.Hide();
        // ============================================================
        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            // PLACEHOLDER — replace when ApplicationStatusPage is ready
            MessageBox.Show(
                "[TODO] Open ApplicationStatusPage here.\n\n" +
                "Pass: applicantId = " + _applicantId +
                ", applicationId = " + _applicationId,
                "Navigation Placeholder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // TODO (Leader): Uncomment and adjust when ready:
            // var statusPage = new ApplicationStatusPage(_applicantId, _applicationId);
            // statusPage.Show();
            // this.Hide();
        }

        // ============================================================
        //  BUTTON: BROWSE JOBS (shown when no application exists)
        //  TODO (Leader): Wire this to whoever built JobVacanciesPage
        //
        //  Example:
        //    new JobVacanciesPage(_applicantId).Show();
        //    this.Hide();
        // ============================================================
        private void btnBrowseJobs_Click(object sender, EventArgs e)
        {
            // PLACEHOLDER — replace when JobVacanciesPage is ready
            MessageBox.Show(
                "[TODO] Open JobVacanciesPage here.\n\n" +
                "Pass: applicantId = " + _applicantId,
                "Navigation Placeholder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // TODO (Leader): Uncomment and adjust when ready:
            // var jobsPage = new JobVacanciesPage(_applicantId);
            // jobsPage.Show();
            // this.Hide();
        }

        // ============================================================
        //  BUTTON: SUBMIT APPLICATION
        //  Only shown when status is Draft — changes status to Submitted
        //  and logs to ApplicationStatusHistory
        // ============================================================
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
                using (var conn = new MySqlConnection(_connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Update application status
                            string updateSql = @"
                                UPDATE Applications
                                SET Status = 'Submitted'
                                WHERE ApplicationId = @ApplicationId";

                            using (var cmd = new MySqlCommand(updateSql, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ApplicationId", _applicationId);
                                cmd.ExecuteNonQuery();
                            }

                            // ----------------------------------------
                            //  Log to ApplicationStatusHistory
                            //  TODO (Leader / DB Person): Confirm column
                            //  names in ApplicationStatusHistory table.
                            //
                            //  Expected columns:
                            //    ApplicationId, Status, ChangedAt, Remarks
                            // ----------------------------------------
                            string historySql = @"
                                INSERT INTO ApplicationStatusHistory
                                    (ApplicationId, Status, ChangedAt, Remarks)
                                VALUES
                                    (@ApplicationId, 'Submitted', NOW(),
                                     'Application submitted by applicant.')";

                            using (var cmd = new MySqlCommand(historySql, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ApplicationId", _applicationId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show(
                                "Your application has been submitted successfully!",
                                "Submitted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

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
                MessageBox.Show(
                    "Error submitting application:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        //  BUTTON: BACK
        //  TODO (Leader): Wire this to your Dashboard or main menu
        //
        //  Example:
        //    new ApplicantDashboard(_applicantId).Show();
        //    this.Close();
        // ============================================================
        private void btnBack_Click(object sender, EventArgs e)
        {
            // PLACEHOLDER — replace with your actual dashboard form
            MessageBox.Show(
                "[TODO] Go back to ApplicantDashboard here.\n\n" +
                "Pass: applicantId = " + _applicantId,
                "Navigation Placeholder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // TODO (Leader): Uncomment and adjust when ready:
            // new ApplicantDashboard(_applicantId).Show();
            // this.Close();
        }
    }
}