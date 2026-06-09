using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormStatusHistory : Form
    {
        private int _applicationID;

        public FormStatusHistory(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
        }

        private void FormStatusHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            StatusName AS Status,
                            Remarks,
                            DateChanged AS Date
                        FROM ApplicationStatusHistory
                        WHERE ApplicationID = @AppID
                        ORDER BY DateChanged ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AppID", _applicationID);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHistory.DataSource = dt;
                    dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvHistory.ReadOnly = true;
                    dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message);
            }
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}