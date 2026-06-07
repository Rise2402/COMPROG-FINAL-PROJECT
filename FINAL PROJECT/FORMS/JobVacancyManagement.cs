using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT.FORMS
{

    public partial class JobVacancyManagement : Form
    {

        DataTable dtVacancies = new DataTable();

        private void SetRoundedPanel(Panel panel, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
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

            if (filtered.Any())
                dataGridView1.DataSource = filtered.CopyToDataTable();
            else
                dataGridView1.DataSource = dtVacancies.Clone();
        }
        private void UpdateStats()
        {
            int total = dtVacancies.Rows.Count;
            int open = dtVacancies.AsEnumerable().Count(r => r["Status"].ToString() == "Open");
            int draft = dtVacancies.AsEnumerable().Count(r => r["Status"].ToString() == "Draft");
            int close = dtVacancies.AsEnumerable().Count(r => r["Status"].ToString() == "Close");

            lblTotal.Text = total.ToString();
            lblOpen.Text = open.ToString();
            lblDraft.Text = draft.ToString();
            lblClose.Text = close.ToString();
        }

        private void ClearInputs()
        {
            txtJobTitle.Clear();
            cmbDepartment.SelectedIndex = -1;
            txtQualifications.Clear();
            numSlots.Value = 1;
            dtpDeadline.Value = dtpDeadline.MinDate;
            cmbStatus.SelectedIndex = -1;
        }

        private void LoadFilterComboBoxes()
        {
            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.Add("");       
            cmbFilterStatus.Items.Add("Open");
            cmbFilterStatus.Items.Add("Draft");
            cmbFilterStatus.Items.Add("Closed");
            cmbFilterStatus.SelectedIndex = 0;

            cmbFilterDepartment.Items.Clear();
            cmbFilterDepartment.Items.Add("");    
            cmbFilterDepartment.Items.Add("Engineering");
            cmbFilterDepartment.Items.Add("HR");
            cmbFilterDepartment.Items.Add("Finance");
            cmbFilterDepartment.Items.Add("Operations");
            cmbFilterDepartment.SelectedIndex = 0;
        }

        public JobVacancyManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void JobVacancyManagement_Load(object sender, EventArgs e)
        {
            SetRoundedPanel(panelTotal, 20);
            SetRoundedPanel(panelOpen, 20);
            SetRoundedPanel(panelDraft, 20);
            SetRoundedPanel(panelClose, 20);
            SetRoundedPanel(panelVacancy, 20);


            btnExitVacancy.FlatStyle = FlatStyle.Flat;
            btnExitVacancy.FlatAppearance.BorderSize = 0;

            this.MaximizeBox = false;
            this.Height = 700;
            this.AutoScroll = true;

            panelVacancy.Visible = false;

            LoadFilterComboBoxes();
            UpdateStats();

            dataGridView1.AutoGenerateColumns = true;
            txtSearchbar.TextChanged += (s, ev) => ApplyFilters();
            cmbFilterStatus.SelectedIndexChanged += (s, ev) => ApplyFilters();
            cmbFilterDepartment.SelectedIndexChanged += (s, ev) => ApplyFilters();

            dtVacancies.Columns.Add("Job Title");
            dtVacancies.Columns.Add("Department");
            dtVacancies.Columns.Add("Qualifications");
            dtVacancies.Columns.Add("Slots");
            dtVacancies.Columns.Add("Deadline");
            dtVacancies.Columns.Add("Status");

            dataGridView1.DataSource = dtVacancies;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelClose_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelVacancy.Visible = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnExitVacancy_Click(object sender, EventArgs e)
        {
            panelVacancy.Visible = false;
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

            dtVacancies.Rows.Add(
                txtJobTitle.Text,
                cmbDepartment.SelectedItem.ToString(),
                txtQualifications.Text,
                (int)numSlots.Value,
                dtpDeadline.Value.ToString("MM/dd/yyyy"),
                cmbStatus.SelectedItem.ToString()
            );

            dataGridView1.DataSource = dtVacancies;
            UpdateStats();
            ClearInputs();
        }

        private void tbxSearchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
