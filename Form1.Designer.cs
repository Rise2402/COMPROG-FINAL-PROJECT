namespace final_hiring
{
    partial class FormFinalHiringDecision
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            lblSearchApplicant = new Label();
            txtSearch = new TextBox();
            grpApplicants = new GroupBox();
            dgvApplicants = new DataGridView();
            ApplicantID = new DataGridViewTextBoxColumn();
            ApplicantName = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            ScreeningResult = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpApplicantInfo = new GroupBox();
            txtContactNumber = new TextBox();
            txtEmail = new TextBox();
            txtPosition = new TextBox();
            txtApplicantName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            grpInterviewEvaluation = new GroupBox();
            rtbInterviewRemarks = new RichTextBox();
            txtInterviewResult = new TextBox();
            txtInterviewScore = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            grpFinalDecision = new GroupBox();
            btnClear = new Button();
            cmbDecision = new ComboBox();
            btnSaveDecision = new Button();
            rtbRemarks = new RichTextBox();
            label12 = new Label();
            label11 = new Label();
            label2 = new Label();
            grpApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            grpApplicantInfo.SuspendLayout();
            grpInterviewEvaluation.SuspendLayout();
            grpFinalDecision.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblSearchApplicant
            // 
            lblSearchApplicant.AutoSize = true;
            lblSearchApplicant.ForeColor = Color.MidnightBlue;
            lblSearchApplicant.Location = new Point(16, 67);
            lblSearchApplicant.Name = "lblSearchApplicant";
            lblSearchApplicant.Size = new Size(124, 20);
            lblSearchApplicant.TabIndex = 1;
            lblSearchApplicant.Text = "Search Applicant:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(146, 60);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // grpApplicants
            // 
            grpApplicants.Controls.Add(dgvApplicants);
            grpApplicants.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpApplicants.ForeColor = Color.MidnightBlue;
            grpApplicants.Location = new Point(12, 108);
            grpApplicants.Name = "grpApplicants";
            grpApplicants.Size = new Size(742, 252);
            grpApplicants.TabIndex = 3;
            grpApplicants.TabStop = false;
            grpApplicants.Text = "Qualified Applicants";
            grpApplicants.Enter += groupBox1_Enter;
            // 
            // dgvApplicants
            // 
            dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicants.Columns.AddRange(new DataGridViewColumn[] { ApplicantID, ApplicantName, Position, ScreeningResult });
            dgvApplicants.EnableHeadersVisualStyles = false;
            dgvApplicants.Location = new Point(4, 26);
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.RowHeadersVisible = false;
            dgvApplicants.RowHeadersWidth = 51;
            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.Size = new Size(732, 219);
            dgvApplicants.TabIndex = 4;
            dgvApplicants.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ApplicantID
            // 
            ApplicantID.HeaderText = "Applicant ID";
            ApplicantID.MinimumWidth = 6;
            ApplicantID.Name = "ApplicantID";
            // 
            // ApplicantName
            // 
            ApplicantName.HeaderText = "Applicant Name";
            ApplicantName.MinimumWidth = 6;
            ApplicantName.Name = "ApplicantName";
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            // 
            // ScreeningResult
            // 
            ScreeningResult.HeaderText = "Screening Result";
            ScreeningResult.MinimumWidth = 6;
            ScreeningResult.Name = "ScreeningResult";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(330, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // grpApplicantInfo
            // 
            grpApplicantInfo.Controls.Add(txtContactNumber);
            grpApplicantInfo.Controls.Add(txtEmail);
            grpApplicantInfo.Controls.Add(txtPosition);
            grpApplicantInfo.Controls.Add(txtApplicantName);
            grpApplicantInfo.Controls.Add(label6);
            grpApplicantInfo.Controls.Add(label7);
            grpApplicantInfo.Controls.Add(label5);
            grpApplicantInfo.Controls.Add(label4);
            grpApplicantInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpApplicantInfo.ForeColor = Color.MidnightBlue;
            grpApplicantInfo.Location = new Point(12, 400);
            grpApplicantInfo.Name = "grpApplicantInfo";
            grpApplicantInfo.Size = new Size(329, 224);
            grpApplicantInfo.TabIndex = 4;
            grpApplicantInfo.TabStop = false;
            grpApplicantInfo.Text = "Applicant Info";
            grpApplicantInfo.Enter += groupBox2_Enter;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(166, 177);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(125, 27);
            txtContactNumber.TabIndex = 7;
            txtContactNumber.TextChanged += txtContactNumber_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(166, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(166, 86);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(125, 27);
            txtPosition.TabIndex = 5;
            txtPosition.TextChanged += txtPosition_TextChanged;
            // 
            // txtApplicantName
            // 
            txtApplicantName.Location = new Point(166, 39);
            txtApplicantName.Name = "txtApplicantName";
            txtApplicantName.Size = new Size(125, 27);
            txtApplicantName.TabIndex = 4;
            txtApplicantName.TextChanged += txtApplicantName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(6, 180);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 3;
            label6.Text = "Contact Number:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(6, 134);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 2;
            label7.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(6, 89);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 1;
            label5.Text = "Position:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(6, 42);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 0;
            label4.Text = "Name:";
            // 
            // grpInterviewEvaluation
            // 
            grpInterviewEvaluation.Controls.Add(rtbInterviewRemarks);
            grpInterviewEvaluation.Controls.Add(txtInterviewResult);
            grpInterviewEvaluation.Controls.Add(txtInterviewScore);
            grpInterviewEvaluation.Controls.Add(label8);
            grpInterviewEvaluation.Controls.Add(label9);
            grpInterviewEvaluation.Controls.Add(label10);
            grpInterviewEvaluation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpInterviewEvaluation.ForeColor = Color.MidnightBlue;
            grpInterviewEvaluation.Location = new Point(387, 400);
            grpInterviewEvaluation.Name = "grpInterviewEvaluation";
            grpInterviewEvaluation.Size = new Size(367, 224);
            grpInterviewEvaluation.TabIndex = 5;
            grpInterviewEvaluation.TabStop = false;
            grpInterviewEvaluation.Text = "Interview Evaluation";
            // 
            // rtbInterviewRemarks
            // 
            rtbInterviewRemarks.Location = new Point(182, 143);
            rtbInterviewRemarks.Name = "rtbInterviewRemarks";
            rtbInterviewRemarks.Size = new Size(125, 75);
            rtbInterviewRemarks.TabIndex = 7;
            rtbInterviewRemarks.Text = "";
            rtbInterviewRemarks.TextChanged += rtbInterviewRemarks_TextChanged;
            // 
            // txtInterviewResult
            // 
            txtInterviewResult.Location = new Point(182, 99);
            txtInterviewResult.Name = "txtInterviewResult";
            txtInterviewResult.Size = new Size(125, 27);
            txtInterviewResult.TabIndex = 6;
            txtInterviewResult.TextChanged += txtInterviewResult_TextChanged;
            // 
            // txtInterviewScore
            // 
            txtInterviewScore.Location = new Point(182, 53);
            txtInterviewScore.Name = "txtInterviewScore";
            txtInterviewScore.Size = new Size(125, 27);
            txtInterviewScore.TabIndex = 5;
            txtInterviewScore.TextChanged += textBox8_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(27, 147);
            label8.Name = "label8";
            label8.Size = new Size(145, 20);
            label8.TabIndex = 3;
            label8.Text = "Interview Remarks:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(27, 102);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 2;
            label9.Text = "Interview Result:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(27, 56);
            label10.Name = "label10";
            label10.Size = new Size(122, 20);
            label10.TabIndex = 1;
            label10.Text = "Interview Score:";
            // 
            // grpFinalDecision
            // 
            grpFinalDecision.Controls.Add(btnClear);
            grpFinalDecision.Controls.Add(cmbDecision);
            grpFinalDecision.Controls.Add(btnSaveDecision);
            grpFinalDecision.Controls.Add(rtbRemarks);
            grpFinalDecision.Controls.Add(label12);
            grpFinalDecision.Controls.Add(label11);
            grpFinalDecision.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFinalDecision.ForeColor = Color.MidnightBlue;
            grpFinalDecision.Location = new Point(12, 639);
            grpFinalDecision.Name = "grpFinalDecision";
            grpFinalDecision.Size = new Size(742, 304);
            grpFinalDecision.TabIndex = 6;
            grpFinalDecision.TabStop = false;
            grpFinalDecision.Text = "FINAL DECISION";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MidnightBlue;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(65, 209);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(173, 61);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cmbDecision
            // 
            cmbDecision.FormattingEnabled = true;
            cmbDecision.Items.AddRange(new object[] { "", "Hire", "Reserve Candidate", "Reject" });
            cmbDecision.Location = new Point(81, 35);
            cmbDecision.Name = "cmbDecision";
            cmbDecision.Size = new Size(115, 28);
            cmbDecision.TabIndex = 13;
            cmbDecision.SelectedIndexChanged += cmbDecision_SelectedIndexChanged;
            // 
            // btnSaveDecision
            // 
            btnSaveDecision.BackColor = Color.MidnightBlue;
            btnSaveDecision.FlatAppearance.BorderSize = 0;
            btnSaveDecision.FlatStyle = FlatStyle.Flat;
            btnSaveDecision.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveDecision.ForeColor = Color.White;
            btnSaveDecision.Location = new Point(65, 142);
            btnSaveDecision.Name = "btnSaveDecision";
            btnSaveDecision.Size = new Size(173, 61);
            btnSaveDecision.TabIndex = 12;
            btnSaveDecision.Text = "Save Decision";
            btnSaveDecision.UseVisualStyleBackColor = false;
            btnSaveDecision.Click += btnSaveDecision_Click_1;
            // 
            // rtbRemarks
            // 
            rtbRemarks.Location = new Point(318, 38);
            rtbRemarks.Name = "rtbRemarks";
            rtbRemarks.Size = new Size(405, 246);
            rtbRemarks.TabIndex = 11;
            rtbRemarks.Text = "";
            rtbRemarks.TextChanged += rtbRemarks_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(235, 38);
            label12.Name = "label12";
            label12.Size = new Size(74, 20);
            label12.TabIndex = 10;
            label12.Text = "Remarks:";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(6, 38);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 8;
            label11.Text = "Decision:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(18, 18);
            label2.Name = "label2";
            label2.Size = new Size(515, 45);
            label2.TabIndex = 7;
            label2.Text = "FINAL HIRING DECISION";
            // 
            // FormFinalHiringDecision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(927, 1011);
            Controls.Add(label2);
            Controls.Add(grpFinalDecision);
            Controls.Add(grpInterviewEvaluation);
            Controls.Add(btnSearch);
            Controls.Add(grpApplicantInfo);
            Controls.Add(lblSearchApplicant);
            Controls.Add(grpApplicants);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "FormFinalHiringDecision";
            Text = "Final Hiring Decision";
            Load += Form1_Load_1;
            grpApplicants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            grpApplicantInfo.ResumeLayout(false);
            grpApplicantInfo.PerformLayout();
            grpInterviewEvaluation.ResumeLayout(false);
            grpInterviewEvaluation.PerformLayout();
            grpFinalDecision.ResumeLayout(false);
            grpFinalDecision.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSearchApplicant;
        private TextBox txtSearch;
        private GroupBox grpApplicants;
        private DataGridView dgvApplicants;
        private Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpApplicantInfo;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtContactNumber;
        private TextBox txtEmail;
        private TextBox txtPosition;
        private TextBox txtApplicantName;
        private GroupBox grpInterviewEvaluation;
        private TextBox textBox6;
        private TextBox txtInterviewResult;
        private TextBox txtInterviewScore;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox4;
        private CheckedListBox checkedListBox1;
        private Label label11;
        private Label label12;
        private Button button2;
        private RichTextBox rtbRemarks;
        private Label label2;
        private DataGridViewTextBoxColumn ApplicantID;
        private DataGridViewTextBoxColumn ApplicantName;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn ScreeningResult;
        private RichTextBox rtbInterviewRemarks;
        private ComboBox cmbDecision;
        private GroupBox grpFinalDecision;
        private Button btnSaveDecision;
        private Button btnClear;
    }
}
