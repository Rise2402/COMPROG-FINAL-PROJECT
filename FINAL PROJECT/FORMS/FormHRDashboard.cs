using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;
using Org.BouncyCastle.Pqc.Crypto.Frodo;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRDashboard : Form
    {
        public FormHRDashboard()
        {
            InitializeComponent();
        }

        private void FormHRDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            LoadStatCards();
            LoadRecentApplications();
            LoadUpcomingInterviews();
        }

        // ── STAT CARDS ────────────────────────────────────────────────
        private void LoadStatCards()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Total Applicants
                    string totalSql = "SELECT COUNT(*) FROM Applicants";
                    MySqlCommand cmd1 = new MySqlCommand(totalSql, conn);
                    lblCurrentStatus.Text = cmd1.ExecuteScalar().ToString();

                    // Pending Reviews (Submitted or Under Review)
                    string pendingSql = @"SELECT COUNT(*) FROM Applications 
                                         WHERE CurrentStatus IN ('Submitted', 'Under Review')";
                    MySqlCommand cmd2 = new MySqlCommand(pendingSql, conn);
                    label8.Text = cmd2.ExecuteScalar().ToString();

                    // Interviews Today
                    string todaySql = @"SELECT COUNT(*) FROM InterviewSchedules 
                                        WHERE DATE(InterviewDate) = CURDATE() 
                                        AND Status = 'Scheduled'";
                    MySqlCommand cmd3 = new MySqlCommand(todaySql, conn);
                    label6.Text = cmd3.ExecuteScalar().ToString();

                    // Accepted Applicants
                    string acceptedSql = @"SELECT COUNT(*) FROM Applications 
                                           WHERE CurrentStatus = 'Accepted'";
                    MySqlCommand cmd4 = new MySqlCommand(acceptedSql, conn);
                    label4.Text = cmd4.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stat cards: " + ex.Message);
            }
        }

        // ── RECENT APPLICATIONS ───────────────────────────────────────
        private void LoadRecentApplications()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            CONCAT(a.FirstName, ' ', a.LastName)  AS Applicant,
                            jv.JobTitle                           AS Position,
                            app.CurrentStatus                     AS Status,
                            DATE_FORMAT(app.ApplicationDate, '%m/%d/%Y') AS Date
                        FROM Applications app
                        INNER JOIN Applicants   a  ON app.ApplicantID  = a.ApplicantID
                        INNER JOIN JobVacancies jv ON app.JobVacancyID = jv.JobVacancyID
                        ORDER BY app.ApplicationDate DESC
                        LIMIT 10";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing rows and fill manually to match named columns
                    dataGridView1.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView1.Rows.Add(
                            row["Applicant"].ToString(),
                            row["Position"].ToString(),
                            row["Status"].ToString(),
                            row["Date"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent applications: " + ex.Message);
            }
        }

        // ── UPCOMING INTERVIEWS ───────────────────────────────────────
        private void LoadUpcomingInterviews()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT
                            CONCAT(a.FirstName, ' ', a.LastName)          AS Applicant,
                            DATE_FORMAT(isch.InterviewDate, '%m/%d/%Y')   AS Date,
                            DATE_FORMAT(isch.InterviewDate, '%h:%i %p')   AS Time,
                            isch.Interviewer                              AS Interviewer
                        FROM InterviewSchedules isch
                        INNER JOIN Applications app ON isch.ApplicationID = app.ApplicationID
                        INNER JOIN Applicants    a  ON app.ApplicantID    = a.ApplicantID
                        WHERE isch.InterviewDate >= NOW()
                          AND isch.Status = 'Scheduled'
                        ORDER BY isch.InterviewDate ASC
                        LIMIT 10";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView2.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView2.Rows.Add(
                            row["Applicant"].ToString(),
                            row["Date"].ToString(),
                            row["Time"].ToString(),
                            row["Interviewer"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading upcoming interviews: " + ex.Message);
            }
        }

        // ── NAVIGATION ────────────────────────────────────────────────
        private void button1_Click(object sender, EventArgs e)
        {
            FormHRJobVacancyManagement frm = new FormHRJobVacancyManagement();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHRApplicantList frm = new FormHRApplicantList();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHRApplicantReviewandScreening frm = new FormHRApplicantReviewandScreening();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormHRInterviewSchedule frm = new FormHRInterviewSchedule();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormHRInterviewEvaluation frm = new FormHRInterviewEvaluation();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormHRFinalDecision frm = new FormHRFinalDecision();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormHRReportsPage frm = new FormHRReportsPage();
            frm.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e) 
        {
            FormHRMaintenance frm = new FormHRMaintenance();
            frm.Show();
        }
      
        private void panel1_Paint_1(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void lblCurrentStatus_Click(object sender, EventArgs e) { }
        private void btnexit_Click(object sender, EventArgs e) { Close(); }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatCards();
            LoadRecentApplications();
            LoadUpcomingInterviews();
        }
    }
}