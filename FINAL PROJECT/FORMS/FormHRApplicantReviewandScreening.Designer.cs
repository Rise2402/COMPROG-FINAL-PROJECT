using Org.BouncyCastle.Asn1.Crmf;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FINAL_PROJECT.FORMS
{
    partial class FormHRApplicantReviewandScreening
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.grpApplicants = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lstDocuments = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSaveScreening = new System.Windows.Forms.Button();
            this.rtbRemarks = new System.Windows.Forms.RichTextBox();
            this.grpApplicantInfo = new System.Windows.Forms.GroupBox();
            this.grpDocuments = new System.Windows.Forms.GroupBox();
            this.grpScreening = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.grpApplicants.SuspendLayout();
            this.grpApplicantInfo.SuspendLayout();
            this.grpDocuments.SuspendLayout();
            this.grpScreening.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "APPLICANT REVIEW AND SCREENING";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Applicant:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(112, 44);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(314, 45);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 19);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.EnableHeadersVisualStyles = false;
            this.dgvApplicants.Location = new System.Drawing.Point(4, 17);
            this.dgvApplicants.Margin = new System.Windows.Forms.Padding(2);
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.RowHeadersVisible = false;
            this.dgvApplicants.RowHeadersWidth = 51;
            this.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicants.Size = new System.Drawing.Size(504, 155);
            this.dgvApplicants.TabIndex = 4;
            this.dgvApplicants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicants_CellContentClick);
            // 
            // grpApplicants
            // 
            this.grpApplicants.BackColor = System.Drawing.Color.Gainsboro;
            this.grpApplicants.Controls.Add(this.dgvApplicants);
            this.grpApplicants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpApplicants.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpApplicants.Location = new System.Drawing.Point(14, 66);
            this.grpApplicants.Margin = new System.Windows.Forms.Padding(2);
            this.grpApplicants.Name = "grpApplicants";
            this.grpApplicants.Padding = new System.Windows.Forms.Padding(2);
            this.grpApplicants.Size = new System.Drawing.Size(508, 176);
            this.grpApplicants.TabIndex = 5;
            this.grpApplicants.TabStop = false;
            this.grpApplicants.Text = "Submitted Application";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Applicant Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(20, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position Applied:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(20, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contact Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(20, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(20, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Current Status: ";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(141, 16);
            this.txtApplicantName.Margin = new System.Windows.Forms.Padding(2);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.Size = new System.Drawing.Size(130, 23);
            this.txtApplicantName.TabIndex = 12;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(141, 40);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(130, 23);
            this.txtPosition.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 64);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 23);
            this.txtEmail.TabIndex = 14;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(141, 85);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(130, 23);
            this.txtContactNumber.TabIndex = 15;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(141, 108);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(130, 23);
            this.txtStatus.TabIndex = 16;
            // 
            // lstDocuments
            // 
            this.lstDocuments.FormattingEnabled = true;
            this.lstDocuments.Location = new System.Drawing.Point(10, 16);
            this.lstDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.lstDocuments.Name = "lstDocuments";
            this.lstDocuments.Size = new System.Drawing.Size(194, 76);
            this.lstDocuments.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(39, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Result:";
            // 
            // cmbResult
            // 
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Location = new System.Drawing.Point(98, 17);
            this.cmbResult.Margin = new System.Windows.Forms.Padding(2);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(114, 23);
            this.cmbResult.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(13, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Remarks:";
            // 
            // btnSaveScreening
            // 
            this.btnSaveScreening.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveScreening.FlatAppearance.BorderSize = 0;
            this.btnSaveScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveScreening.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScreening.ForeColor = System.Drawing.Color.White;
            this.btnSaveScreening.Location = new System.Drawing.Point(404, 110);
            this.btnSaveScreening.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveScreening.Name = "btnSaveScreening";
            this.btnSaveScreening.Size = new System.Drawing.Size(92, 23);
            this.btnSaveScreening.TabIndex = 23;
            this.btnSaveScreening.Text = "Save Screening";
            this.btnSaveScreening.UseVisualStyleBackColor = true;
            // 
            // rtbRemarks
            // 
            this.rtbRemarks.Location = new System.Drawing.Point(22, 63);
            this.rtbRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.rtbRemarks.Name = "rtbRemarks";
            this.rtbRemarks.Size = new System.Drawing.Size(360, 116);
            this.rtbRemarks.TabIndex = 24;
            this.rtbRemarks.Text = "";
            // 
            // grpApplicantInfo
            // 
            this.grpApplicantInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.grpApplicantInfo.Controls.Add(this.label4);
            this.grpApplicantInfo.Controls.Add(this.label5);
            this.grpApplicantInfo.Controls.Add(this.label7);
            this.grpApplicantInfo.Controls.Add(this.label6);
            this.grpApplicantInfo.Controls.Add(this.label8);
            this.grpApplicantInfo.Controls.Add(this.txtApplicantName);
            this.grpApplicantInfo.Controls.Add(this.txtPosition);
            this.grpApplicantInfo.Controls.Add(this.txtEmail);
            this.grpApplicantInfo.Controls.Add(this.txtStatus);
            this.grpApplicantInfo.Controls.Add(this.txtContactNumber);
            this.grpApplicantInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpApplicantInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpApplicantInfo.Location = new System.Drawing.Point(18, 245);
            this.grpApplicantInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpApplicantInfo.Name = "grpApplicantInfo";
            this.grpApplicantInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpApplicantInfo.Size = new System.Drawing.Size(271, 138);
            this.grpApplicantInfo.TabIndex = 25;
            this.grpApplicantInfo.TabStop = false;
            this.grpApplicantInfo.Text = "Applicant Information";
            // 
            // grpDocuments
            // 
            this.grpDocuments.BackColor = System.Drawing.Color.Gainsboro;
            this.grpDocuments.Controls.Add(this.lstDocuments);
            this.grpDocuments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDocuments.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpDocuments.Location = new System.Drawing.Point(314, 245);
            this.grpDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.grpDocuments.Name = "grpDocuments";
            this.grpDocuments.Padding = new System.Windows.Forms.Padding(2);
            this.grpDocuments.Size = new System.Drawing.Size(271, 125);
            this.grpDocuments.TabIndex = 26;
            this.grpDocuments.TabStop = false;
            this.grpDocuments.Text = "Submitted Documents";
            this.grpDocuments.Enter += new System.EventHandler(this.grpDocuments_Enter);
            // 
            // grpScreening
            // 
            this.grpScreening.BackColor = System.Drawing.Color.Gainsboro;
            this.grpScreening.Controls.Add(this.cmbResult);
            this.grpScreening.Controls.Add(this.label11);
            this.grpScreening.Controls.Add(this.label12);
            this.grpScreening.Controls.Add(this.rtbRemarks);
            this.grpScreening.Controls.Add(this.btnSaveScreening);
            this.grpScreening.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpScreening.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpScreening.Location = new System.Drawing.Point(18, 387);
            this.grpScreening.Margin = new System.Windows.Forms.Padding(2);
            this.grpScreening.Name = "grpScreening";
            this.grpScreening.Padding = new System.Windows.Forms.Padding(2);
            this.grpScreening.Size = new System.Drawing.Size(535, 188);
            this.grpScreening.TabIndex = 27;
            this.grpScreening.TabStop = false;
            this.grpScreening.Text = "Screening Evaluation";
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(682, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(19, 18);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "X";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // FormHRApplicantReviewandScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(712, 596);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grpScreening);
            this.Controls.Add(this.grpDocuments);
            this.Controls.Add(this.grpApplicantInfo);
            this.Controls.Add(this.grpApplicants);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHRApplicantReviewandScreening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHRApplicantReviewandScreening_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.grpApplicants.ResumeLayout(false);
            this.grpApplicantInfo.ResumeLayout(false);
            this.grpApplicantInfo.PerformLayout();
            this.grpDocuments.ResumeLayout(false);
            this.grpScreening.ResumeLayout(false);
            this.grpScreening.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label btnexit;
    }
}
