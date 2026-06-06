namespace WinForms_Interview
{
    partial class FormInterviewSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvApplications = new DataGridView();
            lblType = new Label();
            cboInterviewType = new ComboBox();
            lblDate = new Label();
            dtInterviewDate = new DateTimePicker();
            lblInterviewer = new Label();
            txtInterviewer = new TextBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            btnSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvApplications).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Interview Schedule";
            // 
            // dgvApplications
            // 
            dgvApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplications.Location = new Point(12, 42);
            dgvApplications.Name = "dgvApplications";
            dgvApplications.RowHeadersWidth = 51;
            dgvApplications.Size = new Size(926, 214);
            dgvApplications.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 268);
            lblType.Name = "lblType";
            lblType.Size = new Size(107, 20);
            lblType.TabIndex = 2;
            lblType.Text = "Interview Type:";
            // 
            // cboInterviewType
            // 
            cboInterviewType.FormattingEnabled = true;
            cboInterviewType.Location = new Point(132, 268);
            cboInterviewType.Name = "cboInterviewType";
            cboInterviewType.Size = new Size(151, 28);
            cboInterviewType.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(11, 311);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Interview Date:";
            // 
            // dtInterviewDate
            // 
            dtInterviewDate.Location = new Point(132, 311);
            dtInterviewDate.Name = "dtInterviewDate";
            dtInterviewDate.Size = new Size(250, 27);
            dtInterviewDate.TabIndex = 5;
            // 
            // lblInterviewer
            // 
            lblInterviewer.AutoSize = true;
            lblInterviewer.Location = new Point(12, 357);
            lblInterviewer.Name = "lblInterviewer";
            lblInterviewer.Size = new Size(85, 20);
            lblInterviewer.TabIndex = 6;
            lblInterviewer.Text = "Interviewer:";
            // 
            // txtInterviewer
            // 
            txtInterviewer.Location = new Point(132, 357);
            txtInterviewer.Name = "txtInterviewer";
            txtInterviewer.Size = new Size(125, 27);
            txtInterviewer.TabIndex = 7;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(12, 404);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(114, 20);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Mode/Location:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(132, 401);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 9;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(385, 473);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(201, 29);
            btnSchedule.TabIndex = 10;
            btnSchedule.Text = "Schedule Interview";
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // FormInterviewSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(950, 514);
            Controls.Add(btnSchedule);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(txtInterviewer);
            Controls.Add(lblInterviewer);
            Controls.Add(dtInterviewDate);
            Controls.Add(lblDate);
            Controls.Add(cboInterviewType);
            Controls.Add(lblType);
            Controls.Add(dgvApplications);
            Controls.Add(lblTitle);
            Name = "FormInterviewSchedule";
            Text = "FormInterviewSchedule";
            ((System.ComponentModel.ISupportInitialize)dgvApplications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvApplications;
        private Label lblType;
        private ComboBox cboInterviewType;
        private Label lblDate;
        private DateTimePicker dtInterviewDate;
        private Label lblInterviewer;
        private TextBox txtInterviewer;
        private Label lblLocation;
        private TextBox txtLocation;
        private Button btnSchedule;
    }
}