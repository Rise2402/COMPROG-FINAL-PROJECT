namespace WinForms_Interview
{
    partial class FormInterviewEvaluation
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
            dgvSchedules = new DataGridView();
            lblScore = new Label();
            txtScore = new TextBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            lblResult = new Label();
            cboResult = new ComboBox();
            lblRecommendation = new Label();
            txtRecommendation = new TextBox();
            btnSaveEvaluation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Interview Evaluation";
            // 
            // dgvSchedules
            // 
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Location = new Point(12, 32);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowHeadersWidth = 51;
            dgvSchedules.Size = new Size(786, 210);
            dgvSchedules.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(12, 255);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(49, 20);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(148, 255);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(125, 27);
            txtScore.TabIndex = 3;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(12, 296);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(68, 20);
            lblRemarks.TabIndex = 4;
            lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(148, 296);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(125, 27);
            txtRemarks.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 335);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 6;
            lblResult.Text = "Result:";
            // 
            // cboResult
            // 
            cboResult.FormattingEnabled = true;
            cboResult.Location = new Point(148, 335);
            cboResult.Name = "cboResult";
            cboResult.Size = new Size(151, 28);
            cboResult.TabIndex = 7;
            // 
            // lblRecommendation
            // 
            lblRecommendation.AutoSize = true;
            lblRecommendation.Location = new Point(12, 379);
            lblRecommendation.Name = "lblRecommendation";
            lblRecommendation.Size = new Size(130, 20);
            lblRecommendation.TabIndex = 8;
            lblRecommendation.Text = "Recommendation:";
            // 
            // txtRecommendation
            // 
            txtRecommendation.Location = new Point(148, 376);
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.Size = new Size(125, 27);
            txtRecommendation.TabIndex = 9;
            // 
            // btnSaveEvaluation
            // 
            btnSaveEvaluation.Location = new Point(341, 472);
            btnSaveEvaluation.Name = "btnSaveEvaluation";
            btnSaveEvaluation.Size = new Size(140, 29);
            btnSaveEvaluation.TabIndex = 10;
            btnSaveEvaluation.Text = "Save Evaluation";
            btnSaveEvaluation.UseVisualStyleBackColor = true;
            // 
            // FormInterviewEvaluation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(810, 513);
            Controls.Add(btnSaveEvaluation);
            Controls.Add(txtRecommendation);
            Controls.Add(lblRecommendation);
            Controls.Add(cboResult);
            Controls.Add(lblResult);
            Controls.Add(txtRemarks);
            Controls.Add(lblRemarks);
            Controls.Add(txtScore);
            Controls.Add(lblScore);
            Controls.Add(dgvSchedules);
            Controls.Add(lblTitle);
            Name = "FormInterviewEvaluation";
            Text = "FormInterviewEvaluation";
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvSchedules;
        private Label lblScore;
        private TextBox txtScore;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Label lblResult;
        private ComboBox cboResult;
        private Label lblRecommendation;
        private TextBox txtRecommendation;
        private Button btnSaveEvaluation;
    }
}