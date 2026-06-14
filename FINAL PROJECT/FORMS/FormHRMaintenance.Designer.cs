namespace FINAL_PROJECT.FORMS
{
    partial class FormHRMaintenance
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.BackColor = System.Drawing.Color.MidnightBlue;
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.tabEmploymentTypes = new System.Windows.Forms.TabPage();
            this.tabRequirementTypes = new System.Windows.Forms.TabPage();
            this.tabInterviewTypes = new System.Windows.Forms.TabPage();
            this.tabAssessmentTypes = new System.Windows.Forms.TabPage();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.btnDeptAdd = new System.Windows.Forms.Button();
            this.btnDeptUpdate = new System.Windows.Forms.Button();
            this.btnDeptDelete = new System.Windows.Forms.Button();
            this.btnDeptClear = new System.Windows.Forms.Button();
            this.dgvEmploymentTypes = new System.Windows.Forms.DataGridView();
            this.lblEmpTypeName = new System.Windows.Forms.Label();
            this.txtEmpTypeName = new System.Windows.Forms.TextBox();
            this.btnEmpTypeAdd = new System.Windows.Forms.Button();
            this.btnEmpTypeUpdate = new System.Windows.Forms.Button();
            this.btnEmpTypeDelete = new System.Windows.Forms.Button();
            this.btnEmpTypeClear = new System.Windows.Forms.Button();
            this.dgvRequirementTypes = new System.Windows.Forms.DataGridView();
            this.lblReqTypeName = new System.Windows.Forms.Label();
            this.txtReqTypeName = new System.Windows.Forms.TextBox();
            this.btnReqTypeAdd = new System.Windows.Forms.Button();
            this.btnReqTypeUpdate = new System.Windows.Forms.Button();
            this.btnReqTypeDelete = new System.Windows.Forms.Button();
            this.btnReqTypeClear = new System.Windows.Forms.Button();
            this.dgvInterviewTypes = new System.Windows.Forms.DataGridView();
            this.lblIntTypeName = new System.Windows.Forms.Label();
            this.txtIntTypeName = new System.Windows.Forms.TextBox();
            this.btnIntTypeAdd = new System.Windows.Forms.Button();
            this.btnIntTypeUpdate = new System.Windows.Forms.Button();
            this.btnIntTypeDelete = new System.Windows.Forms.Button();
            this.btnIntTypeClear = new System.Windows.Forms.Button();
            this.dgvAssessmentTypes = new System.Windows.Forms.DataGridView();
            this.lblAssessTypeName = new System.Windows.Forms.Label();
            this.txtAssessTypeName = new System.Windows.Forms.TextBox();
            this.btnAssessTypeAdd = new System.Windows.Forms.Button();
            this.btnAssessTypeUpdate = new System.Windows.Forms.Button();
            this.btnAssessTypeDelete = new System.Windows.Forms.Button();
            this.btnAssessTypeClear = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabDepartments.SuspendLayout();
            this.tabEmploymentTypes.SuspendLayout();
            this.tabRequirementTypes.SuspendLayout();
            this.tabInterviewTypes.SuspendLayout();
            this.tabAssessmentTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploymentTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirementTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviewTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessmentTypes)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "MAINTENANCE MODULE";

            // btnexit
            this.btnexit.AutoSize = true;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnexit.Location = new System.Drawing.Point(730, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "X";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);

            // tabControl1
            this.tabControl1.Controls.Add(this.tabDepartments);
            this.tabControl1.Controls.Add(this.tabEmploymentTypes);
            this.tabControl1.Controls.Add(this.tabRequirementTypes);
            this.tabControl1.Controls.Add(this.tabInterviewTypes);
            this.tabControl1.Controls.Add(this.tabAssessmentTypes);
            this.tabControl1.Location = new System.Drawing.Point(14, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(730, 490);
            this.tabControl1.TabIndex = 2;

            // ════════ TAB: DEPARTMENTS ════════
            this.tabDepartments.BackColor = System.Drawing.Color.Gainsboro;
            this.tabDepartments.Controls.Add(this.dgvDepartments);
            this.tabDepartments.Controls.Add(this.lblDeptName);
            this.tabDepartments.Controls.Add(this.txtDeptName);
            this.tabDepartments.Controls.Add(this.btnDeptAdd);
            this.tabDepartments.Controls.Add(this.btnDeptUpdate);
            this.tabDepartments.Controls.Add(this.btnDeptDelete);
            this.tabDepartments.Controls.Add(this.btnDeptClear);
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(8);
            this.tabDepartments.Text = "Departments";

            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartments.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvDepartments.EnableHeadersVisualStyles = false;
            this.dgvDepartments.Location = new System.Drawing.Point(8, 8);
            this.dgvDepartments.MultiSelect = false;
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersVisible = false;
            this.dgvDepartments.RowTemplate.Height = 26;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(700, 330);
            this.dgvDepartments.TabIndex = 0;

            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeptName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDeptName.Location = new System.Drawing.Point(8, 352);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.TabIndex = 1;
            this.lblDeptName.Text = "Department Name:";

            this.txtDeptName.Location = new System.Drawing.Point(145, 349);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(250, 23);
            this.txtDeptName.TabIndex = 2;

            this.btnDeptAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeptAdd.FlatAppearance.BorderSize = 0;
            this.btnDeptAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeptAdd.ForeColor = System.Drawing.Color.White;
            this.btnDeptAdd.Location = new System.Drawing.Point(8, 390);
            this.btnDeptAdd.Name = "btnDeptAdd";
            this.btnDeptAdd.Size = new System.Drawing.Size(90, 30);
            this.btnDeptAdd.TabIndex = 3;
            this.btnDeptAdd.Text = "Add";
            this.btnDeptAdd.UseVisualStyleBackColor = false;
            this.btnDeptAdd.Click += new System.EventHandler(this.btnDeptAdd_Click);

            this.btnDeptUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDeptUpdate.FlatAppearance.BorderSize = 0;
            this.btnDeptUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeptUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDeptUpdate.Location = new System.Drawing.Point(106, 390);
            this.btnDeptUpdate.Name = "btnDeptUpdate";
            this.btnDeptUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnDeptUpdate.TabIndex = 4;
            this.btnDeptUpdate.Text = "Update";
            this.btnDeptUpdate.UseVisualStyleBackColor = false;
            this.btnDeptUpdate.Click += new System.EventHandler(this.btnDeptUpdate_Click);

            this.btnDeptDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeptDelete.FlatAppearance.BorderSize = 0;
            this.btnDeptDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeptDelete.ForeColor = System.Drawing.Color.White;
            this.btnDeptDelete.Location = new System.Drawing.Point(204, 390);
            this.btnDeptDelete.Name = "btnDeptDelete";
            this.btnDeptDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDeptDelete.TabIndex = 5;
            this.btnDeptDelete.Text = "Delete";
            this.btnDeptDelete.UseVisualStyleBackColor = false;
            this.btnDeptDelete.Click += new System.EventHandler(this.btnDeptDelete_Click);

            this.btnDeptClear.BackColor = System.Drawing.Color.Gray;
            this.btnDeptClear.FlatAppearance.BorderSize = 0;
            this.btnDeptClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeptClear.ForeColor = System.Drawing.Color.White;
            this.btnDeptClear.Location = new System.Drawing.Point(302, 390);
            this.btnDeptClear.Name = "btnDeptClear";
            this.btnDeptClear.Size = new System.Drawing.Size(90, 30);
            this.btnDeptClear.TabIndex = 6;
            this.btnDeptClear.Text = "Clear";
            this.btnDeptClear.UseVisualStyleBackColor = false;
            this.btnDeptClear.Click += new System.EventHandler(this.btnDeptClear_Click);

            // ════════ TAB: EMPLOYMENT TYPES ════════
            this.tabEmploymentTypes.BackColor = System.Drawing.Color.Gainsboro;
            this.tabEmploymentTypes.Controls.Add(this.dgvEmploymentTypes);
            this.tabEmploymentTypes.Controls.Add(this.lblEmpTypeName);
            this.tabEmploymentTypes.Controls.Add(this.txtEmpTypeName);
            this.tabEmploymentTypes.Controls.Add(this.btnEmpTypeAdd);
            this.tabEmploymentTypes.Controls.Add(this.btnEmpTypeUpdate);
            this.tabEmploymentTypes.Controls.Add(this.btnEmpTypeDelete);
            this.tabEmploymentTypes.Controls.Add(this.btnEmpTypeClear);
            this.tabEmploymentTypes.Name = "tabEmploymentTypes";
            this.tabEmploymentTypes.Padding = new System.Windows.Forms.Padding(8);
            this.tabEmploymentTypes.Text = "Employment Types";

            this.dgvEmploymentTypes.AllowUserToAddRows = false;
            this.dgvEmploymentTypes.AllowUserToDeleteRows = false;
            this.dgvEmploymentTypes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.dgvEmploymentTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmploymentTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmploymentTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmploymentTypes.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvEmploymentTypes.EnableHeadersVisualStyles = false;
            this.dgvEmploymentTypes.Location = new System.Drawing.Point(8, 8);
            this.dgvEmploymentTypes.MultiSelect = false;
            this.dgvEmploymentTypes.Name = "dgvEmploymentTypes";
            this.dgvEmploymentTypes.ReadOnly = true;
            this.dgvEmploymentTypes.RowHeadersVisible = false;
            this.dgvEmploymentTypes.RowTemplate.Height = 26;
            this.dgvEmploymentTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmploymentTypes.Size = new System.Drawing.Size(700, 330);
            this.dgvEmploymentTypes.TabIndex = 0;

            this.lblEmpTypeName.AutoSize = true;
            this.lblEmpTypeName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmpTypeName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEmpTypeName.Location = new System.Drawing.Point(8, 352);
            this.lblEmpTypeName.Name = "lblEmpTypeName";
            this.lblEmpTypeName.TabIndex = 1;
            this.lblEmpTypeName.Text = "Employment Type Name:";

            this.txtEmpTypeName.Location = new System.Drawing.Point(175, 349);
            this.txtEmpTypeName.Name = "txtEmpTypeName";
            this.txtEmpTypeName.Size = new System.Drawing.Size(250, 23);
            this.txtEmpTypeName.TabIndex = 2;

            this.btnEmpTypeAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEmpTypeAdd.FlatAppearance.BorderSize = 0;
            this.btnEmpTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpTypeAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmpTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnEmpTypeAdd.Location = new System.Drawing.Point(8, 390);
            this.btnEmpTypeAdd.Name = "btnEmpTypeAdd";
            this.btnEmpTypeAdd.Size = new System.Drawing.Size(90, 30);
            this.btnEmpTypeAdd.TabIndex = 3;
            this.btnEmpTypeAdd.Text = "Add";
            this.btnEmpTypeAdd.UseVisualStyleBackColor = false;
            this.btnEmpTypeAdd.Click += new System.EventHandler(this.btnEmpTypeAdd_Click);

            this.btnEmpTypeUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEmpTypeUpdate.FlatAppearance.BorderSize = 0;
            this.btnEmpTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpTypeUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmpTypeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnEmpTypeUpdate.Location = new System.Drawing.Point(106, 390);
            this.btnEmpTypeUpdate.Name = "btnEmpTypeUpdate";
            this.btnEmpTypeUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnEmpTypeUpdate.TabIndex = 4;
            this.btnEmpTypeUpdate.Text = "Update";
            this.btnEmpTypeUpdate.UseVisualStyleBackColor = false;
            this.btnEmpTypeUpdate.Click += new System.EventHandler(this.btnEmpTypeUpdate_Click);

            this.btnEmpTypeDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnEmpTypeDelete.FlatAppearance.BorderSize = 0;
            this.btnEmpTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpTypeDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmpTypeDelete.ForeColor = System.Drawing.Color.White;
            this.btnEmpTypeDelete.Location = new System.Drawing.Point(204, 390);
            this.btnEmpTypeDelete.Name = "btnEmpTypeDelete";
            this.btnEmpTypeDelete.Size = new System.Drawing.Size(90, 30);
            this.btnEmpTypeDelete.TabIndex = 5;
            this.btnEmpTypeDelete.Text = "Delete";
            this.btnEmpTypeDelete.UseVisualStyleBackColor = false;
            this.btnEmpTypeDelete.Click += new System.EventHandler(this.btnEmpTypeDelete_Click);

            this.btnEmpTypeClear.BackColor = System.Drawing.Color.Gray;
            this.btnEmpTypeClear.FlatAppearance.BorderSize = 0;
            this.btnEmpTypeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpTypeClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEmpTypeClear.ForeColor = System.Drawing.Color.White;
            this.btnEmpTypeClear.Location = new System.Drawing.Point(302, 390);
            this.btnEmpTypeClear.Name = "btnEmpTypeClear";
            this.btnEmpTypeClear.Size = new System.Drawing.Size(90, 30);
            this.btnEmpTypeClear.TabIndex = 6;
            this.btnEmpTypeClear.Text = "Clear";
            this.btnEmpTypeClear.UseVisualStyleBackColor = false;
            this.btnEmpTypeClear.Click += new System.EventHandler(this.btnEmpTypeClear_Click);

            // ════════ TAB: REQUIREMENT TYPES ════════
            this.tabRequirementTypes.BackColor = System.Drawing.Color.Gainsboro;
            this.tabRequirementTypes.Controls.Add(this.dgvRequirementTypes);
            this.tabRequirementTypes.Controls.Add(this.lblReqTypeName);
            this.tabRequirementTypes.Controls.Add(this.txtReqTypeName);
            this.tabRequirementTypes.Controls.Add(this.btnReqTypeAdd);
            this.tabRequirementTypes.Controls.Add(this.btnReqTypeUpdate);
            this.tabRequirementTypes.Controls.Add(this.btnReqTypeDelete);
            this.tabRequirementTypes.Controls.Add(this.btnReqTypeClear);
            this.tabRequirementTypes.Name = "tabRequirementTypes";
            this.tabRequirementTypes.Padding = new System.Windows.Forms.Padding(8);
            this.tabRequirementTypes.Text = "Requirement Types";

            this.dgvRequirementTypes.AllowUserToAddRows = false;
            this.dgvRequirementTypes.AllowUserToDeleteRows = false;
            this.dgvRequirementTypes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.dgvRequirementTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequirementTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequirementTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequirementTypes.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvRequirementTypes.EnableHeadersVisualStyles = false;
            this.dgvRequirementTypes.Location = new System.Drawing.Point(8, 8);
            this.dgvRequirementTypes.MultiSelect = false;
            this.dgvRequirementTypes.Name = "dgvRequirementTypes";
            this.dgvRequirementTypes.ReadOnly = true;
            this.dgvRequirementTypes.RowHeadersVisible = false;
            this.dgvRequirementTypes.RowTemplate.Height = 26;
            this.dgvRequirementTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequirementTypes.Size = new System.Drawing.Size(700, 330);
            this.dgvRequirementTypes.TabIndex = 0;

            this.lblReqTypeName.AutoSize = true;
            this.lblReqTypeName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReqTypeName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblReqTypeName.Location = new System.Drawing.Point(8, 352);
            this.lblReqTypeName.Name = "lblReqTypeName";
            this.lblReqTypeName.TabIndex = 1;
            this.lblReqTypeName.Text = "Requirement Name:";

            this.txtReqTypeName.Location = new System.Drawing.Point(155, 349);
            this.txtReqTypeName.Name = "txtReqTypeName";
            this.txtReqTypeName.Size = new System.Drawing.Size(250, 23);
            this.txtReqTypeName.TabIndex = 2;

            this.btnReqTypeAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnReqTypeAdd.FlatAppearance.BorderSize = 0;
            this.btnReqTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqTypeAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReqTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnReqTypeAdd.Location = new System.Drawing.Point(8, 390);
            this.btnReqTypeAdd.Name = "btnReqTypeAdd";
            this.btnReqTypeAdd.Size = new System.Drawing.Size(90, 30);
            this.btnReqTypeAdd.TabIndex = 3;
            this.btnReqTypeAdd.Text = "Add";
            this.btnReqTypeAdd.UseVisualStyleBackColor = false;
            this.btnReqTypeAdd.Click += new System.EventHandler(this.btnReqTypeAdd_Click);

            this.btnReqTypeUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReqTypeUpdate.FlatAppearance.BorderSize = 0;
            this.btnReqTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqTypeUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReqTypeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnReqTypeUpdate.Location = new System.Drawing.Point(106, 390);
            this.btnReqTypeUpdate.Name = "btnReqTypeUpdate";
            this.btnReqTypeUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnReqTypeUpdate.TabIndex = 4;
            this.btnReqTypeUpdate.Text = "Update";
            this.btnReqTypeUpdate.UseVisualStyleBackColor = false;
            this.btnReqTypeUpdate.Click += new System.EventHandler(this.btnReqTypeUpdate_Click);

            this.btnReqTypeDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnReqTypeDelete.FlatAppearance.BorderSize = 0;
            this.btnReqTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqTypeDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReqTypeDelete.ForeColor = System.Drawing.Color.White;
            this.btnReqTypeDelete.Location = new System.Drawing.Point(204, 390);
            this.btnReqTypeDelete.Name = "btnReqTypeDelete";
            this.btnReqTypeDelete.Size = new System.Drawing.Size(90, 30);
            this.btnReqTypeDelete.TabIndex = 5;
            this.btnReqTypeDelete.Text = "Delete";
            this.btnReqTypeDelete.UseVisualStyleBackColor = false;
            this.btnReqTypeDelete.Click += new System.EventHandler(this.btnReqTypeDelete_Click);

            this.btnReqTypeClear.BackColor = System.Drawing.Color.Gray;
            this.btnReqTypeClear.FlatAppearance.BorderSize = 0;
            this.btnReqTypeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReqTypeClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReqTypeClear.ForeColor = System.Drawing.Color.White;
            this.btnReqTypeClear.Location = new System.Drawing.Point(302, 390);
            this.btnReqTypeClear.Name = "btnReqTypeClear";
            this.btnReqTypeClear.Size = new System.Drawing.Size(90, 30);
            this.btnReqTypeClear.TabIndex = 6;
            this.btnReqTypeClear.Text = "Clear";
            this.btnReqTypeClear.UseVisualStyleBackColor = false;
            this.btnReqTypeClear.Click += new System.EventHandler(this.btnReqTypeClear_Click);

            // ════════ TAB: INTERVIEW TYPES ════════
            this.tabInterviewTypes.BackColor = System.Drawing.Color.Gainsboro;
            this.tabInterviewTypes.Controls.Add(this.dgvInterviewTypes);
            this.tabInterviewTypes.Controls.Add(this.lblIntTypeName);
            this.tabInterviewTypes.Controls.Add(this.txtIntTypeName);
            this.tabInterviewTypes.Controls.Add(this.btnIntTypeAdd);
            this.tabInterviewTypes.Controls.Add(this.btnIntTypeUpdate);
            this.tabInterviewTypes.Controls.Add(this.btnIntTypeDelete);
            this.tabInterviewTypes.Controls.Add(this.btnIntTypeClear);
            this.tabInterviewTypes.Name = "tabInterviewTypes";
            this.tabInterviewTypes.Padding = new System.Windows.Forms.Padding(8);
            this.tabInterviewTypes.Text = "Interview Types";

            this.dgvInterviewTypes.AllowUserToAddRows = false;
            this.dgvInterviewTypes.AllowUserToDeleteRows = false;
            this.dgvInterviewTypes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.dgvInterviewTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInterviewTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvInterviewTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInterviewTypes.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvInterviewTypes.EnableHeadersVisualStyles = false;
            this.dgvInterviewTypes.Location = new System.Drawing.Point(8, 8);
            this.dgvInterviewTypes.MultiSelect = false;
            this.dgvInterviewTypes.Name = "dgvInterviewTypes";
            this.dgvInterviewTypes.ReadOnly = true;
            this.dgvInterviewTypes.RowHeadersVisible = false;
            this.dgvInterviewTypes.RowTemplate.Height = 26;
            this.dgvInterviewTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterviewTypes.Size = new System.Drawing.Size(700, 330);
            this.dgvInterviewTypes.TabIndex = 0;

            this.lblIntTypeName.AutoSize = true;
            this.lblIntTypeName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIntTypeName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIntTypeName.Location = new System.Drawing.Point(8, 352);
            this.lblIntTypeName.Name = "lblIntTypeName";
            this.lblIntTypeName.TabIndex = 1;
            this.lblIntTypeName.Text = "Interview Type Name:";

            this.txtIntTypeName.Location = new System.Drawing.Point(160, 349);
            this.txtIntTypeName.Name = "txtIntTypeName";
            this.txtIntTypeName.Size = new System.Drawing.Size(250, 23);
            this.txtIntTypeName.TabIndex = 2;

            this.btnIntTypeAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnIntTypeAdd.FlatAppearance.BorderSize = 0;
            this.btnIntTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntTypeAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIntTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnIntTypeAdd.Location = new System.Drawing.Point(8, 390);
            this.btnIntTypeAdd.Name = "btnIntTypeAdd";
            this.btnIntTypeAdd.Size = new System.Drawing.Size(90, 30);
            this.btnIntTypeAdd.TabIndex = 3;
            this.btnIntTypeAdd.Text = "Add";
            this.btnIntTypeAdd.UseVisualStyleBackColor = false;
            this.btnIntTypeAdd.Click += new System.EventHandler(this.btnIntTypeAdd_Click);

            this.btnIntTypeUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnIntTypeUpdate.FlatAppearance.BorderSize = 0;
            this.btnIntTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntTypeUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIntTypeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnIntTypeUpdate.Location = new System.Drawing.Point(106, 390);
            this.btnIntTypeUpdate.Name = "btnIntTypeUpdate";
            this.btnIntTypeUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnIntTypeUpdate.TabIndex = 4;
            this.btnIntTypeUpdate.Text = "Update";
            this.btnIntTypeUpdate.UseVisualStyleBackColor = false;
            this.btnIntTypeUpdate.Click += new System.EventHandler(this.btnIntTypeUpdate_Click);

            this.btnIntTypeDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnIntTypeDelete.FlatAppearance.BorderSize = 0;
            this.btnIntTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntTypeDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIntTypeDelete.ForeColor = System.Drawing.Color.White;
            this.btnIntTypeDelete.Location = new System.Drawing.Point(204, 390);
            this.btnIntTypeDelete.Name = "btnIntTypeDelete";
            this.btnIntTypeDelete.Size = new System.Drawing.Size(90, 30);
            this.btnIntTypeDelete.TabIndex = 5;
            this.btnIntTypeDelete.Text = "Delete";
            this.btnIntTypeDelete.UseVisualStyleBackColor = false;
            this.btnIntTypeDelete.Click += new System.EventHandler(this.btnIntTypeDelete_Click);

            this.btnIntTypeClear.BackColor = System.Drawing.Color.Gray;
            this.btnIntTypeClear.FlatAppearance.BorderSize = 0;
            this.btnIntTypeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntTypeClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnIntTypeClear.ForeColor = System.Drawing.Color.White;
            this.btnIntTypeClear.Location = new System.Drawing.Point(302, 390);
            this.btnIntTypeClear.Name = "btnIntTypeClear";
            this.btnIntTypeClear.Size = new System.Drawing.Size(90, 30);
            this.btnIntTypeClear.TabIndex = 6;
            this.btnIntTypeClear.Text = "Clear";
            this.btnIntTypeClear.UseVisualStyleBackColor = false;
            this.btnIntTypeClear.Click += new System.EventHandler(this.btnIntTypeClear_Click);

            // ════════ TAB: ASSESSMENT TYPES ════════
            this.tabAssessmentTypes.BackColor = System.Drawing.Color.Gainsboro;
            this.tabAssessmentTypes.Controls.Add(this.dgvAssessmentTypes);
            this.tabAssessmentTypes.Controls.Add(this.lblAssessTypeName);
            this.tabAssessmentTypes.Controls.Add(this.txtAssessTypeName);
            this.tabAssessmentTypes.Controls.Add(this.btnAssessTypeAdd);
            this.tabAssessmentTypes.Controls.Add(this.btnAssessTypeUpdate);
            this.tabAssessmentTypes.Controls.Add(this.btnAssessTypeDelete);
            this.tabAssessmentTypes.Controls.Add(this.btnAssessTypeClear);
            this.tabAssessmentTypes.Name = "tabAssessmentTypes";
            this.tabAssessmentTypes.Padding = new System.Windows.Forms.Padding(8);
            this.tabAssessmentTypes.Text = "Assessment Types";

            this.dgvAssessmentTypes.AllowUserToAddRows = false;
            this.dgvAssessmentTypes.AllowUserToDeleteRows = false;
            this.dgvAssessmentTypes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.dgvAssessmentTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssessmentTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssessmentTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssessmentTypes.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvAssessmentTypes.EnableHeadersVisualStyles = false;
            this.dgvAssessmentTypes.Location = new System.Drawing.Point(8, 8);
            this.dgvAssessmentTypes.MultiSelect = false;
            this.dgvAssessmentTypes.Name = "dgvAssessmentTypes";
            this.dgvAssessmentTypes.ReadOnly = true;
            this.dgvAssessmentTypes.RowHeadersVisible = false;
            this.dgvAssessmentTypes.RowTemplate.Height = 26;
            this.dgvAssessmentTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssessmentTypes.Size = new System.Drawing.Size(700, 330);
            this.dgvAssessmentTypes.TabIndex = 0;

            this.lblAssessTypeName.AutoSize = true;
            this.lblAssessTypeName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAssessTypeName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAssessTypeName.Location = new System.Drawing.Point(8, 352);
            this.lblAssessTypeName.Name = "lblAssessTypeName";
            this.lblAssessTypeName.TabIndex = 1;
            this.lblAssessTypeName.Text = "Assessment Type Name:";

            this.txtAssessTypeName.Location = new System.Drawing.Point(175, 349);
            this.txtAssessTypeName.Name = "txtAssessTypeName";
            this.txtAssessTypeName.Size = new System.Drawing.Size(250, 23);
            this.txtAssessTypeName.TabIndex = 2;

            this.btnAssessTypeAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAssessTypeAdd.FlatAppearance.BorderSize = 0;
            this.btnAssessTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessTypeAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssessTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnAssessTypeAdd.Location = new System.Drawing.Point(8, 390);
            this.btnAssessTypeAdd.Name = "btnAssessTypeAdd";
            this.btnAssessTypeAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAssessTypeAdd.TabIndex = 3;
            this.btnAssessTypeAdd.Text = "Add";
            this.btnAssessTypeAdd.UseVisualStyleBackColor = false;
            this.btnAssessTypeAdd.Click += new System.EventHandler(this.btnAssessTypeAdd_Click);

            this.btnAssessTypeUpdate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAssessTypeUpdate.FlatAppearance.BorderSize = 0;
            this.btnAssessTypeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessTypeUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssessTypeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAssessTypeUpdate.Location = new System.Drawing.Point(106, 390);
            this.btnAssessTypeUpdate.Name = "btnAssessTypeUpdate";
            this.btnAssessTypeUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnAssessTypeUpdate.TabIndex = 4;
            this.btnAssessTypeUpdate.Text = "Update";
            this.btnAssessTypeUpdate.UseVisualStyleBackColor = false;
            this.btnAssessTypeUpdate.Click += new System.EventHandler(this.btnAssessTypeUpdate_Click);

            this.btnAssessTypeDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnAssessTypeDelete.FlatAppearance.BorderSize = 0;
            this.btnAssessTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessTypeDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssessTypeDelete.ForeColor = System.Drawing.Color.White;
            this.btnAssessTypeDelete.Location = new System.Drawing.Point(204, 390);
            this.btnAssessTypeDelete.Name = "btnAssessTypeDelete";
            this.btnAssessTypeDelete.Size = new System.Drawing.Size(90, 30);
            this.btnAssessTypeDelete.TabIndex = 5;
            this.btnAssessTypeDelete.Text = "Delete";
            this.btnAssessTypeDelete.UseVisualStyleBackColor = false;
            this.btnAssessTypeDelete.Click += new System.EventHandler(this.btnAssessTypeDelete_Click);

            this.btnAssessTypeClear.BackColor = System.Drawing.Color.Gray;
            this.btnAssessTypeClear.FlatAppearance.BorderSize = 0;
            this.btnAssessTypeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessTypeClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssessTypeClear.ForeColor = System.Drawing.Color.White;
            this.btnAssessTypeClear.Location = new System.Drawing.Point(302, 390);
            this.btnAssessTypeClear.Name = "btnAssessTypeClear";
            this.btnAssessTypeClear.Size = new System.Drawing.Size(90, 30);
            this.btnAssessTypeClear.TabIndex = 6;
            this.btnAssessTypeClear.Text = "Clear";
            this.btnAssessTypeClear.UseVisualStyleBackColor = false;
            this.btnAssessTypeClear.Click += new System.EventHandler(this.btnAssessTypeClear_Click);

            // ── Form ──────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(758, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHRMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Module";
            this.Load += new System.EventHandler(this.FormHRMaintenance_Load);

            this.tabControl1.ResumeLayout(false);
            this.tabDepartments.ResumeLayout(false);
            this.tabDepartments.PerformLayout();
            this.tabEmploymentTypes.ResumeLayout(false);
            this.tabEmploymentTypes.PerformLayout();
            this.tabRequirementTypes.ResumeLayout(false);
            this.tabRequirementTypes.PerformLayout();
            this.tabInterviewTypes.ResumeLayout(false);
            this.tabInterviewTypes.PerformLayout();
            this.tabAssessmentTypes.ResumeLayout(false);
            this.tabAssessmentTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploymentTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirementTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviewTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessmentTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnexit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDepartments;
        private System.Windows.Forms.TabPage tabEmploymentTypes;
        private System.Windows.Forms.TabPage tabRequirementTypes;
        private System.Windows.Forms.TabPage tabInterviewTypes;
        private System.Windows.Forms.TabPage tabAssessmentTypes;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Button btnDeptAdd;
        private System.Windows.Forms.Button btnDeptUpdate;
        private System.Windows.Forms.Button btnDeptDelete;
        private System.Windows.Forms.Button btnDeptClear;
        private System.Windows.Forms.DataGridView dgvEmploymentTypes;
        private System.Windows.Forms.Label lblEmpTypeName;
        private System.Windows.Forms.TextBox txtEmpTypeName;
        private System.Windows.Forms.Button btnEmpTypeAdd;
        private System.Windows.Forms.Button btnEmpTypeUpdate;
        private System.Windows.Forms.Button btnEmpTypeDelete;
        private System.Windows.Forms.Button btnEmpTypeClear;
        private System.Windows.Forms.DataGridView dgvRequirementTypes;
        private System.Windows.Forms.Label lblReqTypeName;
        private System.Windows.Forms.TextBox txtReqTypeName;
        private System.Windows.Forms.Button btnReqTypeAdd;
        private System.Windows.Forms.Button btnReqTypeUpdate;
        private System.Windows.Forms.Button btnReqTypeDelete;
        private System.Windows.Forms.Button btnReqTypeClear;
        private System.Windows.Forms.DataGridView dgvInterviewTypes;
        private System.Windows.Forms.Label lblIntTypeName;
        private System.Windows.Forms.TextBox txtIntTypeName;
        private System.Windows.Forms.Button btnIntTypeAdd;
        private System.Windows.Forms.Button btnIntTypeUpdate;
        private System.Windows.Forms.Button btnIntTypeDelete;
        private System.Windows.Forms.Button btnIntTypeClear;
        private System.Windows.Forms.DataGridView dgvAssessmentTypes;
        private System.Windows.Forms.Label lblAssessTypeName;
        private System.Windows.Forms.TextBox txtAssessTypeName;
        private System.Windows.Forms.Button btnAssessTypeAdd;
        private System.Windows.Forms.Button btnAssessTypeUpdate;
        private System.Windows.Forms.Button btnAssessTypeDelete;
        private System.Windows.Forms.Button btnAssessTypeClear;
    }
}