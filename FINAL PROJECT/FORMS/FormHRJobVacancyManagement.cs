using FINAL_PROJECT;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRJobVacancyManagement : Form
    {
        DataTable dtVacancies = new DataTable();
        int editingJobVacancyID = -1;

        private void SetRoundedPanel(Panel panel, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new System.Drawing.Region(path);
        }

        private void ApplyFilters()
        {
            if (dtVacancies.Rows.Count == 0) return;

            string search = txtSearchbar.Text.Trim().ToLower();
            string status = cmbFilterStatus.SelectedItem?.ToString() ?? "";
            string department = cmbFilterDepartment.SelectedItem?.ToString() ?? "";

            var filtered = dtVacancies.AsEnumerable().Where(row =>
                (string.IsNullOrEmpty(search) || row["Job Title"].ToString().ToLower().Contains(search)) &&
                (string.IsNullOrEmpty(status) || row["Status"].ToString() == status) &&
                (string.IsNullOrEmpty(department) || row["Department"].ToString() == department)
            );

            dataGridView1.DataSource = filtered.Any() ? filtered.CopyToDataTable() : dtVacancies.Clone();
        }

        private void UpdateStats()
        {
            int total = dtVacancies.Rows.Count;
            int open = dtVacancies.AsEnumerable().Count(r => r["Status"].ToString() == "Open");
            int close = dtVacancies.AsEnumerable().Count(r => r["Status"].ToString() == "Closed");

            lblTotal.Text = total.ToString();
            lblOpen.Text = open.ToString();
            lblClose.Text = close.ToString();
        }

        private void ClearInputs()
        {
            txtJobTitle.Clear();
            cmbDepartment.SelectedIndex = -1;
            txtQualifications.Clear();
            numSlots.Value = 1;
            dtpDeadline.Value = DateTime.Today;
            cmbStatus.SelectedIndex = -1;
            editingJobVacancyID = -1;
        }

        private void LoadFilterComboBoxes()
        {
            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.Add("");
            cmbFilterStatus.Items.Add("Open");
            cmbFilterStatus.Items.Add("Closed");
            cmbFilterStatus.SelectedIndex = 0;

            cmbFilterDepartment.Items.Clear();
            cmbFilterDepartment.Items.Add("");
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT DepartmentName FROM Departments ORDER BY DepartmentName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    cmbFilterDepartment.Items.Add(reader["DepartmentName"].ToString());
                reader.Close();
            }
            cmbFilterDepartment.SelectedIndex = 0;
        }

        private void LoadDepartmentComboBox()
        {
            cmbDepartment.Items.Clear();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT DepartmentName FROM Departments ORDER BY DepartmentName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    cmbDepartment.Items.Add(reader["DepartmentName"].ToString());
                reader.Close();
            }
        }

        private void LoadVacancies()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT
                            jv.JobVacancyID,
                            jv.JobTitle AS 'Job Title',
                            d.DepartmentName AS 'Department',
                            jv.Qualifications,
                            jv.VacancyCount AS 'Slots',
                            jv.Status,
                            jv.DatePosted AS 'Date Posted'
                        FROM JobVacancies jv
                        JOIN Departments d ON jv.DepartmentID = d.DepartmentID
                        ORDER BY jv.DatePosted DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    dtVacancies = new DataTable();
                    adapter.Fill(dtVacancies);

                    dataGridView1.DataSource = dtVacancies;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.MultiSelect = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Hide ID column
                    if (dataGridView1.Columns["JobVacancyID"] != null)
                        dataGridView1.Columns["JobVacancyID"].Visible = false;

                    UpdateStats();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vacancies: " + ex.Message);
            }
        }

        public FormHRJobVacancyManagement()
        {
            InitializeComponent();
        }

        private void JobVacancyManagement_Load(object sender, EventArgs e)
        {
            SetRoundedPanel(panelTotal, 20);
            SetRoundedPanel(panelOpen, 20);
            SetRoundedPanel(panelClose, 20);
            SetRoundedPanel(panelVacancy, 20);

            btnExitVacancy.FlatStyle = FlatStyle.Flat;
            btnExitVacancy.FlatAppearance.BorderSize = 0;

            this.MaximizeBox = false;
            this.AutoScroll = true;

            panelVacancy.Visible = false;

            LoadFilterComboBoxes();
            LoadDepartmentComboBox();
            LoadVacancies();

            txtSearchbar.TextChanged += (s, ev) => ApplyFilters();
            cmbFilterStatus.SelectedIndexChanged += (s, ev) => ApplyFilters();
            cmbFilterDepartment.SelectedIndexChanged += (s, ev) => ApplyFilters();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearInputs();
            label13.Text = "Add New Vacancy";
            panelVacancy.Visible = true;
        }

        private void btnExitVacancy_Click(object sender, EventArgs e)
        {
            panelVacancy.Visible = false;
            ClearInputs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("Please enter a job title."); return;
            }
            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department."); return;
            }
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status."); return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Get DepartmentID
                    string deptQuery = "SELECT DepartmentID FROM Departments WHERE DepartmentName = @Name";
                    MySqlCommand deptCmd = new MySqlCommand(deptQuery, conn);
                    deptCmd.Parameters.AddWithValue("@Name", cmbDepartment.SelectedItem.ToString());
                    int departmentID = Convert.ToInt32(deptCmd.ExecuteScalar());

                    if (editingJobVacancyID == -1)
                    {
                        // INSERT new vacancy
                        string insertQuery = @"
                            INSERT INTO JobVacancies 
                            (DepartmentID, JobTitle, Qualifications, VacancyCount, Status)
                            VALUES 
                            (@DeptID, @JobTitle, @Qualifications, @VacancyCount, @Status)";

                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@DeptID", departmentID);
                        cmd.Parameters.AddWithValue("@JobTitle", txtJobTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@Qualifications", txtQualifications.Text.Trim());
                        cmd.Parameters.AddWithValue("@VacancyCount", (int)numSlots.Value);
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Job vacancy added successfully!");
                    }
                    else
                    {
                        // UPDATE existing vacancy
                        string updateQuery = @"
                            UPDATE JobVacancies SET
                                DepartmentID = @DeptID,
                                JobTitle = @JobTitle,
                                Qualifications = @Qualifications,
                                VacancyCount = @VacancyCount,
                                Status = @Status
                            WHERE JobVacancyID = @ID";

                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@DeptID", departmentID);
                        cmd.Parameters.AddWithValue("@JobTitle", txtJobTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@Qualifications", txtQualifications.Text.Trim());
                        cmd.Parameters.AddWithValue("@VacancyCount", (int)numSlots.Value);
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@ID", editingJobVacancyID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Job vacancy updated successfully!");
                    }
                }

                LoadVacancies();
                ClearInputs();
                panelVacancy.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving vacancy: " + ex.Message);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vacancy to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                editingJobVacancyID = Convert.ToInt32(selectedRow.Cells["JobVacancyID"].Value);
                txtJobTitle.Text = selectedRow.Cells["Job Title"].Value?.ToString();
                cmbDepartment.SelectedItem = selectedRow.Cells["Department"].Value?.ToString();
                txtQualifications.Text = selectedRow.Cells["Qualifications"].Value?.ToString();
                numSlots.Value = Convert.ToDecimal(selectedRow.Cells["Slots"].Value);
                cmbStatus.SelectedItem = selectedRow.Cells["Status"].Value?.ToString();

                label13.Text = "Edit Vacancy";
                panelVacancy.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panelClose_Paint(object sender, PaintEventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void tbxSearchbar_TextChanged(object sender, EventArgs e) { }
        private void comboStatuses_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboDepartment_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}