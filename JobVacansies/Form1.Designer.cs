namespace JobVacansies
{
    partial class frmJobVacancies
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblStatus = new Label();
            txtStatus = new TextBox();
            label1 = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvJobs = new DataGridView();
            grpJobList = new GroupBox();
            grpJobDetails = new GroupBox();
            rtbQualifications = new RichTextBox();
            txtEmploymentType = new TextBox();
            txtDepartment = new TextBox();
            txtPosition = new TextBox();
            lblQualifications = new Label();
            lblDepartment = new Label();
            lblPosition = new Label();
            lblEmploymentType = new Label();
            lblRequirements = new Label();
            lstRequirements = new ListBox();
            btnApply = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            grpJobList.SuspendLayout();
            grpJobDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(17, 165);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 23);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(225, 158);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(125, 30);
            txtStatus.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(31, 29, 122);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(288, 38);
            label1.TabIndex = 0;
            label1.Text = "JOB VACANCIES";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 53);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(74, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 29, 122);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(310, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvJobs
            // 
            dgvJobs.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 29, 122);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Dock = DockStyle.Fill;
            dgvJobs.EnableHeadersVisualStyles = false;
            dgvJobs.Location = new Point(3, 26);
            dgvJobs.MultiSelect = false;
            dgvJobs.Name = "dgvJobs";
            dgvJobs.RowHeadersVisible = false;
            dgvJobs.RowHeadersWidth = 51;
            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.Size = new Size(541, 178);
            dgvJobs.TabIndex = 4;
            dgvJobs.CellClick += dataGridView1_CellContentClick;
            // 
            // grpJobList
            // 
            grpJobList.Controls.Add(dgvJobs);
            grpJobList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpJobList.ForeColor = Color.FromArgb(31, 29, 122);
            grpJobList.Location = new Point(12, 104);
            grpJobList.Name = "grpJobList";
            grpJobList.Size = new Size(547, 207);
            grpJobList.TabIndex = 5;
            grpJobList.TabStop = false;
            grpJobList.Text = "Available Jobs";
            // 
            // grpJobDetails
            // 
            grpJobDetails.Controls.Add(rtbQualifications);
            grpJobDetails.Controls.Add(txtEmploymentType);
            grpJobDetails.Controls.Add(txtDepartment);
            grpJobDetails.Controls.Add(txtPosition);
            grpJobDetails.Controls.Add(lblQualifications);
            grpJobDetails.Controls.Add(lblDepartment);
            grpJobDetails.Controls.Add(lblPosition);
            grpJobDetails.Controls.Add(lblEmploymentType);
            grpJobDetails.Controls.Add(lblRequirements);
            grpJobDetails.Controls.Add(lstRequirements);
            grpJobDetails.Controls.Add(lblStatus);
            grpJobDetails.Controls.Add(txtStatus);
            grpJobDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpJobDetails.ForeColor = Color.FromArgb(31, 29, 122);
            grpJobDetails.Location = new Point(18, 328);
            grpJobDetails.Name = "grpJobDetails";
            grpJobDetails.Size = new Size(580, 360);
            grpJobDetails.TabIndex = 6;
            grpJobDetails.TabStop = false;
            grpJobDetails.Text = "Job Details";
            // 
            // rtbQualifications
            // 
            rtbQualifications.Location = new Point(17, 230);
            rtbQualifications.Name = "rtbQualifications";
            rtbQualifications.ReadOnly = true;
            rtbQualifications.Size = new Size(524, 134);
            rtbQualifications.TabIndex = 9;
            rtbQualifications.Text = "";
            rtbQualifications.TextChanged += rtbQualifications_TextChanged;
            // 
            // txtEmploymentType
            // 
            txtEmploymentType.Location = new Point(225, 118);
            txtEmploymentType.Name = "txtEmploymentType";
            txtEmploymentType.ReadOnly = true;
            txtEmploymentType.Size = new Size(125, 30);
            txtEmploymentType.TabIndex = 12;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(225, 72);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(125, 30);
            txtDepartment.TabIndex = 12;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(225, 28);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(125, 30);
            txtPosition.TabIndex = 11;
            // 
            // lblQualifications
            // 
            lblQualifications.AutoSize = true;
            lblQualifications.Location = new Point(17, 205);
            lblQualifications.Name = "lblQualifications";
            lblQualifications.Size = new Size(125, 23);
            lblQualifications.TabIndex = 10;
            lblQualifications.Text = "Qualifications:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(17, 79);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(113, 23);
            lblDepartment.TabIndex = 8;
            lblDepartment.Text = "Department:";
            lblDepartment.Click += label4_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(17, 35);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(78, 23);
            lblPosition.TabIndex = 7;
            lblPosition.Text = "Position:";
            lblPosition.Click += label3_Click;
            // 
            // lblEmploymentType
            // 
            lblEmploymentType.AutoSize = true;
            lblEmploymentType.Location = new Point(17, 125);
            lblEmploymentType.Name = "lblEmploymentType";
            lblEmploymentType.Size = new Size(165, 23);
            lblEmploymentType.TabIndex = 9;
            lblEmploymentType.Text = "Employment Type: ";
            // 
            // lblRequirements
            // 
            lblRequirements.AutoSize = true;
            lblRequirements.Location = new Point(380, 30);
            lblRequirements.Name = "lblRequirements";
            lblRequirements.Size = new Size(183, 23);
            lblRequirements.TabIndex = 13;
            lblRequirements.Text = "Required Documents:";
            // 
            // lstRequirements
            // 
            lstRequirements.FormattingEnabled = true;
            lstRequirements.Location = new Point(380, 55);
            lstRequirements.Name = "lstRequirements";
            lstRequirements.Size = new Size(170, 96);
            lstRequirements.TabIndex = 13;
            lstRequirements.SelectedIndexChanged += lstRequirements_SelectedIndexChanged;
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.FromArgb(31, 29, 122);
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(200, 705);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(200, 50);
            btnApply.TabIndex = 8;
            btnApply.Text = "Apply Now";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // frmJobVacancies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(883, 759);
            Controls.Add(btnApply);
            Controls.Add(grpJobDetails);
            Controls.Add(grpJobList);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(label1);
            Name = "frmJobVacancies";
            Text = "Job Vacansies";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            grpJobList.ResumeLayout(false);
            grpJobDetails.ResumeLayout(false);
            grpJobDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvJobs;
        private GroupBox grpJobList;
        private GroupBox grpJobDetails;
        private Label lblQualifications;
        private Label lblEmploymentType;
        private TextBox txtEmploymentType;
        private Label lblDepartment;
        private TextBox txtDepartment;
        private TextBox txtPosition;
        private Label lblPosition;
        private RichTextBox rtbQualifications;
        private Label lblRequirements;
        private ListBox lstRequirements;
        private Button btnApply;
        private Label lblStatus;
        private TextBox txtStatus;
    }
}
