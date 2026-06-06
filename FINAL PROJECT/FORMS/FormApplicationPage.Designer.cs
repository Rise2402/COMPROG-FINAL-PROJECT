namespace FINAL_PROJECT.FORMS
{
    partial class FormApplicationPage
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnEditApplication = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlNoApplication = new System.Windows.Forms.Panel();
            this.lblNoAppIcon = new System.Windows.Forms.Label();
            this.lblNoAppMsg = new System.Windows.Forms.Label();
            this.lblNoAppSub = new System.Windows.Forms.Label();
            this.btnBrowseJobs = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.grpApplicationInfo = new System.Windows.Forms.GroupBox();
            this.lblJobAppliedTitle = new System.Windows.Forms.Label();
            this.lblJobApplied = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDateAppliedTitle = new System.Windows.Forms.Label();
            this.lblDateApplied = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSkillsTitle = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditPhone = new System.Windows.Forms.Label();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.lblEditAddress = new System.Windows.Forms.Label();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.lblEditSkills = new System.Windows.Forms.Label();
            this.txtEditSkills = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.pnlNoApplication.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.grpApplicationInfo.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.grpEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblPageSubtitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(860, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(20, 10);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(235, 41);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "My Application";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.AutoSize = true;
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.lblPageSubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(266, 20);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "View and manage your job application";
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.pnlNav.Controls.Add(this.btnViewStatus);
            this.pnlNav.Controls.Add(this.btnEditApplication);
            this.pnlNav.Controls.Add(this.btnBack);
            this.pnlNav.Location = new System.Drawing.Point(0, 75);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(860, 55);
            this.pnlNav.TabIndex = 1;
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnViewStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStatus.FlatAppearance.BorderSize = 0;
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewStatus.ForeColor = System.Drawing.Color.White;
            this.btnViewStatus.Location = new System.Drawing.Point(20, 12);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(140, 32);
            this.btnViewStatus.TabIndex = 0;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnEditApplication
            // 
            this.btnEditApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEditApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditApplication.FlatAppearance.BorderSize = 0;
            this.btnEditApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditApplication.ForeColor = System.Drawing.Color.White;
            this.btnEditApplication.Location = new System.Drawing.Point(170, 12);
            this.btnEditApplication.Name = "btnEditApplication";
            this.btnEditApplication.Size = new System.Drawing.Size(160, 32);
            this.btnEditApplication.TabIndex = 1;
            this.btnEditApplication.Text = "Edit Application";
            this.btnEditApplication.UseVisualStyleBackColor = false;
            this.btnEditApplication.Click += new System.EventHandler(this.btnEditApplication_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(750, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 32);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlNoApplication
            // 
            this.pnlNoApplication.BackColor = System.Drawing.Color.White;
            this.pnlNoApplication.Controls.Add(this.lblNoAppIcon);
            this.pnlNoApplication.Controls.Add(this.lblNoAppMsg);
            this.pnlNoApplication.Controls.Add(this.lblNoAppSub);
            this.pnlNoApplication.Controls.Add(this.btnBrowseJobs);
            this.pnlNoApplication.Location = new System.Drawing.Point(20, 145);
            this.pnlNoApplication.Name = "pnlNoApplication";
            this.pnlNoApplication.Size = new System.Drawing.Size(820, 460);
            this.pnlNoApplication.TabIndex = 2;
            this.pnlNoApplication.Visible = false;
            this.pnlNoApplication.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNoApplication_Paint);
            // 
            // lblNoAppIcon
            // 
            this.lblNoAppIcon.AutoSize = true;
            this.lblNoAppIcon.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.lblNoAppIcon.Location = new System.Drawing.Point(340, 73);
            this.lblNoAppIcon.Name = "lblNoAppIcon";
            this.lblNoAppIcon.Size = new System.Drawing.Size(155, 106);
            this.lblNoAppIcon.TabIndex = 0;
            this.lblNoAppIcon.Text = "📄";
            this.lblNoAppIcon.Click += new System.EventHandler(this.lblNoAppIcon_Click);
            // 
            // lblNoAppMsg
            // 
            this.lblNoAppMsg.AutoSize = true;
            this.lblNoAppMsg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNoAppMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblNoAppMsg.Location = new System.Drawing.Point(270, 170);
            this.lblNoAppMsg.Name = "lblNoAppMsg";
            this.lblNoAppMsg.Size = new System.Drawing.Size(283, 41);
            this.lblNoAppMsg.TabIndex = 1;
            this.lblNoAppMsg.Text = "No Application Yet";
            // 
            // lblNoAppSub
            // 
            this.lblNoAppSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNoAppSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblNoAppSub.Location = new System.Drawing.Point(220, 210);
            this.lblNoAppSub.Name = "lblNoAppSub";
            this.lblNoAppSub.Size = new System.Drawing.Size(380, 45);
            this.lblNoAppSub.TabIndex = 2;
            this.lblNoAppSub.Text = "You haven\'t applied for any job yet.";
            this.lblNoAppSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowseJobs
            // 
            this.btnBrowseJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBrowseJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseJobs.FlatAppearance.BorderSize = 0;
            this.btnBrowseJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseJobs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBrowseJobs.ForeColor = System.Drawing.Color.White;
            this.btnBrowseJobs.Location = new System.Drawing.Point(310, 275);
            this.btnBrowseJobs.Name = "btnBrowseJobs";
            this.btnBrowseJobs.Size = new System.Drawing.Size(200, 40);
            this.btnBrowseJobs.TabIndex = 3;
            this.btnBrowseJobs.Text = "Browse Open Jobs";
            this.btnBrowseJobs.UseVisualStyleBackColor = false;
            this.btnBrowseJobs.Click += new System.EventHandler(this.btnBrowseJobs_Click);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.Transparent;
            this.pnlView.Controls.Add(this.grpApplicationInfo);
            this.pnlView.Controls.Add(this.grpPersonalInfo);
            this.pnlView.Location = new System.Drawing.Point(20, 145);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(820, 490);
            this.pnlView.TabIndex = 3;
            this.pnlView.Visible = false;
            // 
            // grpApplicationInfo
            // 
            this.grpApplicationInfo.BackColor = System.Drawing.Color.White;
            this.grpApplicationInfo.Controls.Add(this.lblJobAppliedTitle);
            this.grpApplicationInfo.Controls.Add(this.lblJobApplied);
            this.grpApplicationInfo.Controls.Add(this.lblStatusTitle);
            this.grpApplicationInfo.Controls.Add(this.lblStatus);
            this.grpApplicationInfo.Controls.Add(this.lblDateAppliedTitle);
            this.grpApplicationInfo.Controls.Add(this.lblDateApplied);
            this.grpApplicationInfo.Controls.Add(this.btnSubmit);
            this.grpApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.grpApplicationInfo.Name = "grpApplicationInfo";
            this.grpApplicationInfo.Size = new System.Drawing.Size(820, 160);
            this.grpApplicationInfo.TabIndex = 0;
            this.grpApplicationInfo.TabStop = false;
            this.grpApplicationInfo.Text = "Application Info";
            // 
            // lblJobAppliedTitle
            // 
            this.lblJobAppliedTitle.AutoSize = true;
            this.lblJobAppliedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJobAppliedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblJobAppliedTitle.Location = new System.Drawing.Point(15, 30);
            this.lblJobAppliedTitle.Name = "lblJobAppliedTitle";
            this.lblJobAppliedTitle.Size = new System.Drawing.Size(128, 20);
            this.lblJobAppliedTitle.TabIndex = 0;
            this.lblJobAppliedTitle.Text = "Position Applied:";
            // 
            // lblJobApplied
            // 
            this.lblJobApplied.AutoSize = true;
            this.lblJobApplied.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblJobApplied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.lblJobApplied.Location = new System.Drawing.Point(15, 50);
            this.lblJobApplied.Name = "lblJobApplied";
            this.lblJobApplied.Size = new System.Drawing.Size(31, 25);
            this.lblJobApplied.TabIndex = 1;
            this.lblJobApplied.Text = "—";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblStatusTitle.Location = new System.Drawing.Point(15, 85);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(57, 20);
            this.lblStatusTitle.TabIndex = 2;
            this.lblStatusTitle.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(15, 105);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblStatus.Size = new System.Drawing.Size(160, 24);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "—";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateAppliedTitle
            // 
            this.lblDateAppliedTitle.AutoSize = true;
            this.lblDateAppliedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateAppliedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblDateAppliedTitle.Location = new System.Drawing.Point(220, 85);
            this.lblDateAppliedTitle.Name = "lblDateAppliedTitle";
            this.lblDateAppliedTitle.Size = new System.Drawing.Size(104, 20);
            this.lblDateAppliedTitle.TabIndex = 4;
            this.lblDateAppliedTitle.Text = "Date Applied:";
            // 
            // lblDateApplied
            // 
            this.lblDateApplied.AutoSize = true;
            this.lblDateApplied.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateApplied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblDateApplied.Location = new System.Drawing.Point(220, 107);
            this.lblDateApplied.Name = "lblDateApplied";
            this.lblDateApplied.Size = new System.Drawing.Size(27, 23);
            this.lblDateApplied.TabIndex = 5;
            this.lblDateApplied.Text = "—";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(610, 95);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(190, 38);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit Application";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.BackColor = System.Drawing.Color.White;
            this.grpPersonalInfo.Controls.Add(this.lblNameTitle);
            this.grpPersonalInfo.Controls.Add(this.lblApplicantName);
            this.grpPersonalInfo.Controls.Add(this.lblEmailTitle);
            this.grpPersonalInfo.Controls.Add(this.lblEmail);
            this.grpPersonalInfo.Controls.Add(this.lblPhoneTitle);
            this.grpPersonalInfo.Controls.Add(this.lblPhone);
            this.grpPersonalInfo.Controls.Add(this.lblAddressTitle);
            this.grpPersonalInfo.Controls.Add(this.lblAddress);
            this.grpPersonalInfo.Controls.Add(this.lblSkillsTitle);
            this.grpPersonalInfo.Controls.Add(this.lblSkills);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPersonalInfo.Location = new System.Drawing.Point(0, 170);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(820, 300);
            this.grpPersonalInfo.TabIndex = 1;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblNameTitle.Location = new System.Drawing.Point(15, 30);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(84, 20);
            this.lblNameTitle.TabIndex = 0;
            this.lblNameTitle.Text = "Full Name:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblApplicantName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblApplicantName.Location = new System.Drawing.Point(15, 48);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(370, 22);
            this.lblApplicantName.TabIndex = 1;
            this.lblApplicantName.Text = "—";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEmailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblEmailTitle.Location = new System.Drawing.Point(15, 80);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(51, 20);
            this.lblEmailTitle.TabIndex = 2;
            this.lblEmailTitle.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblEmail.Location = new System.Drawing.Point(15, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(370, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "—";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPhoneTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblPhoneTitle.Location = new System.Drawing.Point(15, 130);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(57, 20);
            this.lblPhoneTitle.TabIndex = 4;
            this.lblPhoneTitle.Text = "Phone:";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblPhone.Location = new System.Drawing.Point(15, 148);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(370, 22);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "—";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAddressTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblAddressTitle.Location = new System.Drawing.Point(15, 180);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(70, 20);
            this.lblAddressTitle.TabIndex = 6;
            this.lblAddressTitle.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblAddress.Location = new System.Drawing.Point(15, 198);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(370, 22);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "—";
            // 
            // lblSkillsTitle
            // 
            this.lblSkillsTitle.AutoSize = true;
            this.lblSkillsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSkillsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.lblSkillsTitle.Location = new System.Drawing.Point(15, 230);
            this.lblSkillsTitle.Name = "lblSkillsTitle";
            this.lblSkillsTitle.Size = new System.Drawing.Size(48, 20);
            this.lblSkillsTitle.TabIndex = 8;
            this.lblSkillsTitle.Text = "Skills:";
            // 
            // lblSkills
            // 
            this.lblSkills.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSkills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblSkills.Location = new System.Drawing.Point(15, 248);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(780, 42);
            this.lblSkills.TabIndex = 9;
            this.lblSkills.Text = "—";
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.Transparent;
            this.pnlEdit.Controls.Add(this.grpEdit);
            this.pnlEdit.Location = new System.Drawing.Point(20, 145);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(820, 490);
            this.pnlEdit.TabIndex = 4;
            this.pnlEdit.Visible = false;
            // 
            // grpEdit
            // 
            this.grpEdit.BackColor = System.Drawing.Color.White;
            this.grpEdit.Controls.Add(this.lblEditFirstName);
            this.grpEdit.Controls.Add(this.txtEditFirstName);
            this.grpEdit.Controls.Add(this.lblEditLastName);
            this.grpEdit.Controls.Add(this.txtEditLastName);
            this.grpEdit.Controls.Add(this.lblEditEmail);
            this.grpEdit.Controls.Add(this.txtEditEmail);
            this.grpEdit.Controls.Add(this.lblEditPhone);
            this.grpEdit.Controls.Add(this.txtEditPhone);
            this.grpEdit.Controls.Add(this.lblEditAddress);
            this.grpEdit.Controls.Add(this.txtEditAddress);
            this.grpEdit.Controls.Add(this.lblEditSkills);
            this.grpEdit.Controls.Add(this.txtEditSkills);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Controls.Add(this.btnCancelEdit);
            this.grpEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEdit.Location = new System.Drawing.Point(0, 0);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(820, 490);
            this.grpEdit.TabIndex = 0;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Edit Your Application Details";
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEditFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblEditFirstName.Location = new System.Drawing.Point(15, 30);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(97, 20);
            this.lblEditFirstName.TabIndex = 0;
            this.lblEditFirstName.Text = "First Name *";
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditFirstName.Location = new System.Drawing.Point(15, 50);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(340, 30);
            this.txtEditFirstName.TabIndex = 1;
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEditLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblEditLastName.Location = new System.Drawing.Point(375, 30);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(95, 20);
            this.lblEditLastName.TabIndex = 2;
            this.lblEditLastName.Text = "Last Name *";
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditLastName.Location = new System.Drawing.Point(375, 50);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(340, 30);
            this.txtEditLastName.TabIndex = 3;
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEditEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblEditEmail.Location = new System.Drawing.Point(15, 100);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(58, 20);
            this.lblEditEmail.TabIndex = 4;
            this.lblEditEmail.Text = "Email *";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditEmail.Location = new System.Drawing.Point(15, 120);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(340, 30);
            this.txtEditEmail.TabIndex = 5;
            // 
            // lblEditPhone
            // 
            this.lblEditPhone.AutoSize = true;
            this.lblEditPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEditPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblEditPhone.Location = new System.Drawing.Point(375, 100);
            this.lblEditPhone.Name = "lblEditPhone";
            this.lblEditPhone.Size = new System.Drawing.Size(53, 20);
            this.lblEditPhone.TabIndex = 6;
            this.lblEditPhone.Text = "Phone";
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditPhone.Location = new System.Drawing.Point(375, 120);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(340, 30);
            this.txtEditPhone.TabIndex = 7;
            // 
            // lblEditAddress
            // 
            this.lblEditAddress.AutoSize = true;
            this.lblEditAddress.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEditAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblEditAddress.Location = new System.Drawing.Point(15, 170);
            this.lblEditAddress.Name = "lblEditAddress";
            this.lblEditAddress.Size = new System.Drawing.Size(66, 20);
            this.lblEditAddress.TabIndex = 8;
            this.lblEditAddress.Text = "Address";
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditAddress.Location = new System.Drawing.Point(15, 190);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(700, 30);
            this.txtEditAddress.TabIndex = 9;
            // 
            // lblEditSkills
            // 
            this.lblEditSkills.AutoSize = true;
            this.lblEditSkills.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEditSkills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.lblEditSkills.Location = new System.Drawing.Point(15, 250);
            this.lblEditSkills.Name = "lblEditSkills";
            this.lblEditSkills.Size = new System.Drawing.Size(155, 20);
            this.lblEditSkills.TabIndex = 10;
            this.lblEditSkills.Text = "Skills / Qualifications";
            // 
            // txtEditSkills
            // 
            this.txtEditSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditSkills.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEditSkills.Location = new System.Drawing.Point(15, 270);
            this.txtEditSkills.Multiline = true;
            this.txtEditSkills.Name = "txtEditSkills";
            this.txtEditSkills.Size = new System.Drawing.Size(700, 65);
            this.txtEditSkills.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(530, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(700, 395);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(100, 38);
            this.btnCancelEdit.TabIndex = 13;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // FormApplicationPage
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(860, 680);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNoApplication);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(860, 680);
            this.Name = "FormApplicationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Application";
            this.Load += new System.EventHandler(this.MyApplicationPage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNav.ResumeLayout(false);
            this.pnlNoApplication.ResumeLayout(false);
            this.pnlNoApplication.PerformLayout();
            this.pnlView.ResumeLayout(false);
            this.grpApplicationInfo.ResumeLayout(false);
            this.grpApplicationInfo.PerformLayout();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnEditApplication;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlNoApplication;
        private System.Windows.Forms.Label lblNoAppIcon;
        private System.Windows.Forms.Label lblNoAppMsg;
        private System.Windows.Forms.Label lblNoAppSub;
        private System.Windows.Forms.Button btnBrowseJobs;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.GroupBox grpApplicationInfo;
        private System.Windows.Forms.Label lblJobAppliedTitle;
        private System.Windows.Forms.Label lblJobApplied;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDateAppliedTitle;
        private System.Windows.Forms.Label lblDateApplied;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddressTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSkillsTitle;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Label lblEditFirstName;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label lblEditPhone;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.Label lblEditAddress;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label lblEditSkills;
        private System.Windows.Forms.TextBox txtEditSkills;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}