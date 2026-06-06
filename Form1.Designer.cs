namespace ApplicantReviewScreening
{
    partial class Form1
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
            label2 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvApplicants = new DataGridView();
            grpApplicants = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtApplicantName = new TextBox();
            txtPosition = new TextBox();
            txtEmail = new TextBox();
            txtContactNumber = new TextBox();
            txtStatus = new TextBox();
            lstDocuments = new CheckedListBox();
            label11 = new Label();
            cmbResult = new ComboBox();
            label12 = new Label();
            btnSaveScreening = new Button();
            rtbRemarks = new RichTextBox();
            grpApplicantInfo = new GroupBox();
            grpDocuments = new GroupBox();
            grpScreening = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            grpApplicants.SuspendLayout();
            grpApplicantInfo.SuspendLayout();
            grpDocuments.SuspendLayout();
            grpScreening.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(658, 38);
            label1.TabIndex = 0;
            label1.Text = "APPLICANT REVIEW AND SCREENING";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 1;
            label2.Text = "Search Applicant:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(154, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(108, 27);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(291, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
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
            dgvApplicants.EnableHeadersVisualStyles = false;
            dgvApplicants.Location = new Point(6, 26);
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.RowHeadersVisible = false;
            dgvApplicants.RowHeadersWidth = 51;
            dgvApplicants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicants.Size = new Size(666, 238);
            dgvApplicants.TabIndex = 4;
            dgvApplicants.CellClick += dgvApplicants_CellClick;
            // 
            // grpApplicants
            // 
            grpApplicants.BackColor = Color.Gainsboro;
            grpApplicants.Controls.Add(dgvApplicants);
            grpApplicants.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpApplicants.ForeColor = Color.MidnightBlue;
            grpApplicants.Location = new Point(18, 101);
            grpApplicants.Name = "grpApplicants";
            grpApplicants.Size = new Size(678, 270);
            grpApplicants.TabIndex = 5;
            grpApplicants.TabStop = false;
            grpApplicants.Text = "Submitted Application";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(27, 32);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 7;
            label4.Text = "Applicant Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(27, 68);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 8;
            label5.Text = "Position Applied:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(27, 138);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 10;
            label6.Text = "Contact Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(27, 102);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 9;
            label7.Text = "Email: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(27, 172);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 11;
            label8.Text = "Current Status: ";
            label8.Click += label8_Click;
            // 
            // txtApplicantName
            // 
            txtApplicantName.Location = new Point(206, 25);
            txtApplicantName.Name = "txtApplicantName";
            txtApplicantName.Size = new Size(125, 27);
            txtApplicantName.TabIndex = 12;
            txtApplicantName.TextChanged += textBox2_TextChanged;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(206, 61);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(125, 27);
            txtPosition.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(206, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(206, 131);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(125, 27);
            txtContactNumber.TabIndex = 15;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(206, 165);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 16;
            // 
            // lstDocuments
            // 
            lstDocuments.FormattingEnabled = true;
            lstDocuments.Location = new Point(50, 26);
            lstDocuments.Name = "lstDocuments";
            lstDocuments.Size = new Size(235, 136);
            lstDocuments.TabIndex = 18;
            lstDocuments.SelectedIndexChanged += lstDocuments_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(52, 34);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 20;
            label11.Text = "Result:";
            // 
            // cmbResult
            // 
            cmbResult.FormattingEnabled = true;
            cmbResult.Location = new Point(130, 26);
            cmbResult.Name = "cmbResult";
            cmbResult.Size = new Size(151, 28);
            cmbResult.TabIndex = 21;
            cmbResult.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(17, 74);
            label12.Name = "label12";
            label12.Size = new Size(74, 20);
            label12.TabIndex = 22;
            label12.Text = "Remarks:";
            // 
            // btnSaveScreening
            // 
            btnSaveScreening.BackColor = Color.MidnightBlue;
            btnSaveScreening.FlatAppearance.BorderSize = 0;
            btnSaveScreening.FlatStyle = FlatStyle.Flat;
            btnSaveScreening.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveScreening.ForeColor = Color.White;
            btnSaveScreening.Location = new Point(538, 169);
            btnSaveScreening.Name = "btnSaveScreening";
            btnSaveScreening.Size = new Size(123, 29);
            btnSaveScreening.TabIndex = 23;
            btnSaveScreening.Text = "Save Screening";
            btnSaveScreening.UseVisualStyleBackColor = true;
            btnSaveScreening.Click += button2_Click;
            // 
            // rtbRemarks
            // 
            rtbRemarks.Location = new Point(29, 97);
            rtbRemarks.Name = "rtbRemarks";
            rtbRemarks.Size = new Size(479, 177);
            rtbRemarks.TabIndex = 24;
            rtbRemarks.Text = "";
            // 
            // grpApplicantInfo
            // 
            grpApplicantInfo.BackColor = Color.Gainsboro;
            grpApplicantInfo.Controls.Add(label4);
            grpApplicantInfo.Controls.Add(label5);
            grpApplicantInfo.Controls.Add(label7);
            grpApplicantInfo.Controls.Add(label6);
            grpApplicantInfo.Controls.Add(label8);
            grpApplicantInfo.Controls.Add(txtApplicantName);
            grpApplicantInfo.Controls.Add(txtPosition);
            grpApplicantInfo.Controls.Add(txtEmail);
            grpApplicantInfo.Controls.Add(txtStatus);
            grpApplicantInfo.Controls.Add(txtContactNumber);
            grpApplicantInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpApplicantInfo.ForeColor = Color.MidnightBlue;
            grpApplicantInfo.Location = new Point(24, 377);
            grpApplicantInfo.Name = "grpApplicantInfo";
            grpApplicantInfo.Size = new Size(361, 213);
            grpApplicantInfo.TabIndex = 25;
            grpApplicantInfo.TabStop = false;
            grpApplicantInfo.Text = "Applicant Information";
            // 
            // grpDocuments
            // 
            grpDocuments.BackColor = Color.Gainsboro;
            grpDocuments.Controls.Add(lstDocuments);
            grpDocuments.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDocuments.ForeColor = Color.MidnightBlue;
            grpDocuments.Location = new Point(391, 377);
            grpDocuments.Name = "grpDocuments";
            grpDocuments.Size = new Size(361, 192);
            grpDocuments.TabIndex = 26;
            grpDocuments.TabStop = false;
            grpDocuments.Text = "Submitted Documents";
            grpDocuments.Enter += groupBox1_Enter;
            // 
            // grpScreening
            // 
            grpScreening.BackColor = Color.Gainsboro;
            grpScreening.Controls.Add(cmbResult);
            grpScreening.Controls.Add(label11);
            grpScreening.Controls.Add(label12);
            grpScreening.Controls.Add(rtbRemarks);
            grpScreening.Controls.Add(btnSaveScreening);
            grpScreening.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpScreening.ForeColor = Color.MidnightBlue;
            grpScreening.Location = new Point(24, 596);
            grpScreening.Name = "grpScreening";
            grpScreening.Size = new Size(713, 289);
            grpScreening.TabIndex = 27;
            grpScreening.TabStop = false;
            grpScreening.Text = "Screening Evaluation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(949, 917);
            Controls.Add(grpScreening);
            Controls.Add(grpDocuments);
            Controls.Add(grpApplicantInfo);
            Controls.Add(grpApplicants);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            grpApplicants.ResumeLayout(false);
            grpApplicantInfo.ResumeLayout(false);
            grpApplicantInfo.PerformLayout();
            grpDocuments.ResumeLayout(false);
            grpScreening.ResumeLayout(false);
            grpScreening.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvApplicants;
        private GroupBox grpApplicants;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtApplicantName;
        private TextBox txtPosition;
        private TextBox txtEmail;
        private TextBox txtContactNumber;
        private TextBox txtStatus;
        private CheckedListBox lstDocuments;
        private Label label11;
        private ComboBox cmbResult;
        private Label label12;
        private Button btnSaveScreening;
        private RichTextBox rtbRemarks;
        private GroupBox grpApplicantInfo;
        private GroupBox grpDocuments;
        private GroupBox grpScreening;
    }
}
