// ============================================================
//  MyApplicationPage.Designer.cs
//  AUTO-GENERATED LAYOUT — Do not hand-edit control positions
//
//  NAMESPACE: Must match MyApplicationPage.cs
//  Change "MyApplicationPage" to your group's actual namespace.
// ============================================================

namespace MyApplicationPage   // <<< CHANGE THIS to match your group's namespace
{
    partial class Form1
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

            // ── Controls ─────────────────────────────────────────
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

            // ── SUSPEND LAYOUT ───────────────────────────────────
            this.SuspendLayout();

            // ════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════
            this.Text = "My Application";
            this.Size = new System.Drawing.Size(860, 680);
            this.MinimumSize = new System.Drawing.Size(860, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Load += new System.EventHandler(this.MyApplicationPage_Load);

            // ════════════════════════════════════════════════════
            //  HEADER PANEL
            // ════════════════════════════════════════════════════
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(860, 75);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 74, 153);

            this.lblPageTitle.Text = "My Application";
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.Location = new System.Drawing.Point(20, 10);
            this.lblPageTitle.AutoSize = true;

            this.lblPageSubtitle.Text = "View and manage your job application";
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblPageSubtitle.AutoSize = true;

            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblPageSubtitle);

            // ════════════════════════════════════════════════════
            //  NAV PANEL (top-right buttons)
            // ════════════════════════════════════════════════════
            this.pnlNav.Location = new System.Drawing.Point(0, 75);
            this.pnlNav.Size = new System.Drawing.Size(860, 55);
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(230, 236, 245);

            // VIEW STATUS
            this.btnViewStatus.Text = "📋 View Status";
            this.btnViewStatus.Location = new System.Drawing.Point(20, 12);
            this.btnViewStatus.Size = new System.Drawing.Size(140, 32);
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatus.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnViewStatus.ForeColor = System.Drawing.Color.White;
            this.btnViewStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewStatus.FlatAppearance.BorderSize = 0;
            this.btnViewStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);

            // EDIT APPLICATION
            this.btnEditApplication.Text = "✏️ Edit Application";
            this.btnEditApplication.Location = new System.Drawing.Point(170, 12);
            this.btnEditApplication.Size = new System.Drawing.Size(160, 32);
            this.btnEditApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditApplication.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnEditApplication.ForeColor = System.Drawing.Color.White;
            this.btnEditApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditApplication.FlatAppearance.BorderSize = 0;
            this.btnEditApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditApplication.Click += new System.EventHandler(this.btnEditApplication_Click);

            // BACK
            this.btnBack.Text = "← Back";
            this.btnBack.Location = new System.Drawing.Point(750, 12);
            this.btnBack.Size = new System.Drawing.Size(90, 32);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.pnlNav.Controls.Add(this.btnViewStatus);
            this.pnlNav.Controls.Add(this.btnEditApplication);
            this.pnlNav.Controls.Add(this.btnBack);

            // ════════════════════════════════════════════════════
            //  NO APPLICATION PANEL
            //  Shown when applicant has never applied for a job yet
            // ════════════════════════════════════════════════════
            this.pnlNoApplication.Location = new System.Drawing.Point(20, 145);
            this.pnlNoApplication.Size = new System.Drawing.Size(820, 460);
            this.pnlNoApplication.BackColor = System.Drawing.Color.White;
            this.pnlNoApplication.Visible = false;

            this.lblNoAppIcon.Text = "📄";
            this.lblNoAppIcon.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.lblNoAppIcon.Location = new System.Drawing.Point(340, 80);
            this.lblNoAppIcon.AutoSize = true;

            this.lblNoAppMsg.Text = "No Application Yet";
            this.lblNoAppMsg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNoAppMsg.ForeColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.lblNoAppMsg.Location = new System.Drawing.Point(270, 170);
            this.lblNoAppMsg.AutoSize = true;

            this.lblNoAppSub.Text = "You haven't applied for any job yet.\nBrowse open positions and submit your application.";
            this.lblNoAppSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNoAppSub.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblNoAppSub.Location = new System.Drawing.Point(220, 210);
            this.lblNoAppSub.Size = new System.Drawing.Size(380, 45);
            this.lblNoAppSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnBrowseJobs.Text = "Browse Open Jobs";
            this.btnBrowseJobs.Location = new System.Drawing.Point(310, 275);
            this.btnBrowseJobs.Size = new System.Drawing.Size(200, 40);
            this.btnBrowseJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseJobs.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnBrowseJobs.ForeColor = System.Drawing.Color.White;
            this.btnBrowseJobs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBrowseJobs.FlatAppearance.BorderSize = 0;
            this.btnBrowseJobs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseJobs.Click += new System.EventHandler(this.btnBrowseJobs_Click);

            this.pnlNoApplication.Controls.Add(this.lblNoAppIcon);
            this.pnlNoApplication.Controls.Add(this.lblNoAppMsg);
            this.pnlNoApplication.Controls.Add(this.lblNoAppSub);
            this.pnlNoApplication.Controls.Add(this.btnBrowseJobs);

            // ════════════════════════════════════════════════════
            //  VIEW PANEL (shows application details read-only)
            // ════════════════════════════════════════════════════
            this.pnlView.Location = new System.Drawing.Point(20, 145);
            this.pnlView.Size = new System.Drawing.Size(820, 490);
            this.pnlView.BackColor = System.Drawing.Color.Transparent;
            this.pnlView.Visible = false;

            // ── Application Info GroupBox ──────────────────────
            this.grpApplicationInfo.Text = "Application Info";
            this.grpApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.grpApplicationInfo.Size = new System.Drawing.Size(820, 160);
            this.grpApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpApplicationInfo.BackColor = System.Drawing.Color.White;

            // Job Applied
            this.lblJobAppliedTitle.Text = "Position Applied:";
            this.lblJobAppliedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJobAppliedTitle.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblJobAppliedTitle.Location = new System.Drawing.Point(15, 30);
            this.lblJobAppliedTitle.AutoSize = true;

            this.lblJobApplied.Text = "—";
            this.lblJobApplied.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblJobApplied.ForeColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.lblJobApplied.Location = new System.Drawing.Point(15, 50);
            this.lblJobApplied.AutoSize = true;

            // Status
            this.lblStatusTitle.Text = "Status:";
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblStatusTitle.Location = new System.Drawing.Point(15, 85);
            this.lblStatusTitle.AutoSize = true;

            this.lblStatus.Text = "—";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(15, 105);
            this.lblStatus.Size = new System.Drawing.Size(160, 24);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);

            // Date Applied
            this.lblDateAppliedTitle.Text = "Date Applied:";
            this.lblDateAppliedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateAppliedTitle.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblDateAppliedTitle.Location = new System.Drawing.Point(220, 85);
            this.lblDateAppliedTitle.AutoSize = true;

            this.lblDateApplied.Text = "—";
            this.lblDateApplied.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateApplied.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80);
            this.lblDateApplied.Location = new System.Drawing.Point(220, 107);
            this.lblDateApplied.AutoSize = true;

            // Submit button (only visible when status = Draft)
            this.btnSubmit.Text = "🚀 Submit Application";
            this.btnSubmit.Location = new System.Drawing.Point(610, 95);
            this.btnSubmit.Size = new System.Drawing.Size(190, 38);
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.grpApplicationInfo.Controls.Add(this.lblJobAppliedTitle);
            this.grpApplicationInfo.Controls.Add(this.lblJobApplied);
            this.grpApplicationInfo.Controls.Add(this.lblStatusTitle);
            this.grpApplicationInfo.Controls.Add(this.lblStatus);
            this.grpApplicationInfo.Controls.Add(this.lblDateAppliedTitle);
            this.grpApplicationInfo.Controls.Add(this.lblDateApplied);
            this.grpApplicationInfo.Controls.Add(this.btnSubmit);

            // ── Personal Info GroupBox ──────────────────────────
            this.grpPersonalInfo.Text = "Personal Information";
            this.grpPersonalInfo.Location = new System.Drawing.Point(0, 170);
            this.grpPersonalInfo.Size = new System.Drawing.Size(820, 300);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPersonalInfo.BackColor = System.Drawing.Color.White;

            void AddField(string titleText, System.Windows.Forms.Label titleLbl,
                          string valueText, System.Windows.Forms.Label valueLbl,
                          int x, int y)
            {
                titleLbl.Text = titleText;
                titleLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
                titleLbl.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
                titleLbl.Location = new System.Drawing.Point(x, y);
                titleLbl.AutoSize = true;

                valueLbl.Text = valueText;
                valueLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
                valueLbl.ForeColor = System.Drawing.Color.FromArgb(30, 40, 60);
                valueLbl.Location = new System.Drawing.Point(x, y + 18);
                valueLbl.Size = new System.Drawing.Size(370, 22);
            }

            AddField("Full Name:", this.lblNameTitle, "—", this.lblApplicantName, 15, 30);
            AddField("Email:", this.lblEmailTitle, "—", this.lblEmail, 15, 80);
            AddField("Phone:", this.lblPhoneTitle, "—", this.lblPhone, 15, 130);
            AddField("Address:", this.lblAddressTitle, "—", this.lblAddress, 15, 180);
            AddField("Skills:", this.lblSkillsTitle, "—", this.lblSkills, 15, 230);
            this.lblSkills.Size = new System.Drawing.Size(780, 42);

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

            this.pnlView.Controls.Add(this.grpApplicationInfo);
            this.pnlView.Controls.Add(this.grpPersonalInfo);

            // ════════════════════════════════════════════════════
            //  EDIT PANEL
            // ════════════════════════════════════════════════════
            this.pnlEdit.Location = new System.Drawing.Point(20, 145);
            this.pnlEdit.Size = new System.Drawing.Size(820, 490);
            this.pnlEdit.BackColor = System.Drawing.Color.Transparent;
            this.pnlEdit.Visible = false;

            this.grpEdit.Text = "Edit Your Application Details";
            this.grpEdit.Location = new System.Drawing.Point(0, 0);
            this.grpEdit.Size = new System.Drawing.Size(820, 490);
            this.grpEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpEdit.BackColor = System.Drawing.Color.White;

            void AddEditField(System.Windows.Forms.Label lbl, string labelText,
                              System.Windows.Forms.TextBox txt,
                              int x, int y, int width = 340, bool multiline = false)
            {
                lbl.Text = labelText;
                lbl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
                lbl.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110);
                lbl.Location = new System.Drawing.Point(x, y);
                lbl.AutoSize = true;

                txt.Location = new System.Drawing.Point(x, y + 20);
                txt.Size = new System.Drawing.Size(width, multiline ? 65 : 28);
                txt.Font = new System.Drawing.Font("Segoe UI", 10F);
                txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                txt.Multiline = multiline;
            }

            AddEditField(this.lblEditFirstName, "First Name *", this.txtEditFirstName, 15, 30);
            AddEditField(this.lblEditLastName, "Last Name *", this.txtEditLastName, 375, 30);
            AddEditField(this.lblEditEmail, "Email *", this.txtEditEmail, 15, 100);
            AddEditField(this.lblEditPhone, "Phone", this.txtEditPhone, 375, 100);
            AddEditField(this.lblEditAddress, "Address", this.txtEditAddress, 15, 170, 700);
            AddEditField(this.lblEditSkills, "Skills / Qualifications",
                                                this.txtEditSkills, 15, 250, 700, true);

            // SAVE
            this.btnSave.Text = "💾 Save Changes";
            this.btnSave.Location = new System.Drawing.Point(530, 395);
            this.btnSave.Size = new System.Drawing.Size(160, 38);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // CANCEL
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.Location = new System.Drawing.Point(700, 395);
            this.btnCancelEdit.Size = new System.Drawing.Size(100, 38);
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);

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

            this.pnlEdit.Controls.Add(this.grpEdit);

            // ════════════════════════════════════════════════════
            //  ADD ALL TO FORM
            // ════════════════════════════════════════════════════
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlNoApplication);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlEdit);

            this.ResumeLayout(false);
        }

        // ── Control Declarations ──────────────────────────────
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