namespace final_hiring
{
    public partial class FormFinalHiringDecision : Form
    {
        public FormFinalHiringDecision()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvApplicants.Rows[e.RowIndex];

                txtApplicantName.Text = row.Cells[1].Value?.ToString();
                txtPosition.Text = row.Cells[2].Value?.ToString();

                // Sample data
                txtEmail.Text = "sample@email.com";
                txtContactNumber.Text = "09123456789";

                txtInterviewScore.Text = "90"; // Interview Score
                txtInterviewResult.Text = "Passed";
                rtbInterviewRemarks.Text = "Good communication skills.";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvApplicants.Rows.Add("A001", "Juan Dela Cruz", "Software Developer", "Passed");
            dgvApplicants.Rows.Add("A002", "Maria Santos", "UI Designer", "Passed");
            dgvApplicants.Rows.Add("A003", "John Reyes", "QA Tester", "Passed");

            cmbDecision.SelectedIndex = 0;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveDecision_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvApplicants.Rows)
            {
                if (!row.IsNewRow)
                {
                    string name = row.Cells[1].Value.ToString().ToLower();

                    row.Visible = name.Contains(searchText);
                }
            }
        }

        private void txtApplicantName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInterviewResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbInterviewRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDecision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveDecision_Click_1(object sender, EventArgs e)
        {
            if (txtApplicantName.Text == "")
            {
                MessageBox.Show("Please select an applicant first.");
                return;
            }

            MessageBox.Show(
                "Decision Saved!\n\n" +
                "Applicant: " + txtApplicantName.Text +
                "\nDecision: " + cmbDecision.Text,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtApplicantName.Clear();
            txtPosition.Clear();
            txtEmail.Clear();
            txtContactNumber.Clear();

            txtInterviewScore.Clear();
            txtInterviewResult.Clear();

            rtbInterviewRemarks.Clear();
            rtbRemarks.Clear();

            cmbDecision.SelectedIndex = -1;

            txtSearch.Clear();
        }

        private void rtbRemarks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
