using System.Linq;namespace ApplicantReviewScreening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvApplicants.Columns.Add("ID", "Applicant ID");
            dgvApplicants.Columns.Add("Name", "Applicant Name");
            dgvApplicants.Columns.Add("Position", "Position");
            dgvApplicants.Columns.Add("Email", "Email");
            dgvApplicants.Columns.Add("Contact", "Contact Number");
            dgvApplicants.Columns.Add("Status", "Status");

            dgvApplicants.Rows.Add(
                "APP001",
                "John Cruz",
                "IT Support",
                "john@gmail.com",
                "09171234567",
                "Pending Review");

            dgvApplicants.Rows.Add(
                "APP002",
                "Maria Santos",
                "HR Assistant",
                "maria@gmail.com",
                "09181111111",
                "Pending Review");

            cmbResult.Items.Add("Qualified");
            cmbResult.Items.Add("Needs Interview");
            cmbResult.Items.Add("Rejected");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null)
            {
                MessageBox.Show("Select an applicant first.");
                return;
            }

            if (cmbResult.Text == "")
            {
                MessageBox.Show("Select a screening result.");
                return;
            }

            if (cmbResult.Text == "Qualified")
            {
                dgvApplicants.CurrentRow.Cells["Status"].Value =
                    "Shortlisted";
            }
            else if (cmbResult.Text == "Needs Interview")
            {
                dgvApplicants.CurrentRow.Cells["Status"].Value =
                    "Interview Scheduled";
            }
            else
            {
                dgvApplicants.CurrentRow.Cells["Status"].Value =
                    "Rejected";
            }

            txtStatus.Text =
                dgvApplicants.CurrentRow.Cells["Status"].Value.ToString();

            MessageBox.Show("Screening saved successfully.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvApplicants.Rows[e.RowIndex];

            txtApplicantName.Text =
                row.Cells["Name"].Value.ToString();

            txtPosition.Text =
                row.Cells["Position"].Value.ToString();

            txtEmail.Text =
                row.Cells["Email"].Value.ToString();

            txtContactNumber.Text =
                row.Cells["Contact"].Value.ToString();

            txtStatus.Text =
                row.Cells["Status"].Value.ToString();

            lstDocuments.Items.Clear();

            lstDocuments.Items.Add("Resume", true);
            lstDocuments.Items.Add("Valid ID", true);
            lstDocuments.Items.Add("Transcript of Records", true);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search =
        txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvApplicants.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string applicantName =
                    row.Cells["Name"].Value.ToString().ToLower();

                row.Visible =
                    applicantName.Contains(search);
            }
        }
    }
}
