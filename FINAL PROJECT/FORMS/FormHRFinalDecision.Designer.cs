namespace FINAL_PROJECT.FORMS
{
    partial class FormHRFinalDecision
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSearchApplicant = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpApplicants = new System.Windows.Forms.GroupBox();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.colApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApplicantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterviewResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpApplicantInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpInterviewEvaluation = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInterviewScore = new System.Windows.Forms.TextBox();
            this.txtInterviewResult = new System.Windows.Forms.TextBox();
            this.rtbInterviewRemarks = new System.Windows.Forms.RichTextBox();
            this.grpFinalDecision = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDecision = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbRemarks = new System.Windows.Forms.RichTextBox();
            this.btnSaveDecision = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.grpApplicantInfo.SuspendLayout();
            this.grpInterviewEvaluation.SuspendLayout();
            this.grpFinalDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "FINAL HIRING DECISION";
            // 
            // lblSearchApplicant
            // 
            this.lblSearchApplicant.AutoSize = true;
            this.lblSearchApplicant.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSearchApplicant.Location = new System.Drawing.Point(12, 49);
            this.lblSearchApplicant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchApplicant.Name = "lblSearchApplicant";
            this.lblSearchApplicant.Size = new System.Drawing.Size(91, 13);
            this.lblSearchApplicant.TabIndex = 1;
            this.lblSearchApplicant.Text = "Search Applicant:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(110, 46);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(267, 45);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpApplicants
            // 
            this.grpApplicants.Controls.Add(this.dgvApplicants);
            this.grpApplicants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpApplicants.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpApplicants.Location = new System.Drawing.Point(9, 72);
            this.grpApplicants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicants.Name = "grpApplicants";
            this.grpApplicants.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicants.Size = new System.Drawing.Size(645, 150);
            this.grpApplicants.TabIndex = 4;
            this.grpApplicants.TabStop = false;
            this.grpApplicants.Text = "Qualified Applicants (For Final Review)";
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApplicationID,
            this.colApplicantName,
            this.colPosition,
            this.colInterviewResult,
            this.colScore});
            this.dgvApplicants.EnableHeadersVisualStyles = false;
            this.dgvApplicants.Location = new System.Drawing.Point(3, 16);
            this.dgvApplicants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvApplicants.MultiSelect = false;
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.ReadOnly = true;
            this.dgvApplicants.RowHeadersVisible = false;
            this.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicants.Size = new System.Drawing.Size(638, 129);
            this.dgvApplicants.TabIndex = 0;
            // 
            // colApplicationID
            // 
            this.colApplicationID.HeaderText = "ApplicationID";
            this.colApplicationID.Name = "colApplicationID";
            this.colApplicationID.ReadOnly = true;
            this.colApplicationID.Visible = false;
            // 
            // colApplicantName
            // 
            this.colApplicantName.HeaderText = "Applicant Name";
            this.colApplicantName.Name = "colApplicantName";
            this.colApplicantName.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colInterviewResult
            // 
            this.colInterviewResult.HeaderText = "Interview Result";
            this.colInterviewResult.Name = "colInterviewResult";
            this.colInterviewResult.ReadOnly = true;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "Score";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            // 
            // grpApplicantInfo
            // 
            this.grpApplicantInfo.Controls.Add(this.label4);
            this.grpApplicantInfo.Controls.Add(this.label5);
            this.grpApplicantInfo.Controls.Add(this.label6);
            this.grpApplicantInfo.Controls.Add(this.label7);
            this.grpApplicantInfo.Controls.Add(this.txtApplicantName);
            this.grpApplicantInfo.Controls.Add(this.txtPosition);
            this.grpApplicantInfo.Controls.Add(this.txtContactNumber);
            this.grpApplicantInfo.Controls.Add(this.txtEmail);
            this.grpApplicantInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpApplicantInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpApplicantInfo.Location = new System.Drawing.Point(9, 231);
            this.grpApplicantInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicantInfo.Name = "grpApplicantInfo";
            this.grpApplicantInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpApplicantInfo.Size = new System.Drawing.Size(247, 117);
            this.grpApplicantInfo.TabIndex = 5;
            this.grpApplicantInfo.TabStop = false;
            this.grpApplicantInfo.Text = "Applicant Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(4, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(4, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Position:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(4, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contact Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(4, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email:";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(120, 17);
            this.txtApplicantName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.ReadOnly = true;
            this.txtApplicantName.Size = new System.Drawing.Size(127, 23);
            this.txtApplicantName.TabIndex = 4;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(120, 42);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(127, 23);
            this.txtPosition.TabIndex = 5;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(120, 66);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.ReadOnly = true;
            this.txtContactNumber.Size = new System.Drawing.Size(127, 23);
            this.txtContactNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(127, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // grpInterviewEvaluation
            // 
            this.grpInterviewEvaluation.Controls.Add(this.label10);
            this.grpInterviewEvaluation.Controls.Add(this.label9);
            this.grpInterviewEvaluation.Controls.Add(this.label8);
            this.grpInterviewEvaluation.Controls.Add(this.txtInterviewScore);
            this.grpInterviewEvaluation.Controls.Add(this.txtInterviewResult);
            this.grpInterviewEvaluation.Controls.Add(this.rtbInterviewRemarks);
            this.grpInterviewEvaluation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInterviewEvaluation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpInterviewEvaluation.Location = new System.Drawing.Point(266, 231);
            this.grpInterviewEvaluation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInterviewEvaluation.Name = "grpInterviewEvaluation";
            this.grpInterviewEvaluation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInterviewEvaluation.Size = new System.Drawing.Size(388, 117);
            this.grpInterviewEvaluation.TabIndex = 6;
            this.grpInterviewEvaluation.TabStop = false;
            this.grpInterviewEvaluation.Text = "Interview Evaluation Summary";
            this.grpInterviewEvaluation.Enter += new System.EventHandler(this.grpInterviewEvaluation_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(4, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Score:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(4, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Result:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(4, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Remarks:";
            // 
            // txtInterviewScore
            // 
            this.txtInterviewScore.Location = new System.Drawing.Point(120, 18);
            this.txtInterviewScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInterviewScore.Name = "txtInterviewScore";
            this.txtInterviewScore.ReadOnly = true;
            this.txtInterviewScore.Size = new System.Drawing.Size(91, 23);
            this.txtInterviewScore.TabIndex = 3;
            // 
            // txtInterviewResult
            // 
            this.txtInterviewResult.Location = new System.Drawing.Point(120, 43);
            this.txtInterviewResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInterviewResult.Name = "txtInterviewResult";
            this.txtInterviewResult.ReadOnly = true;
            this.txtInterviewResult.Size = new System.Drawing.Size(91, 23);
            this.txtInterviewResult.TabIndex = 4;
            // 
            // rtbInterviewRemarks
            // 
            this.rtbInterviewRemarks.Location = new System.Drawing.Point(120, 68);
            this.rtbInterviewRemarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbInterviewRemarks.Name = "rtbInterviewRemarks";
            this.rtbInterviewRemarks.ReadOnly = true;
            this.rtbInterviewRemarks.Size = new System.Drawing.Size(256, 44);
            this.rtbInterviewRemarks.TabIndex = 5;
            this.rtbInterviewRemarks.Text = "";
            // 
            // grpFinalDecision
            // 
            this.grpFinalDecision.Controls.Add(this.label11);
            this.grpFinalDecision.Controls.Add(this.cmbDecision);
            this.grpFinalDecision.Controls.Add(this.label12);
            this.grpFinalDecision.Controls.Add(this.rtbRemarks);
            this.grpFinalDecision.Controls.Add(this.btnSaveDecision);
            this.grpFinalDecision.Controls.Add(this.btnClear);
            this.grpFinalDecision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFinalDecision.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpFinalDecision.Location = new System.Drawing.Point(9, 358);
            this.grpFinalDecision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFinalDecision.Name = "grpFinalDecision";
            this.grpFinalDecision.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFinalDecision.Size = new System.Drawing.Size(645, 130);
            this.grpFinalDecision.TabIndex = 7;
            this.grpFinalDecision.TabStop = false;
            this.grpFinalDecision.Text = "FINAL DECISION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(4, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Decision:";
            // 
            // cmbDecision
            // 
            this.cmbDecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecision.FormattingEnabled = true;
            this.cmbDecision.Items.AddRange(new object[] {
            "Accepted",
            "Rejected"});
            this.cmbDecision.Location = new System.Drawing.Point(75, 20);
            this.cmbDecision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDecision.Name = "cmbDecision";
            this.cmbDecision.Size = new System.Drawing.Size(114, 23);
            this.cmbDecision.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(4, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Remarks:";
            // 
            // rtbRemarks
            // 
            this.rtbRemarks.Location = new System.Drawing.Point(75, 44);
            this.rtbRemarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbRemarks.Name = "rtbRemarks";
            this.rtbRemarks.Size = new System.Drawing.Size(451, 66);
            this.rtbRemarks.TabIndex = 3;
            this.rtbRemarks.Text = "";
            // 
            // btnSaveDecision
            // 
            this.btnSaveDecision.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveDecision.FlatAppearance.BorderSize = 0;
            this.btnSaveDecision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDecision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveDecision.ForeColor = System.Drawing.Color.White;
            this.btnSaveDecision.Location = new System.Drawing.Point(536, 44);
            this.btnSaveDecision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveDecision.Name = "btnSaveDecision";
            this.btnSaveDecision.Size = new System.Drawing.Size(98, 29);
            this.btnSaveDecision.TabIndex = 4;
            this.btnSaveDecision.Text = "Save Decision";
            this.btnSaveDecision.UseVisualStyleBackColor = false;
            this.btnSaveDecision.Click += new System.EventHandler(this.btnSaveDecision_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(536, 80);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 29);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormHRFinalDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(663, 499);
            this.Controls.Add(this.grpFinalDecision);
            this.Controls.Add(this.grpInterviewEvaluation);
            this.Controls.Add(this.grpApplicantInfo);
            this.Controls.Add(this.grpApplicants);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchApplicant);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHRFinalDecision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Hiring Decision";
            this.Load += new System.EventHandler(this.FormHRFinalDecision_Load);
            this.grpApplicants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.grpApplicantInfo.ResumeLayout(false);
            this.grpApplicantInfo.PerformLayout();
            this.grpInterviewEvaluation.ResumeLayout(false);
            this.grpInterviewEvaluation.PerformLayout();
            this.grpFinalDecision.ResumeLayout(false);
            this.grpFinalDecision.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSearchApplicant;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpApplicants;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApplicantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterviewResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.GroupBox grpApplicantInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpInterviewEvaluation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInterviewScore;
        private System.Windows.Forms.TextBox txtInterviewResult;
        private System.Windows.Forms.RichTextBox rtbInterviewRemarks;
        private System.Windows.Forms.GroupBox grpFinalDecision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDecision;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbRemarks;
        private System.Windows.Forms.Button btnSaveDecision;
        private System.Windows.Forms.Button btnClear;
    }
}