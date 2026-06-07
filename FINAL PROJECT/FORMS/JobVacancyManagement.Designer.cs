namespace FINAL_PROJECT.FORMS
{
    partial class JobVacancyManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOpen = new System.Windows.Forms.Panel();
            this.lblOpen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDraft = new System.Windows.Forms.Panel();
            this.lblDraft = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelClose = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.cmbFilterDepartment = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelVacancy = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtQualifications = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.numSlots = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExitVacancy = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelTotal.SuspendLayout();
            this.panelOpen.SuspendLayout();
            this.panelDraft.SuspendLayout();
            this.panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelVacancy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(296, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Vacancy Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.SystemColors.Window;
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Controls.Add(this.label2);
            this.panelTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTotal.Location = new System.Drawing.Point(101, 145);
            this.panelTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(185, 105);
            this.panelTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTotal.Location = new System.Drawing.Point(39, 38);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 40);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Vacancies";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelOpen
            // 
            this.panelOpen.BackColor = System.Drawing.SystemColors.Window;
            this.panelOpen.Controls.Add(this.lblOpen);
            this.panelOpen.Controls.Add(this.label3);
            this.panelOpen.ForeColor = System.Drawing.SystemColors.Control;
            this.panelOpen.Location = new System.Drawing.Point(327, 145);
            this.panelOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOpen.Name = "panelOpen";
            this.panelOpen.Size = new System.Drawing.Size(185, 105);
            this.panelOpen.TabIndex = 2;
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.ForeColor = System.Drawing.Color.Green;
            this.lblOpen.Location = new System.Drawing.Point(43, 38);
            this.lblOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(34, 40);
            this.lblOpen.TabIndex = 2;
            this.lblOpen.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Open";
            // 
            // panelDraft
            // 
            this.panelDraft.BackColor = System.Drawing.SystemColors.Window;
            this.panelDraft.Controls.Add(this.lblDraft);
            this.panelDraft.Controls.Add(this.label4);
            this.panelDraft.ForeColor = System.Drawing.SystemColors.Control;
            this.panelDraft.Location = new System.Drawing.Point(544, 145);
            this.panelDraft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDraft.Name = "panelDraft";
            this.panelDraft.Size = new System.Drawing.Size(185, 105);
            this.panelDraft.TabIndex = 2;
            // 
            // lblDraft
            // 
            this.lblDraft.AutoSize = true;
            this.lblDraft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraft.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblDraft.Location = new System.Drawing.Point(25, 38);
            this.lblDraft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDraft.Name = "lblDraft";
            this.lblDraft.Size = new System.Drawing.Size(35, 41);
            this.lblDraft.TabIndex = 3;
            this.lblDraft.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Draft";
            // 
            // panelClose
            // 
            this.panelClose.BackColor = System.Drawing.SystemColors.Window;
            this.panelClose.Controls.Add(this.lblClose);
            this.panelClose.Controls.Add(this.label5);
            this.panelClose.ForeColor = System.Drawing.SystemColors.Control;
            this.panelClose.Location = new System.Drawing.Point(767, 145);
            this.panelClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(185, 105);
            this.panelClose.TabIndex = 2;
            this.panelClose.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClose_Paint);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(28, 38);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 41);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Close";
            // 
            // txtSearchbar
            // 
            this.txtSearchbar.Location = new System.Drawing.Point(99, 282);
            this.txtSearchbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchbar.Name = "txtSearchbar";
            this.txtSearchbar.Size = new System.Drawing.Size(848, 22);
            this.txtSearchbar.TabIndex = 3;
            this.txtSearchbar.TextChanged += new System.EventHandler(this.tbxSearchbar_TextChanged);
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Open",
            "Close",
            "Draft"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(101, 331);
            this.cmbFilterStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(845, 24);
            this.cmbFilterStatus.TabIndex = 4;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatuses_SelectedIndexChanged);
            // 
            // cmbFilterDepartment
            // 
            this.cmbFilterDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterDepartment.FormattingEnabled = true;
            this.cmbFilterDepartment.Items.AddRange(new object[] {
            "HR",
            "Engineering",
            "IT",
            "Finance"});
            this.cmbFilterDepartment.Location = new System.Drawing.Point(101, 378);
            this.cmbFilterDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFilterDepartment.Name = "cmbFilterDepartment";
            this.cmbFilterDepartment.Size = new System.Drawing.Size(847, 24);
            this.cmbFilterDepartment.TabIndex = 5;
            this.cmbFilterDepartment.SelectedIndexChanged += new System.EventHandler(this.comboDepartment_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 411);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(848, 149);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(805, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "+ Add Vacancy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(97, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Search:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(97, 311);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 358);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Department:";
            // 
            // panelVacancy
            // 
            this.panelVacancy.BackColor = System.Drawing.SystemColors.Window;
            this.panelVacancy.Controls.Add(this.btnSave);
            this.panelVacancy.Controls.Add(this.cmbStatus);
            this.panelVacancy.Controls.Add(this.label20);
            this.panelVacancy.Controls.Add(this.txtQualifications);
            this.panelVacancy.Controls.Add(this.label19);
            this.panelVacancy.Controls.Add(this.label18);
            this.panelVacancy.Controls.Add(this.dtpDeadline);
            this.panelVacancy.Controls.Add(this.numSlots);
            this.panelVacancy.Controls.Add(this.label17);
            this.panelVacancy.Controls.Add(this.cmbDepartment);
            this.panelVacancy.Controls.Add(this.label16);
            this.panelVacancy.Controls.Add(this.txtJobTitle);
            this.panelVacancy.Controls.Add(this.label15);
            this.panelVacancy.Controls.Add(this.btnExitVacancy);
            this.panelVacancy.Controls.Add(this.label13);
            this.panelVacancy.Location = new System.Drawing.Point(101, 623);
            this.panelVacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVacancy.Name = "panelVacancy";
            this.panelVacancy.Size = new System.Drawing.Size(505, 507);
            this.panelVacancy.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(339, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 39);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "Close",
            "Draft"});
            this.cmbStatus.Location = new System.Drawing.Point(21, 410);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(179, 24);
            this.cmbStatus.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label20.Location = new System.Drawing.Point(17, 390);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 13;
            this.label20.Text = "Status";
            // 
            // txtQualifications
            // 
            this.txtQualifications.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQualifications.Location = new System.Drawing.Point(21, 305);
            this.txtQualifications.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQualifications.Multiline = true;
            this.txtQualifications.Name = "txtQualifications";
            this.txtQualifications.Size = new System.Drawing.Size(435, 67);
            this.txtQualifications.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(17, 286);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "Qualifications";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(17, 229);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "Application Deadline";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeadline.Location = new System.Drawing.Point(21, 249);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDeadline.MinDate = new System.DateTime(2026, 6, 7, 14, 39, 2, 0);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(160, 22);
            this.dtpDeadline.TabIndex = 9;
            this.dtpDeadline.Value = new System.DateTime(2026, 6, 7, 14, 39, 2, 0);
            // 
            // numSlots
            // 
            this.numSlots.Location = new System.Drawing.Point(247, 191);
            this.numSlots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSlots.Name = "numSlots";
            this.numSlots.Size = new System.Drawing.Size(160, 22);
            this.numSlots.TabIndex = 8;
            this.numSlots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(243, 171);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Number of Slots";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "HR",
            "Engineering",
            "IT",
            "Finance"});
            this.cmbDepartment.Location = new System.Drawing.Point(21, 191);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(179, 24);
            this.cmbDepartment.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(17, 171);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Department";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Location = new System.Drawing.Point(21, 132);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(435, 26);
            this.txtJobTitle.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(17, 112);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Job title";
            // 
            // btnExitVacancy
            // 
            this.btnExitVacancy.BackColor = System.Drawing.Color.Transparent;
            this.btnExitVacancy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitVacancy.ForeColor = System.Drawing.Color.Red;
            this.btnExitVacancy.Location = new System.Drawing.Point(388, 21);
            this.btnExitVacancy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExitVacancy.Name = "btnExitVacancy";
            this.btnExitVacancy.Size = new System.Drawing.Size(100, 38);
            this.btnExitVacancy.TabIndex = 1;
            this.btnExitVacancy.Text = "X";
            this.btnExitVacancy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExitVacancy.UseVisualStyleBackColor = false;
            this.btnExitVacancy.Click += new System.EventHandler(this.btnExitVacancy_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Add new vacancy";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(867, 567);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 30);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // JobVacancyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 1055);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelVacancy);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbFilterDepartment);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.txtSearchbar);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.panelDraft);
            this.Controls.Add(this.panelOpen);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JobVacancyManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobVacancyManagement";
            this.Load += new System.EventHandler(this.JobVacancyManagement_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelOpen.ResumeLayout(false);
            this.panelOpen.PerformLayout();
            this.panelDraft.ResumeLayout(false);
            this.panelDraft.PerformLayout();
            this.panelClose.ResumeLayout(false);
            this.panelClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelVacancy.ResumeLayout(false);
            this.panelVacancy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelOpen;
        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchbar;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterDepartment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblDraft;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelVacancy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExitVacancy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numSlots;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtQualifications;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnEdit;
    }
}