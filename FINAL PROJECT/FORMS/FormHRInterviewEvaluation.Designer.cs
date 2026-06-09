namespace FINAL_PROJECT.FORMS
{
    partial class FormHRInterviewEvaluation
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
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.cboResult = new System.Windows.Forms.ComboBox();
            this.lblRecommendation = new System.Windows.Forms.Label();
            this.txtRecommendation = new System.Windows.Forms.TextBox();
            this.btnSaveEvaluation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvSchedules).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Interview Evaluation";

            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Location = new System.Drawing.Point(12, 55);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.RowHeadersWidth = 51;
            this.dgvSchedules.Size = new System.Drawing.Size(786, 210);
            this.dgvSchedules.TabIndex = 1;
            this.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedules.MultiSelect = false;
            this.dgvSchedules.ReadOnly = true;

            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 280);
            this.lblScore.Name = "lblScore";
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score (0-100):";

            this.txtScore.Location = new System.Drawing.Point(180, 277);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 27);
            this.txtScore.TabIndex = 3;

            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(12, 320);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.TabIndex = 4;
            this.lblRemarks.Text = "Remarks:";

            this.txtRemarks.Location = new System.Drawing.Point(180, 317);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(400, 27);
            this.txtRemarks.TabIndex = 5;

            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 360);
            this.lblResult.Name = "lblResult";
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";

            this.cboResult.FormattingEnabled = true;
            this.cboResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResult.Location = new System.Drawing.Point(180, 357);
            this.cboResult.Name = "cboResult";
            this.cboResult.Size = new System.Drawing.Size(151, 28);
            this.cboResult.TabIndex = 7;

            this.lblRecommendation.AutoSize = true;
            this.lblRecommendation.Location = new System.Drawing.Point(12, 400);
            this.lblRecommendation.Name = "lblRecommendation";
            this.lblRecommendation.TabIndex = 8;
            this.lblRecommendation.Text = "Recommendation:";

            this.txtRecommendation.Location = new System.Drawing.Point(180, 397);
            this.txtRecommendation.Name = "txtRecommendation";
            this.txtRecommendation.Size = new System.Drawing.Size(400, 27);
            this.txtRecommendation.TabIndex = 9;

            this.btnSaveEvaluation.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveEvaluation.FlatAppearance.BorderSize = 0;
            this.btnSaveEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEvaluation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveEvaluation.ForeColor = System.Drawing.Color.White;
            this.btnSaveEvaluation.Location = new System.Drawing.Point(320, 460);
            this.btnSaveEvaluation.Name = "btnSaveEvaluation";
            this.btnSaveEvaluation.Size = new System.Drawing.Size(170, 38);
            this.btnSaveEvaluation.TabIndex = 10;
            this.btnSaveEvaluation.Text = "Save Evaluation";
            this.btnSaveEvaluation.UseVisualStyleBackColor = false;
            this.btnSaveEvaluation.Click += new System.EventHandler(this.btnSaveEvaluation_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 520);
            this.Controls.Add(this.btnSaveEvaluation);
            this.Controls.Add(this.txtRecommendation);
            this.Controls.Add(this.lblRecommendation);
            this.Controls.Add(this.cboResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormHRInterviewEvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interview Evaluation";
            this.Load += new System.EventHandler(this.FormHRInterviewEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)this.dgvSchedules).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cboResult;
        private System.Windows.Forms.Label lblRecommendation;
        private System.Windows.Forms.TextBox txtRecommendation;
        private System.Windows.Forms.Button btnSaveEvaluation;
    }
}