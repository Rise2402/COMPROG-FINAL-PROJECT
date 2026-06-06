using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormApplicantDashboard : Form
    {
        public FormApplicantDashboard()
        {
            InitializeComponent();
        }
        private void LoadCurrentStatus(int applicantID)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
            SELECT CurrentStatus
            FROM Applications
            WHERE ApplicantID = @ApplicantID
            ORDER BY ApplicationDate DESC
            LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lblCurrentStatus.Text = result.ToString();
                    }
                    else
                    {
                        lblCurrentStatus.Text = "No Application";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadMissingDocuments(int applicantID)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string requiredQuery = @"
                SELECT COUNT(DISTINCT jvr.RequirementTypeID)
                FROM Applications a
                INNER JOIN JobVacancyRequirements jvr
                    ON a.JobVacancyID = jvr.JobVacancyID
                WHERE a.ApplicantID = @ApplicantID";

                    MySqlCommand requiredCmd =
                        new MySqlCommand(requiredQuery, conn);

                    requiredCmd.Parameters.AddWithValue(
                        "@ApplicantID",
                        applicantID);

                    int requiredCount =
                        Convert.ToInt32(requiredCmd.ExecuteScalar());

                    string uploadedQuery = @"
                SELECT COUNT(DISTINCT RequirementTypeID)
                FROM ApplicantDocuments
                WHERE ApplicantID = @ApplicantID";

                    MySqlCommand uploadedCmd =
                        new MySqlCommand(uploadedQuery, conn);

                    uploadedCmd.Parameters.AddWithValue(
                        "@ApplicantID",
                        applicantID);

                    int uploadedCount =
                        Convert.ToInt32(uploadedCmd.ExecuteScalar());

                    int missingCount =
                        Math.Max(0, requiredCount - uploadedCount);

                    lblMissingDocs.Text =
                        missingCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadInterviewStatus(int applicantID)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
            SELECT InterviewDate
            FROM InterviewSchedules i
            INNER JOIN Applications a
            ON i.ApplicationID = a.ApplicationID
            WHERE a.ApplicantID = @ApplicantID
            AND i.Status = 'Scheduled'
            ORDER BY InterviewDate
            LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        DateTime interviewDate =
                            Convert.ToDateTime(result);

                        lblInterviewStatus.Text =
                            interviewDate.ToString("MMM dd, yyyy");
                    }
                    else
                    {
                        lblInterviewStatus.Text = "No Interview";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadRecentUpdates(int applicantID)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
            SELECT
                h.DateChanged,
                h.StatusName,
                h.Remarks
            FROM ApplicationStatusHistory h
            INNER JOIN Applications a
                ON h.ApplicationID = a.ApplicationID
            WHERE a.ApplicantID = @ApplicantID
            ORDER BY h.DateChanged DESC";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@ApplicantID",
                        applicantID);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormApplicantDashboard_Load(object sender, EventArgs e)
        {
            int applicantID = Session.ApplicantID;

            LoadCurrentStatus(applicantID);
            LoadMissingDocuments(applicantID);
            LoadInterviewStatus(applicantID);
            LoadRecentUpdates(applicantID);
        }

        private void lblCurrentStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormApplicantStatusTracking frm = new FormApplicantStatusTracking();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormApplicantDocuments frm = new FormApplicantDocuments();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormApplicationPage frm = new FormApplicationPage();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormJobVacancies frm = new FormJobVacancies();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormApplicantProfile frm = new FormApplicantProfile();
            frm.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblInterviewStatus_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMissingDocs_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
