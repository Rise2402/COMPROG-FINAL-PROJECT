using FINAL_PROJECT;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Windows.Forms;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRApplicantList : Form
    {
        public FormHRApplicantList()
        {
            InitializeComponent();
        }

        private void LoadPositionFilter()
        {
            cboPosition.Items.Clear();
            cboPosition.Items.Add("");
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DISTINCT JobTitle FROM JobVacancies ORDER BY JobTitle";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        cboPosition.Items.Add(reader["JobTitle"].ToString());
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading positions: " + ex.Message);
            }
            cboPosition.SelectedIndex = 0;
        }

        private void LoadStatusFilter()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("");
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
            cboStatus.SelectedIndex = 0;
        }

        private void LoadApplicants(string search = "", string position = "", string status = "")
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            a.ApplicantID,
                            CONCAT(a.FirstName, ' ', a.LastName) AS FullName,
                            aa.Email,
                            a.ContactNumber,
                            jv.JobTitle AS Position,
                            app.CurrentStatus AS Status,
                            app.ApplicationID,
                            app.ApplicationDate
                        FROM Applicants a
                        INNER JOIN ApplicantAccounts aa ON a.ApplicantAccountID = aa.ApplicantAccountID
                        INNER JOIN Applications app ON a.ApplicantID = app.ApplicantID
                        INNER JOIN JobVacancies jv ON app.JobVacancyID = jv.JobVacancyID
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(search))
                        query += " AND (a.FirstName LIKE @Search OR a.LastName LIKE @Search)";
                    if (!string.IsNullOrEmpty(position))
                        query += " AND jv.JobTitle = @Position";
                    if (!string.IsNullOrEmpty(status))
                        query += " AND app.CurrentStatus = @Status";

                    query += " ORDER BY app.ApplicationDate DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(search))
                        cmd.Parameters.AddWithValue("@Search", $"%{search}%");
                    if (!string.IsNullOrEmpty(position))
                        cmd.Parameters.AddWithValue("@Position", position);
                    if (!string.IsNullOrEmpty(status))
                        cmd.Parameters.AddWithValue("@Status", status);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvApplicants.DataSource = dt;

                    // Hide IDs
                    if (dgvApplicants.Columns["ApplicantID"] != null)
                        dgvApplicants.Columns["ApplicantID"].Visible = false;
                    if (dgvApplicants.Columns["ApplicationID"] != null)
                        dgvApplicants.Columns["ApplicationID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicants: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvApplicants.Rows[e.RowIndex];
                txtApplicantID.Text = row.Cells["ApplicantID"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString();
                txtPosition.Text = row.Cells["Position"].Value?.ToString();
                txtStatus.Text = row.Cells["Status"].Value?.ToString();
                int applicantID =
    Convert.ToInt32(row.Cells["ApplicantID"].Value);

                LoadMissingDocuments(applicantID);
            }
        }

        // Update Status button
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an applicant.");
                return;
            }

            int applicationID = Convert.ToInt32(dgvApplicants.SelectedRows[0].Cells["ApplicationID"].Value);
            string currentStatus = dgvApplicants.SelectedRows[0].Cells["Status"].Value?.ToString();

            // Show status selection dialog
            Form statusForm = new Form();
            statusForm.Text = "Update Status";
            statusForm.Size = new System.Drawing.Size(300, 180);
            statusForm.StartPosition = FormStartPosition.CenterScreen;

            ComboBox cbo = new ComboBox();
            cbo.Location = new System.Drawing.Point(20, 30);
            cbo.Size = new System.Drawing.Size(240, 25);
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            if (Session.RoleID == 2) // HR Staff
            {
                cbo.Items.AddRange(new object[] {
        "Submitted",
        "Under Review",
        "Shortlisted",
        "For Interview",
        "For Assessment",
        "For Final Review",
        "Withdrawn"
    });
            }
            else // Admin and HR Manager
            {
                cbo.Items.AddRange(new object[] {
        "Submitted",
        "Under Review",
        "Shortlisted",
        "For Interview",
        "For Assessment",
        "For Final Review",
        "Accepted",
        "Rejected",
        "Withdrawn"
    });
            }
            cbo.Text = currentStatus;

            Button btnOk = new Button();
            btnOk.Text = "Update";
            btnOk.Location = new System.Drawing.Point(80, 80);
            btnOk.Size = new System.Drawing.Size(100, 35);
            btnOk.BackColor = System.Drawing.Color.Navy;
            btnOk.ForeColor = System.Drawing.Color.White;
            btnOk.FlatStyle = FlatStyle.Flat;

            btnOk.Click += (s, ev) =>
            {
                if (cbo.SelectedItem == null) { MessageBox.Show("Please select a status."); return; }

                try
                {
                    using (var conn = DBConnection.GetConnection())
                    {
                        conn.Open();
                        using (var transaction = conn.BeginTransaction())
                        {
                            string newStatus = cbo.SelectedItem.ToString();

                            if (Session.RoleID == 2 &&
                            (newStatus == "Accepted" || newStatus == "Rejected"))
                            {
                                MessageBox.Show(
                                    "Only HR Manager or Admin can make final hiring decisions.",
                                    "Access Denied",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }

                            string updateQuery = "UPDATE Applications SET CurrentStatus = @Status WHERE ApplicationID = @ID";
                            MySqlCommand cmd = new MySqlCommand(updateQuery, conn, transaction);
                            cmd.Parameters.AddWithValue("@Status", newStatus);
                            cmd.Parameters.AddWithValue("@ID", applicationID);
                            cmd.ExecuteNonQuery();

                            string historyQuery = @"
                                INSERT INTO ApplicationStatusHistory 
                                (ApplicationID, StatusName, Remarks, ChangedBy)
                                VALUES (@AppID, @Status, 'Status updated by HR.', @UserID)";
                            MySqlCommand histCmd = new MySqlCommand(historyQuery, conn, transaction);
                            histCmd.Parameters.AddWithValue("@AppID", applicationID);
                            histCmd.Parameters.AddWithValue("@Status", newStatus);
                            histCmd.Parameters.AddWithValue("@UserID", Session.UserID);
                            histCmd.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Status updated successfully!");
                            statusForm.Close();
                            LoadApplicants();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message);
                }
            };

            statusForm.Controls.Add(cbo);
            statusForm.Controls.Add(btnOk);
            statusForm.ShowDialog();
        }

        // Refresh button
        private void button3_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboPosition.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            LoadApplicants();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }

        private void FormHRApplicantList_Load(object sender, EventArgs e)
        {
            LoadPositionFilter();
            LoadStatusFilter();
            LoadApplicants();

            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.MultiSelect = false;
            dgvApplicants.ReadOnly = true;

            dgvApplicants.SelectionChanged += (s, ev) =>
            {
                if (dgvApplicants.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvApplicants.SelectedRows[0];

                    txtApplicantID.Text = row.Cells["ApplicantID"].Value?.ToString();
                    txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                    txtEmail.Text = row.Cells["Email"].Value?.ToString();
                    txtContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString();
                    txtPosition.Text = row.Cells["Position"].Value?.ToString();
                    txtStatus.Text = row.Cells["Status"].Value?.ToString();

                    int applicantID =
                        Convert.ToInt32(row.Cells["ApplicantID"].Value);

                    LoadMissingDocuments(applicantID);
                }
            };

            cboPosition.SelectedIndexChanged += (s, ev) =>
            {
                LoadApplicants(
                    txtSearch.Text.Trim(),
                    cboPosition.SelectedItem?.ToString() ?? "",
                    cboStatus.SelectedItem?.ToString() ?? ""
                );
            };

            cboStatus.SelectedIndexChanged += (s, ev) =>
            {
                LoadApplicants(
                    txtSearch.Text.Trim(),
                    cboPosition.SelectedItem?.ToString() ?? "",
                    cboStatus.SelectedItem?.ToString() ?? ""
                );
            };

            btnRefresh.Click += button3_Click;
            btnUpdateStatus.Click += button2_Click;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboPosition.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            LoadApplicants();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            LoadApplicants(
             txtSearch.Text.Trim(),
             cboPosition.SelectedItem?.ToString() ?? "",
             cboStatus.SelectedItem?.ToString() ?? ""
         );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LoadMissingDocuments(int applicantID)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
            SELECT RequirementName
            FROM RequirementTypes
            WHERE RequirementTypeID IN (1,2,3)
            AND RequirementTypeID NOT IN
            (
                SELECT RequirementTypeID
                FROM ApplicantDocuments
                WHERE ApplicantID = @ApplicantID
            )
            ORDER BY RequirementName";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApplicantID", applicantID);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    txtMissingDocs.Clear();

                    while (reader.Read())
                    {
                        txtMissingDocs.AppendText(
                            reader["RequirementName"].ToString() +
                            Environment.NewLine
                        );
                    }

                    reader.Close();

                    if (txtMissingDocs.Text.Trim() == "")
                    {
                        txtMissingDocs.Text = "No missing documents.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}