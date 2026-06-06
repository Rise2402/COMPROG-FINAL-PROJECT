namespace APPLICANT_LIST
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblPositionFilter = new Label();
            label4 = new Label();
            cboPosition = new ComboBox();
            cboStatus = new ComboBox();
            dgvApplicants = new DataGridView();
            grpApplicantInfo = new GroupBox();
            txtStatus = new TextBox();
            txtPosition = new TextBox();
            txtContactNumber = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtApplicantID = new TextBox();
            lblStatus = new Label();
            lblPosition = new Label();
            lblContactNumber = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            lblApplicantID = new Label();
            btnRefresh = new Button();
            btnUpdateStatus = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).BeginInit();
            grpApplicantInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(308, 40);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "APPLICANT LIST";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.ForeColor = Color.Navy;
            lblSearch.Location = new Point(25, 80);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(113, 19);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Applicant:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(144, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Navy;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(344, 71);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblPositionFilter
            // 
            lblPositionFilter.AutoSize = true;
            lblPositionFilter.Font = new Font("Segoe UI", 10F);
            lblPositionFilter.ForeColor = Color.Navy;
            lblPositionFilter.Location = new Point(25, 130);
            lblPositionFilter.Name = "lblPositionFilter";
            lblPositionFilter.Size = new Size(64, 19);
            lblPositionFilter.TabIndex = 4;
            lblPositionFilter.Text = "Position: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(250, 130);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 5;
            label4.Text = "Status:";
            // 
            // cboPosition
            // 
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(90, 127);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(121, 23);
            cboPosition.TabIndex = 6;
            cboPosition.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(310, 127);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(100, 23);
            cboStatus.TabIndex = 7;
            cboStatus.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dgvApplicants
            // 
            dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplicants.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicants.EnableHeadersVisualStyles = false;
            dgvApplicants.Location = new Point(25, 170);
            dgvApplicants.Name = "dgvApplicants";
            dgvApplicants.RowHeadersVisible = false;
            dgvApplicants.Size = new Size(780, 250);
            dgvApplicants.TabIndex = 8;
            dgvApplicants.CellContentClick += dataGridView1_CellContentClick;
            // 
            // grpApplicantInfo
            // 
            grpApplicantInfo.Controls.Add(txtStatus);
            grpApplicantInfo.Controls.Add(txtPosition);
            grpApplicantInfo.Controls.Add(txtContactNumber);
            grpApplicantInfo.Controls.Add(txtEmail);
            grpApplicantInfo.Controls.Add(txtFullName);
            grpApplicantInfo.Controls.Add(txtApplicantID);
            grpApplicantInfo.Controls.Add(lblStatus);
            grpApplicantInfo.Controls.Add(lblPosition);
            grpApplicantInfo.Controls.Add(lblContactNumber);
            grpApplicantInfo.Controls.Add(lblEmail);
            grpApplicantInfo.Controls.Add(lblFullName);
            grpApplicantInfo.Controls.Add(lblApplicantID);
            grpApplicantInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpApplicantInfo.ForeColor = Color.Navy;
            grpApplicantInfo.Location = new Point(25, 440);
            grpApplicantInfo.Name = "grpApplicantInfo";
            grpApplicantInfo.Size = new Size(780, 188);
            grpApplicantInfo.TabIndex = 9;
            grpApplicantInfo.TabStop = false;
            grpApplicantInfo.Text = " Applicant Information";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(550, 70);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(180, 25);
            txtStatus.TabIndex = 14;
            txtStatus.TextChanged += textBox7_TextChanged;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(550, 35);
            txtPosition.Name = "txtPosition";
            txtPosition.ReadOnly = true;
            txtPosition.Size = new Size(180, 25);
            txtPosition.TabIndex = 13;
            txtPosition.TextChanged += textBox6_TextChanged;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(150, 140);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.ReadOnly = true;
            txtContactNumber.Size = new Size(250, 25);
            txtContactNumber.TabIndex = 12;
            txtContactNumber.TextChanged += textBox5_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(250, 25);
            txtEmail.TabIndex = 11;
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 70);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(250, 25);
            txtFullName.TabIndex = 7;
            // 
            // txtApplicantID
            // 
            txtApplicantID.Location = new Point(150, 35);
            txtApplicantID.Name = "txtApplicantID";
            txtApplicantID.ReadOnly = true;
            txtApplicantID.Size = new Size(250, 25);
            txtApplicantID.TabIndex = 6;
            txtApplicantID.TextChanged += textBox2_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Navy;
            lblStatus.Location = new Point(443, 73);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 19);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status:";
            lblStatus.Click += label10_Click;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.ForeColor = Color.Navy;
            lblPosition.Location = new Point(443, 38);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(67, 19);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Position:";
            lblPosition.Click += label9_Click;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.ForeColor = Color.Navy;
            lblContactNumber.Location = new Point(6, 143);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(124, 19);
            lblContactNumber.TabIndex = 3;
            lblContactNumber.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.Navy;
            lblEmail.Location = new Point(7, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = Color.Navy;
            lblFullName.Location = new Point(6, 73);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 19);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            lblFullName.Click += label6_Click;
            // 
            // lblApplicantID
            // 
            lblApplicantID.AutoSize = true;
            lblApplicantID.ForeColor = Color.Navy;
            lblApplicantID.Location = new Point(7, 38);
            lblApplicantID.Name = "lblApplicantID";
            lblApplicantID.Size = new Size(95, 19);
            lblApplicantID.TabIndex = 0;
            lblApplicantID.Text = "Applicant ID:";
            lblApplicantID.Click += label5_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Navy;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(454, 685);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += button3_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.Navy;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(284, 685);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(130, 35);
            btnUpdateStatus.TabIndex = 16;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += button2_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Navy;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(144, 685);
            btnView.Name = "btnView";
            btnView.Size = new Size(100, 35);
            btnView.TabIndex = 15;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 783);
            Controls.Add(btnRefresh);
            Controls.Add(grpApplicantInfo);
            Controls.Add(dgvApplicants);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cboStatus);
            Controls.Add(cboPosition);
            Controls.Add(btnView);
            Controls.Add(label4);
            Controls.Add(lblPositionFilter);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplicants).EndInit();
            grpApplicantInfo.ResumeLayout(false);
            grpApplicantInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblPositionFilter;
        private Label label4;
        private ComboBox cboPosition;
        private ComboBox cboStatus;
        private DataGridView dgvApplicants;
        private GroupBox grpApplicantInfo;
        private Label lblStatus;
        private Label lblPosition;
        private Label lblContactNumber;
        private Label lblEmail;
        private Label lblFullName;
        private Label lblApplicantID;
        private TextBox txtFullName;
        private TextBox txtApplicantID;
        private TextBox txtPosition;
        private TextBox txtContactNumber;
        private TextBox txtEmail;
        private TextBox txtStatus;
        private Button btnView;
        private Button btnUpdateStatus;
        private Button btnRefresh;
    }
}
