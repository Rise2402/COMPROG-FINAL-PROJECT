namespace FINAL_PROJECT.FORMS
{
    partial class FormHRInterviewSchedule
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.lblType = new System.Windows.Forms.Label();
            this.cboInterviewType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtInterviewDate = new System.Windows.Forms.DateTimePicker();
            this.lblInterviewer = new System.Windows.Forms.Label();
            this.txtInterviewer = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(9, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Interview Schedule";
            // 
            // dgvApplications
            // 
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Location = new System.Drawing.Point(9, 40);
            this.dgvApplications.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersWidth = 51;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(694, 139);
            this.dgvApplications.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(9, 185);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(80, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Interview Type:";
            // 
            // cboInterviewType
            // 
            this.cboInterviewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterviewType.FormattingEnabled = true;
            this.cboInterviewType.Location = new System.Drawing.Point(112, 183);
            this.cboInterviewType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboInterviewType.Name = "cboInterviewType";
            this.cboInterviewType.Size = new System.Drawing.Size(151, 21);
            this.cboInterviewType.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 213);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Interview Date:";
            // 
            // dtInterviewDate
            // 
            this.dtInterviewDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtInterviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInterviewDate.Location = new System.Drawing.Point(112, 211);
            this.dtInterviewDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtInterviewDate.Name = "dtInterviewDate";
            this.dtInterviewDate.ShowUpDown = true;
            this.dtInterviewDate.Size = new System.Drawing.Size(188, 20);
            this.dtInterviewDate.TabIndex = 5;
            // 
            // lblInterviewer
            // 
            this.lblInterviewer.AutoSize = true;
            this.lblInterviewer.Location = new System.Drawing.Point(9, 240);
            this.lblInterviewer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterviewer.Name = "lblInterviewer";
            this.lblInterviewer.Size = new System.Drawing.Size(62, 13);
            this.lblInterviewer.TabIndex = 6;
            this.lblInterviewer.Text = "Interviewer:";
            // 
            // txtInterviewer
            // 
            this.txtInterviewer.Location = new System.Drawing.Point(112, 239);
            this.txtInterviewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInterviewer.Name = "txtInterviewer";
            this.txtInterviewer.Size = new System.Drawing.Size(151, 20);
            this.txtInterviewer.TabIndex = 7;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 269);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 13);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Mode/Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(112, 267);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(151, 20);
            this.txtLocation.TabIndex = 9;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(262, 299);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(151, 25);
            this.btnSchedule.TabIndex = 10;
            this.btnSchedule.Text = "Schedule Interview";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // FormHRInterviewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 338);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtInterviewer);
            this.Controls.Add(this.lblInterviewer);
            this.Controls.Add(this.dtInterviewDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboInterviewType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHRInterviewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interview Schedule";
            this.Load += new System.EventHandler(this.FormHRInterviewSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboInterviewType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtInterviewDate;
        private System.Windows.Forms.Label lblInterviewer;
        private System.Windows.Forms.TextBox txtInterviewer;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSchedule;
    }
}