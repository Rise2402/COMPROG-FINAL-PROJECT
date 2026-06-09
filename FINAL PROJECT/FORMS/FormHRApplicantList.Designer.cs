using Org.BouncyCastle.Asn1.Crmf;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FINAL_PROJECT.FORMS
{
    partial class FormHRApplicantList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPositionFilter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.grpApplicantInfo = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtApplicantID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblApplicantID = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Label();
            this.txtMissingDocs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.grpApplicantInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(21, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(308, 40);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "APPLICANT LIST";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.Navy;
            this.lblSearch.Location = new System.Drawing.Point(21, 69);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(113, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Applicant:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(214, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Navy;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(360, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // lblPositionFilter
            // 
            this.lblPositionFilter.AutoSize = true;
            this.lblPositionFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPositionFilter.ForeColor = System.Drawing.Color.Navy;
            this.lblPositionFilter.Location = new System.Drawing.Point(21, 113);
            this.lblPositionFilter.Name = "lblPositionFilter";
            this.lblPositionFilter.Size = new System.Drawing.Size(64, 19);
            this.lblPositionFilter.TabIndex = 4;
            this.lblPositionFilter.Text = "Position: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(217, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status:";
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(81, 110);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(131, 21);
            this.cboPosition.TabIndex = 6;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(268, 110);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(117, 21);
            this.cboStatus.TabIndex = 7;
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplicants.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.EnableHeadersVisualStyles = false;
            this.dgvApplicants.Location = new System.Drawing.Point(21, 147);
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.RowHeadersVisible = false;
            this.dgvApplicants.Size = new System.Drawing.Size(815, 217);
            this.dgvApplicants.TabIndex = 8;
            // 
            // grpApplicantInfo
            // 
            this.grpApplicantInfo.Controls.Add(this.label1);
            this.grpApplicantInfo.Controls.Add(this.txtMissingDocs);
            this.grpApplicantInfo.Controls.Add(this.txtStatus);
            this.grpApplicantInfo.Controls.Add(this.txtPosition);
            this.grpApplicantInfo.Controls.Add(this.txtContactNumber);
            this.grpApplicantInfo.Controls.Add(this.txtEmail);
            this.grpApplicantInfo.Controls.Add(this.txtFullName);
            this.grpApplicantInfo.Controls.Add(this.txtApplicantID);
            this.grpApplicantInfo.Controls.Add(this.lblStatus);
            this.grpApplicantInfo.Controls.Add(this.lblPosition);
            this.grpApplicantInfo.Controls.Add(this.lblContactNumber);
            this.grpApplicantInfo.Controls.Add(this.lblEmail);
            this.grpApplicantInfo.Controls.Add(this.lblFullName);
            this.grpApplicantInfo.Controls.Add(this.lblApplicantID);
            this.grpApplicantInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpApplicantInfo.ForeColor = System.Drawing.Color.Navy;
            this.grpApplicantInfo.Location = new System.Drawing.Point(21, 381);
            this.grpApplicantInfo.Name = "grpApplicantInfo";
            this.grpApplicantInfo.Size = new System.Drawing.Size(815, 207);
            this.grpApplicantInfo.TabIndex = 9;
            this.grpApplicantInfo.TabStop = false;
            this.grpApplicantInfo.Text = " Applicant Information";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(471, 61);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(192, 25);
            this.txtStatus.TabIndex = 14;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(471, 30);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(192, 25);
            this.txtPosition.TabIndex = 13;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(129, 121);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.ReadOnly = true;
            this.txtContactNumber.Size = new System.Drawing.Size(215, 25);
            this.txtContactNumber.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(215, 25);
            this.txtEmail.TabIndex = 11;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(129, 61);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(215, 25);
            this.txtFullName.TabIndex = 7;
            // 
            // txtApplicantID
            // 
            this.txtApplicantID.Location = new System.Drawing.Point(129, 30);
            this.txtApplicantID.Name = "txtApplicantID";
            this.txtApplicantID.ReadOnly = true;
            this.txtApplicantID.Size = new System.Drawing.Size(215, 25);
            this.txtApplicantID.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(380, 63);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.ForeColor = System.Drawing.Color.Navy;
            this.lblPosition.Location = new System.Drawing.Point(380, 33);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(67, 19);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.ForeColor = System.Drawing.Color.Navy;
            this.lblContactNumber.Location = new System.Drawing.Point(5, 124);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(124, 19);
            this.lblContactNumber.TabIndex = 3;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail.Location = new System.Drawing.Point(6, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.ForeColor = System.Drawing.Color.Navy;
            this.lblFullName.Location = new System.Drawing.Point(5, 63);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 19);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblApplicantID
            // 
            this.lblApplicantID.AutoSize = true;
            this.lblApplicantID.ForeColor = System.Drawing.Color.Navy;
            this.lblApplicantID.Location = new System.Drawing.Point(6, 33);
            this.lblApplicantID.Name = "lblApplicantID";
            this.lblApplicantID.Size = new System.Drawing.Size(95, 19);
            this.lblApplicantID.TabIndex = 0;
            this.lblApplicantID.Text = "Applicant ID:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Navy;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(389, 594);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 30);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.Navy;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(243, 594);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(111, 30);
            this.btnUpdateStatus.TabIndex = 16;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(827, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(19, 18);
            this.btnexit.TabIndex = 18;
            this.btnexit.Text = "X";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtMissingDocs
            // 
            this.txtMissingDocs.Location = new System.Drawing.Point(527, 100);
            this.txtMissingDocs.Multiline = true;
            this.txtMissingDocs.Name = "txtMissingDocs";
            this.txtMissingDocs.Size = new System.Drawing.Size(136, 93);
            this.txtMissingDocs.TabIndex = 15;
            this.txtMissingDocs.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(380, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Missing Documents:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormHRApplicantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(857, 679);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpApplicantInfo);
            this.Controls.Add(this.dgvApplicants);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPositionFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHRApplicantList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHRApplicantList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.grpApplicantInfo.ResumeLayout(false);
            this.grpApplicantInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnUpdateStatus;
        private Button btnRefresh;
        private Label btnexit;
        private Label label1;
        private TextBox txtMissingDocs;
    }
}
