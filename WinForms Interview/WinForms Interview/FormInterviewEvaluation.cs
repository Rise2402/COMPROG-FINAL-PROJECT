using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantSystem
{
    public partial class FormInterviewEvaluation : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public FormInterviewEvaluation()
        {
            InitializeComponent();
        }

        private void FormInterviewEvaluation_Load(
            object sender,
            EventArgs e)
        {
            LoadSchedules();
        }

        private void LoadSchedules()
        {
            using (MySqlConnection conn =
                db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT
                    i.InterviewScheduleID,
                    CONCAT(a.FirstName,' ',a.LastName)
                        AS ApplicantName,
                    j.JobTitle,
                    i.InterviewDate
                FROM InterviewSchedules i
                INNER JOIN Applications ap
                    ON i.ApplicationID = ap.ApplicationID
                INNER JOIN Applicants a
                    ON ap.ApplicantID = a.ApplicantID
                INNER JOIN JobVacancies j
                    ON ap.JobVacancyID = j.JobVacancyID
                WHERE i.Status='Scheduled'
                ";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, conn);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvSchedules.DataSource = dt;

                dgvSchedules.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnSaveEvaluation_Click(
            object sender,
            EventArgs e)
        {
            if (dgvSchedules.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select interview.");

                return;
            }

            int scheduleID =
                Convert.ToInt32(
                    dgvSchedules.SelectedRows[0]
                    .Cells["InterviewScheduleID"].Value);

            using (MySqlConnection conn =
                db.GetConnection())
            {
                conn.Open();

                string query = @"
                INSERT INTO InterviewEvaluations
                (
                    InterviewScheduleID,
                    Score,
                    Remarks,
                    Result,
                    Recommendation
                )
                VALUES
                (
                    @scheduleID,
                    @score,
                    @remarks,
                    @result,
                    @recommendation
                )";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@scheduleID",
                    scheduleID);

                cmd.Parameters.AddWithValue(
                    "@score",
                    txtScore.Text);

                cmd.Parameters.AddWithValue(
                    "@remarks",
                    txtRemarks.Text);

                cmd.Parameters.AddWithValue(
                    "@result",
                    cboResult.Text);

                cmd.Parameters.AddWithValue(
                    "@recommendation",
                    txtRecommendation.Text);

                cmd.ExecuteNonQuery();

                string updateSchedule = @"
                UPDATE InterviewSchedules
                SET Status='Completed'
                WHERE InterviewScheduleID=@id";

                MySqlCommand scheduleCmd =
                    new MySqlCommand(updateSchedule, conn);

                scheduleCmd.Parameters.AddWithValue(
                    "@id",
                    scheduleID);

                scheduleCmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Interview Evaluation Saved.");

                LoadSchedules();
            }
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvSchedules = new DataGridView();
            lblScore = new Label();
            txtScore = new TextBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            lblResult = new Label();
            cboResult = new ComboBox();
            lblRecommendation = new Label();
            txtRecommendation = new TextBox();
            btnSaveEvaluation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(25, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Interview Evaluation";
            lblTitle.Click += label1_Click;
            // 
            // dgvSchedules
            // 
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Location = new Point(25, 42);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.Size = new Size(793, 188);
            dgvSchedules.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(25, 245);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(49, 20);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(173, 242);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 3;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(25, 295);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(68, 20);
            lblRemarks.TabIndex = 4;
            lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(173, 288);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(125, 27);
            txtRemarks.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(25, 341);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "Result:";
            // 
            // cboResult
            // 
            cboResult.FormattingEnabled = true;
            cboResult.Location = new Point(173, 333);
            cboResult.Name = "cboResult";
            cboResult.Size = new Size(151, 28);
            cboResult.TabIndex = 7;
            // 
            // lblRecommendation
            // 
            lblRecommendation.AutoSize = true;
            lblRecommendation.Location = new Point(25, 384);
            lblRecommendation.Name = "lblRecommendation";
            lblRecommendation.Size = new Size(130, 20);
            lblRecommendation.TabIndex = 8;
            lblRecommendation.Text = "Recommendation:";
            // 
            // txtRecommendation
            // 
            txtRecommendation.Location = new Point(173, 384);
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.Size = new Size(125, 27);
            txtRecommendation.TabIndex = 9;
            // 
            // btnSaveEvaluation
            // 
            btnSaveEvaluation.Location = new Point(367, 463);
            btnSaveEvaluation.Name = "btnSaveEvaluation";
            btnSaveEvaluation.Size = new Size(157, 29);
            btnSaveEvaluation.TabIndex = 10;
            btnSaveEvaluation.Text = "Save Evaluation";
            btnSaveEvaluation.UseVisualStyleBackColor = true;
            // 
            // FormInterviewEvaluation
            // 
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(843, 504);
            Controls.Add(btnSaveEvaluation);
            Controls.Add(txtRecommendation);
            Controls.Add(lblRecommendation);
            Controls.Add(cboResult);
            Controls.Add(lblResult);
            Controls.Add(txtRemarks);
            Controls.Add(lblRemarks);
            Controls.Add(txtScore);
            Controls.Add(lblScore);
            Controls.Add(dgvSchedules);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.ControlText;
            Name = "FormInterviewEvaluation";
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private Label lblTitle;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private DataGridView dgvSchedules;
        private Label lblScore;
        private TextBox txtScore;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Label lblResult;
        private ComboBox cboResult;
        private Label lblRecommendation;
        private TextBox txtRecommendation;
        private Button btnSaveEvaluation;
    }
}using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Interview
{
    public partial class FormInterviewEvaluation : Form
    {
        public FormInterviewEvaluation()
        {
            InitializeComponent();
        }
    }
}
