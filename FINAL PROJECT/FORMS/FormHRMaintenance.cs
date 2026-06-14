using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormHRMaintenance : Form
    {
        // Tracks selected IDs per tab
        private int _selectedDeptID = 0;
        private int _selectedEmpTypeID = 0;
        private int _selectedReqTypeID = 0;
        private int _selectedIntTypeID = 0;
        private int _selectedAssessTypeID = 0;

        public FormHRMaintenance()
        {
            InitializeComponent();
        }

        private void FormHRMaintenance_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadEmploymentTypes();
            LoadRequirementTypes();
            LoadInterviewTypes();
            LoadAssessmentTypes();

            WireSelection(dgvDepartments, "DepartmentID", ref _selectedDeptID, txtDeptName, "DepartmentName");
            WireSelection(dgvEmploymentTypes, "EmploymentTypeID", ref _selectedEmpTypeID, txtEmpTypeName, "EmploymentTypeName");
            WireSelection(dgvRequirementTypes, "RequirementTypeID", ref _selectedReqTypeID, txtReqTypeName, "RequirementName");
            WireSelection(dgvInterviewTypes, "InterviewTypeID", ref _selectedIntTypeID, txtIntTypeName, "InterviewTypeName");
            WireSelection(dgvAssessmentTypes, "AssessmentTypeID", ref _selectedAssessTypeID, txtAssessTypeName, "AssessmentName");
        }

        // ── Generic selection wirer ───────────────────────────────────
        private void WireSelection(DataGridView dgv, string idCol, ref int idField,
                                   TextBox txt, string nameCol)
        {
            // capture ref as local for lambda
            var idRef = idField;
            dgv.SelectionChanged += (s, e) =>
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    var row = dgv.SelectedRows[0];
                    if (row.Cells[idCol].Value != null)
                    {
                        // update the correct field via the grid's Tag
                        int val = Convert.ToInt32(row.Cells[idCol].Value);
                        SetSelectedID(dgv, val);
                        txt.Text = row.Cells[nameCol].Value?.ToString();
                    }
                }
            };
            dgv.Tag = idField; // used as identity marker
        }

        private void SetSelectedID(DataGridView dgv, int val)
        {
            if (dgv == dgvDepartments) _selectedDeptID = val;
            else if (dgv == dgvEmploymentTypes) _selectedEmpTypeID = val;
            else if (dgv == dgvRequirementTypes) _selectedReqTypeID = val;
            else if (dgv == dgvInterviewTypes) _selectedIntTypeID = val;
            else if (dgv == dgvAssessmentTypes) _selectedAssessTypeID = val;
        }

        // 
        //  LOAD METHODS
        // 
        private void LoadDepartments()
        {
            LoadGrid(dgvDepartments,
                "SELECT DepartmentID, DepartmentName FROM Departments ORDER BY DepartmentName");
        }

        private void LoadEmploymentTypes()
        {
            LoadGrid(dgvEmploymentTypes,
                "SELECT EmploymentTypeID, EmploymentTypeName FROM EmploymentTypes ORDER BY EmploymentTypeName");
        }

        private void LoadRequirementTypes()
        {
            LoadGrid(dgvRequirementTypes,
                "SELECT RequirementTypeID, RequirementName FROM RequirementTypes ORDER BY RequirementName");
        }

        private void LoadInterviewTypes()
        {
            LoadGrid(dgvInterviewTypes,
                "SELECT InterviewTypeID, InterviewTypeName FROM InterviewTypes ORDER BY InterviewTypeName");
        }

        private void LoadAssessmentTypes()
        {
            LoadGrid(dgvAssessmentTypes,
                "SELECT AssessmentTypeID, AssessmentName FROM AssessmentTypes ORDER BY AssessmentName");
        }

        private void LoadGrid(DataGridView dgv, string sql)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var adapter = new MySqlDataAdapter(sql, conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;

                    // Hide ID column
                    if (dgv.Columns.Count > 0)
                        dgv.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        //
        //  DEPARTMENTS
        //
        private void btnDeptAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeptName.Text)) { MessageBox.Show("Enter a department name."); return; }
            ExecuteNonQuery(
                "INSERT INTO Departments (DepartmentName) VALUES (@Name)",
                new[] { ("@Name", txtDeptName.Text.Trim()) });
            LoadDepartments(); ClearDept();
        }

        private void btnDeptUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedDeptID == 0) { MessageBox.Show("Select a department first."); return; }
            if (string.IsNullOrWhiteSpace(txtDeptName.Text)) { MessageBox.Show("Enter a department name."); return; }
            ExecuteNonQuery(
                "UPDATE Departments SET DepartmentName = @Name WHERE DepartmentID = @ID",
                new[] { ("@Name", txtDeptName.Text.Trim()), ("@ID", _selectedDeptID.ToString()) });
            LoadDepartments(); ClearDept();
        }

        private void btnDeptDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDeptID == 0) { MessageBox.Show("Select a department first."); return; }
            if (MessageBox.Show("Delete this department?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            ExecuteNonQuery(
                "DELETE FROM Departments WHERE DepartmentID = @ID",
                new[] { ("@ID", _selectedDeptID.ToString()) });
            LoadDepartments(); ClearDept();
        }

        private void btnDeptClear_Click(object sender, EventArgs e) => ClearDept();
        private void ClearDept() { txtDeptName.Clear(); _selectedDeptID = 0; dgvDepartments.ClearSelection(); }

        // 
        //  EMPLOYMENT TYPES
        //
        private void btnEmpTypeAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpTypeName.Text)) { MessageBox.Show("Enter an employment type name."); return; }
            ExecuteNonQuery(
                "INSERT INTO EmploymentTypes (EmploymentTypeName) VALUES (@Name)",
                new[] { ("@Name", txtEmpTypeName.Text.Trim()) });
            LoadEmploymentTypes(); ClearEmpType();
        }

        private void btnEmpTypeUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedEmpTypeID == 0) { MessageBox.Show("Select an employment type first."); return; }
            if (string.IsNullOrWhiteSpace(txtEmpTypeName.Text)) { MessageBox.Show("Enter an employment type name."); return; }
            ExecuteNonQuery(
                "UPDATE EmploymentTypes SET EmploymentTypeName = @Name WHERE EmploymentTypeID = @ID",
                new[] { ("@Name", txtEmpTypeName.Text.Trim()), ("@ID", _selectedEmpTypeID.ToString()) });
            LoadEmploymentTypes(); ClearEmpType();
        }

        private void btnEmpTypeDelete_Click(object sender, EventArgs e)
        {
            if (_selectedEmpTypeID == 0) { MessageBox.Show("Select an employment type first."); return; }
            if (MessageBox.Show("Delete this employment type?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            ExecuteNonQuery(
                "DELETE FROM EmploymentTypes WHERE EmploymentTypeID = @ID",
                new[] { ("@ID", _selectedEmpTypeID.ToString()) });
            LoadEmploymentTypes(); ClearEmpType();
        }

        private void btnEmpTypeClear_Click(object sender, EventArgs e) => ClearEmpType();
        private void ClearEmpType() { txtEmpTypeName.Clear(); _selectedEmpTypeID = 0; dgvEmploymentTypes.ClearSelection(); }

        //
        //  REQUIREMENT TYPES
        // 
        private void btnReqTypeAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReqTypeName.Text)) { MessageBox.Show("Enter a requirement name."); return; }
            ExecuteNonQuery(
                "INSERT INTO RequirementTypes (RequirementName) VALUES (@Name)",
                new[] { ("@Name", txtReqTypeName.Text.Trim()) });
            LoadRequirementTypes(); ClearReqType();
        }

        private void btnReqTypeUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedReqTypeID == 0) { MessageBox.Show("Select a requirement type first."); return; }
            if (string.IsNullOrWhiteSpace(txtReqTypeName.Text)) { MessageBox.Show("Enter a requirement name."); return; }
            ExecuteNonQuery(
                "UPDATE RequirementTypes SET RequirementName = @Name WHERE RequirementTypeID = @ID",
                new[] { ("@Name", txtReqTypeName.Text.Trim()), ("@ID", _selectedReqTypeID.ToString()) });
            LoadRequirementTypes(); ClearReqType();
        }

        private void btnReqTypeDelete_Click(object sender, EventArgs e)
        {
            if (_selectedReqTypeID == 0) { MessageBox.Show("Select a requirement type first."); return; }
            if (MessageBox.Show("Delete this requirement type?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            ExecuteNonQuery(
                "DELETE FROM RequirementTypes WHERE RequirementTypeID = @ID",
                new[] { ("@ID", _selectedReqTypeID.ToString()) });
            LoadRequirementTypes(); ClearReqType();
        }

        private void btnReqTypeClear_Click(object sender, EventArgs e) => ClearReqType();
        private void ClearReqType() { txtReqTypeName.Clear(); _selectedReqTypeID = 0; dgvRequirementTypes.ClearSelection(); }

        //
        //  INTERVIEW TYPES
        //
        private void btnIntTypeAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIntTypeName.Text)) { MessageBox.Show("Enter an interview type name."); return; }
            ExecuteNonQuery(
                "INSERT INTO InterviewTypes (InterviewTypeName) VALUES (@Name)",
                new[] { ("@Name", txtIntTypeName.Text.Trim()) });
            LoadInterviewTypes(); ClearIntType();
        }

        private void btnIntTypeUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedIntTypeID == 0) { MessageBox.Show("Select an interview type first."); return; }
            if (string.IsNullOrWhiteSpace(txtIntTypeName.Text)) { MessageBox.Show("Enter an interview type name."); return; }
            ExecuteNonQuery(
                "UPDATE InterviewTypes SET InterviewTypeName = @Name WHERE InterviewTypeID = @ID",
                new[] { ("@Name", txtIntTypeName.Text.Trim()), ("@ID", _selectedIntTypeID.ToString()) });
            LoadInterviewTypes(); ClearIntType();
        }

        private void btnIntTypeDelete_Click(object sender, EventArgs e)
        {
            if (_selectedIntTypeID == 0) { MessageBox.Show("Select an interview type first."); return; }
            if (MessageBox.Show("Delete this interview type?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            ExecuteNonQuery(
                "DELETE FROM InterviewTypes WHERE InterviewTypeID = @ID",
                new[] { ("@ID", _selectedIntTypeID.ToString()) });
            LoadInterviewTypes(); ClearIntType();
        }

        private void btnIntTypeClear_Click(object sender, EventArgs e) => ClearIntType();
        private void ClearIntType() { txtIntTypeName.Clear(); _selectedIntTypeID = 0; dgvInterviewTypes.ClearSelection(); }

        //  
        //  ASSESSMENT TYPES
        // 
        private void btnAssessTypeAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssessTypeName.Text)) { MessageBox.Show("Enter an assessment type name."); return; }
            ExecuteNonQuery(
                "INSERT INTO AssessmentTypes (AssessmentName) VALUES (@Name)",
                new[] { ("@Name", txtAssessTypeName.Text.Trim()) });
            LoadAssessmentTypes(); ClearAssessType();
        }

        private void btnAssessTypeUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedAssessTypeID == 0) { MessageBox.Show("Select an assessment type first."); return; }
            if (string.IsNullOrWhiteSpace(txtAssessTypeName.Text)) { MessageBox.Show("Enter an assessment type name."); return; }
            ExecuteNonQuery(
                "UPDATE AssessmentTypes SET AssessmentName = @Name WHERE AssessmentTypeID = @ID",
                new[] { ("@Name", txtAssessTypeName.Text.Trim()), ("@ID", _selectedAssessTypeID.ToString()) });
            LoadAssessmentTypes(); ClearAssessType();
        }

        private void btnAssessTypeDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAssessTypeID == 0) { MessageBox.Show("Select an assessment type first."); return; }
            if (MessageBox.Show("Delete this assessment type?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            ExecuteNonQuery(
                "DELETE FROM AssessmentTypes WHERE AssessmentTypeID = @ID",
                new[] { ("@ID", _selectedAssessTypeID.ToString()) });
            LoadAssessmentTypes(); ClearAssessType();
        }

        private void btnAssessTypeClear_Click(object sender, EventArgs e) => ClearAssessType();
        private void ClearAssessType() { txtAssessTypeName.Clear(); _selectedAssessTypeID = 0; dgvAssessmentTypes.ClearSelection(); }

        // 
        //  SHARED HELPER
        // 
        private void ExecuteNonQuery(string sql, (string param, string value)[] parameters)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(sql, conn);
                    foreach (var (param, value) in parameters)
                        cmd.Parameters.AddWithValue(param, value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e) => this.Close();
    }
}