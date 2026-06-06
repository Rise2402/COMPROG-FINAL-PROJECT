using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormApplicantDocuments : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private string _selectedFilePath = "";

        public FormApplicantDocuments()
        {
            InitializeComponent();
        }

        private void FormApplicantDocuments_Load(object sender, EventArgs e)
        {
            LoadRequirementTypes();
            LoadDocuments();
        }

        private void LoadRequirementTypes()
        {
            try
            {
                txtRequirement.Items.Clear();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT RequirementTypeID, RequirementName FROM RequirementTypes";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtRequirement.Items.Add(new RequirementItem(
                            Convert.ToInt32(reader["RequirementTypeID"]),
                            reader["RequirementName"].ToString()
                        ));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requirements: " + ex.Message);
            }
        }

        private void LoadDocuments()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            ad.DocumentID,
                            ad.RequirementTypeID,
                            rt.RequirementName,
                            ad.FileName,
                            ad.SubmissionDate,
                            ad.Status,
                            ad.HRRemarks
                        FROM ApplicantDocuments ad
                        JOIN RequirementTypes rt ON ad.RequirementTypeID = rt.RequirementTypeID
                        WHERE ad.ApplicantID = @ApplicantID
                        ORDER BY ad.SubmissionDate DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ApplicantID", Session.ApplicantID);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(
                            reader["DocumentID"].ToString(),
                            reader["RequirementTypeID"].ToString(),
                            reader["RequirementName"].ToString(),
                            reader["FileName"].ToString(),
                            Convert.ToDateTime(reader["SubmissionDate"]).ToString("MM/dd/yyyy"),
                            reader["Status"].ToString(),
                            reader["HRRemarks"].ToString()
                        );
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message);
            }
        }

        // Browse button
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a Document";
            openFileDialog.Filter = "Documents (*.pdf;*.docx)|*.pdf;*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedFilePath = openFileDialog.FileName;
                txtFilePath.Text = Path.GetFileName(openFileDialog.FileName);
            }
        }

        // Upload button
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtRequirement.SelectedItem == null)
            {
                MessageBox.Show("Please select a requirement type.");
                return;
            }

            if (string.IsNullOrEmpty(_selectedFilePath))
            {
                MessageBox.Show("Please browse and select a file first.");
                return;
            }

            if (Session.ApplicantID == 0)
            {
                MessageBox.Show("Please complete your profile first.");
                return;
            }

            try
            {
                RequirementItem selected = (RequirementItem)txtRequirement.SelectedItem;
                string fileName = Path.GetFileName(_selectedFilePath);

                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Check if document already exists for this requirement
                    string checkQuery = @"
                        SELECT COUNT(*) FROM ApplicantDocuments 
                        WHERE ApplicantID = @ApplicantID 
                        AND RequirementTypeID = @RequirementTypeID";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ApplicantID", Session.ApplicantID);
                    checkCmd.Parameters.AddWithValue("@RequirementTypeID", selected.ID);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        MessageBox.Show("Document for this requirement already exists. Use Replace instead.");
                        return;
                    }

                    string insertQuery = @"
                        INSERT INTO ApplicantDocuments 
                        (ApplicantID, RequirementTypeID, FileName, FilePath, Status)
                        VALUES 
                        (@ApplicantID, @RequirementTypeID, @FileName, @FilePath, 'Submitted')";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@ApplicantID", Session.ApplicantID);
                    cmd.Parameters.AddWithValue("@RequirementTypeID", selected.ID);
                    cmd.Parameters.AddWithValue("@FileName", fileName);
                    cmd.Parameters.AddWithValue("@FilePath", _selectedFilePath);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Document uploaded successfully!");
                    txtFilePath.Text = "";
                    _selectedFilePath = "";
                    txtRequirement.SelectedIndex = -1;
                    LoadDocuments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading document: " + ex.Message);
            }
        }

        // View button
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a document to view.");
                return;
            }

            try
            {
                int documentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DocumentID"].Value);

                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT FilePath FROM ApplicantDocuments WHERE DocumentID = @ID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", documentID);
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        MessageBox.Show("No file path found in database.");
                        return;
                    }

                    string fullPath = result.ToString();

                    if (File.Exists(fullPath))
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.Arguments = $"/c start \"\" \"{fullPath}\"";
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.UseShellExecute = false;
                        process.Start();
                    }
                    else
                        MessageBox.Show("File not found: " + fullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
            }
        }

        // Delete button
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a document to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this document?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                int documentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DocumentID"].Value);

                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM ApplicantDocuments WHERE DocumentID = @ID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", documentID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Document deleted successfully!");
                    LoadDocuments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting document: " + ex.Message);
            }
        }

        // Replace button
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a document to replace.");
                return;
            }

            if (string.IsNullOrEmpty(_selectedFilePath))
            {
                MessageBox.Show("Please browse and select a new file first.");
                return;
            }

            try
            {
                int documentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DocumentID"].Value);
                string fileName = Path.GetFileName(_selectedFilePath);

                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        UPDATE ApplicantDocuments 
                        SET FileName = @FileName, FilePath = @FilePath, 
                            SubmissionDate = NOW(), Status = 'Submitted'
                        WHERE DocumentID = @ID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FileName", fileName);
                    cmd.Parameters.AddWithValue("@FilePath", _selectedFilePath);
                    cmd.Parameters.AddWithValue("@ID", documentID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Document replaced successfully!");
                    txtFilePath.Text = "";
                    _selectedFilePath = "";
                    LoadDocuments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error replacing document: " + ex.Message);
            }
        }

        // Close button
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void txtRequirement_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }

    // Helper class for ComboBox items
    public class RequirementItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public RequirementItem(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}