namespace FINAL_PROJECT.FORMS
{
    partial class FormJobVacancies
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.grpJobList = new System.Windows.Forms.GroupBox();
            this.grpJobDetails = new System.Windows.Forms.GroupBox();
            this.rtbQualifications = new System.Windows.Forms.RichTextBox();
            this.txtEmploymentType = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblQualifications = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEmploymentType = new System.Windows.Forms.Label();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.lstRequirements = new System.Windows.Forms.ListBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.grpJobList.SuspendLayout();
            this.grpJobDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 107);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(159, 102);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(137, 23);
            this.txtStatus.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOB VACANCIES";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 41);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(51, 38);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(122)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(230, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 19);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvJobs
            // 
            this.dgvJobs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJobs.EnableHeadersVisualStyles = false;
            this.dgvJobs.Location = new System.Drawing.Point(2, 18);
            this.dgvJobs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvJobs.MultiSelect = false;
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersVisible = false;
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(406, 115);
            this.dgvJobs.TabIndex = 4;
            this.dgvJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            // 
            // grpJobList
            // 
            this.grpJobList.Controls.Add(this.dgvJobs);
            this.grpJobList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJobList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(122)))));
            this.grpJobList.Location = new System.Drawing.Point(9, 67);
            this.grpJobList.Margin = new System.Windows.Forms.Padding(2);
            this.grpJobList.Name = "grpJobList";
            this.grpJobList.Padding = new System.Windows.Forms.Padding(2);
            this.grpJobList.Size = new System.Drawing.Size(410, 135);
            this.grpJobList.TabIndex = 5;
            this.grpJobList.TabStop = false;
            this.grpJobList.Text = "Available Jobs";
            // 
            // grpJobDetails
            // 
            this.grpJobDetails.Controls.Add(this.rtbQualifications);
            this.grpJobDetails.Controls.Add(this.txtEmploymentType);
            this.grpJobDetails.Controls.Add(this.txtDepartment);
            this.grpJobDetails.Controls.Add(this.txtPosition);
            this.grpJobDetails.Controls.Add(this.lblQualifications);
            this.grpJobDetails.Controls.Add(this.lblDepartment);
            this.grpJobDetails.Controls.Add(this.lblPosition);
            this.grpJobDetails.Controls.Add(this.lblEmploymentType);
            this.grpJobDetails.Controls.Add(this.lblRequirements);
            this.grpJobDetails.Controls.Add(this.lstRequirements);
            this.grpJobDetails.Controls.Add(this.lblStatus);
            this.grpJobDetails.Controls.Add(this.txtStatus);
            this.grpJobDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpJobDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(122)))));
            this.grpJobDetails.Location = new System.Drawing.Point(14, 213);
            this.grpJobDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpJobDetails.Name = "grpJobDetails";
            this.grpJobDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpJobDetails.Size = new System.Drawing.Size(575, 234);
            this.grpJobDetails.TabIndex = 6;
            this.grpJobDetails.TabStop = false;
            this.grpJobDetails.Text = "Job Details";
            // 
            // rtbQualifications
            // 
            this.rtbQualifications.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQualifications.Location = new System.Drawing.Point(13, 154);
            this.rtbQualifications.Margin = new System.Windows.Forms.Padding(2);
            this.rtbQualifications.Name = "rtbQualifications";
            this.rtbQualifications.ReadOnly = true;
            this.rtbQualifications.Size = new System.Drawing.Size(394, 88);
            this.rtbQualifications.TabIndex = 9;
            this.rtbQualifications.Text = "";
            // 
            // txtEmploymentType
            // 
            this.txtEmploymentType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmploymentType.Location = new System.Drawing.Point(159, 76);
            this.txtEmploymentType.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmploymentType.Name = "txtEmploymentType";
            this.txtEmploymentType.ReadOnly = true;
            this.txtEmploymentType.Size = new System.Drawing.Size(137, 23);
            this.txtEmploymentType.TabIndex = 12;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(159, 47);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(137, 23);
            this.txtDepartment.TabIndex = 12;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(159, 18);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(137, 23);
            this.txtPosition.TabIndex = 11;
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Location = new System.Drawing.Point(13, 133);
            this.lblQualifications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(104, 19);
            this.lblQualifications.TabIndex = 10;
            this.lblQualifications.Text = "Qualifications:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(13, 51);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(93, 19);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(13, 23);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(67, 19);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Position:";
            // 
            // lblEmploymentType
            // 
            this.lblEmploymentType.AutoSize = true;
            this.lblEmploymentType.Location = new System.Drawing.Point(13, 81);
            this.lblEmploymentType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmploymentType.Name = "lblEmploymentType";
            this.lblEmploymentType.Size = new System.Drawing.Size(137, 19);
            this.lblEmploymentType.TabIndex = 9;
            this.lblEmploymentType.Text = "Employment Type: ";
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Location = new System.Drawing.Point(316, 20);
            this.lblRequirements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(152, 19);
            this.lblRequirements.TabIndex = 13;
            this.lblRequirements.Text = "Required Documents:";
            // 
            // lstRequirements
            // 
            this.lstRequirements.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRequirements.FormattingEnabled = true;
            this.lstRequirements.ItemHeight = 15;
            this.lstRequirements.Location = new System.Drawing.Point(320, 41);
            this.lstRequirements.Margin = new System.Windows.Forms.Padding(2);
            this.lstRequirements.Name = "lstRequirements";
            this.lstRequirements.Size = new System.Drawing.Size(184, 94);
            this.lstRequirements.TabIndex = 13;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(122)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(150, 458);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(150, 32);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply Now";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(632, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(19, 18);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "X";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // FormJobVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(662, 493);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpJobDetails);
            this.Controls.Add(this.grpJobList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormJobVacancies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Vacancies";
            this.Load += new System.EventHandler(this.FormJobVacancies_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.grpJobList.ResumeLayout(false);
            this.grpJobDetails.ResumeLayout(false);
            this.grpJobDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.GroupBox grpJobList;
        private System.Windows.Forms.GroupBox grpJobDetails;
        private System.Windows.Forms.Label lblQualifications;
        private System.Windows.Forms.Label lblEmploymentType;
        private System.Windows.Forms.TextBox txtEmploymentType;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.RichTextBox rtbQualifications;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.ListBox lstRequirements;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label btnexit;
    }
}