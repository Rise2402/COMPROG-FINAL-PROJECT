using System.Data;

namespace JobVacansies
{
    public partial class frmJobVacancies : Form
    {
        private DataTable jobsTable = new DataTable();

        public frmJobVacancies()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvJobs.DataSource = jobsTable;
                return;
            }

            DataView dv = jobsTable.DefaultView;

            dv.RowFilter =
                $"Position LIKE '%{keyword}%' OR Department LIKE '%{keyword}%'";

            dgvJobs.DataSource = dv;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvJobs.Rows[e.RowIndex];

                txtPosition.Text =
                    row.Cells["Position"].Value.ToString();

                txtDepartment.Text =
                    row.Cells["Department"].Value.ToString();

                txtEmploymentType.Text =
                    row.Cells["EmploymentType"].Value.ToString();

                txtStatus.Text =
                    row.Cells["Status"].Value.ToString();

                rtbQualifications.Text =
                    row.Cells["Qualifications"].Value.ToString();

                lstRequirements.Items.Clear();

                string[] requirements =
                    row.Cells["Requirements"]
                    .Value
                    .ToString()
                    .Split(',');

                foreach (string item in requirements)
                {
                    lstRequirements.Items.Add(item.Trim());
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jobsTable.Columns.Add("Position");
            jobsTable.Columns.Add("Department");
            jobsTable.Columns.Add("EmploymentType");
            jobsTable.Columns.Add("Status");
            jobsTable.Columns.Add("Qualifications");
            jobsTable.Columns.Add("Requirements");

            jobsTable.Rows.Add(
                "IT Support",
                "Information Technology",
                "Full Time",
                "Open",
                "Bachelor's Degree in IT\nGood Communication Skills",
                "Resume, Transcript, Valid ID");

            jobsTable.Rows.Add(
                "HR Assistant",
                "Human Resources",
                "Full Time",
                "Open",
                "HR Graduate\nOrganized and Detail-Oriented",
                "Resume, Transcript");

            jobsTable.Rows.Add(
                "Marketing Intern",
                "Marketing",
                "Internship",
                "Open",
                "Marketing Student\nCreative Thinker",
                "Resume, Valid ID");

            dgvJobs.DataSource = jobsTable;

            dgvJobs.ReadOnly = true;
            dgvJobs.AllowUserToAddRows = false;
            dgvJobs.AllowUserToDeleteRows = false;

            dgvJobs.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            if (dgvJobs.Rows.Count > 0)
            {
                dgvJobs.Rows[0].Selected = true;

                txtPosition.Text =
                    dgvJobs.Rows[0].Cells["Position"].Value.ToString();

                txtDepartment.Text =
                    dgvJobs.Rows[0].Cells["Department"].Value.ToString();

                txtEmploymentType.Text =
                    dgvJobs.Rows[0].Cells["EmploymentType"].Value.ToString();

                txtStatus.Text =
                    dgvJobs.Rows[0].Cells["Status"].Value.ToString();

                rtbQualifications.Text =
                    dgvJobs.Rows[0].Cells["Qualifications"].Value.ToString();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show(
                    "Please select a job first.",
                    "No Job Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show(
                $"Application submitted for {txtPosition.Text}.",
                "Application Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void rtbQualifications_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstRequirements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
