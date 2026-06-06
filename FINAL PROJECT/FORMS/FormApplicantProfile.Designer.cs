
using System;
using System.ComponentModel;
using System.Drawing;    
using System.Windows.Forms;


namespace FINAL_PROJECT.FORMS
{
    partial class FormApplicantProfile
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblCivilStatus = new System.Windows.Forms.Label();
            this.cmbCivilStatus = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblSkillsHeader = new System.Windows.Forms.Label();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.lblAddressHeader = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblBarangay = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtBarangay = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblEducationHeader = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblYearGraduated = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtYearGraduated = new System.Windows.Forms.TextBox();
            this.lblWorkHeader = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblYearsWorked = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtYearsWorked = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(286, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "APPLICANT PROFILE";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(34, 107);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(171, 103);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(228, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(34, 149);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(91, 16);
            this.lblMiddleName.TabIndex = 3;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(171, 146);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(228, 22);
            this.txtMiddleName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(34, 192);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 16);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(171, 189);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(228, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(34, 235);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(68, 16);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(171, 231);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(228, 22);
            this.dtpBirthDate.TabIndex = 8;
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(34, 277);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 16);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(171, 274);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(228, 24);
            this.cmbGender.TabIndex = 10;
            // 
            // lblCivilStatus
            // 
            this.lblCivilStatus.AutoSize = true;
            this.lblCivilStatus.Location = new System.Drawing.Point(34, 320);
            this.lblCivilStatus.Name = "lblCivilStatus";
            this.lblCivilStatus.Size = new System.Drawing.Size(75, 16);
            this.lblCivilStatus.TabIndex = 11;
            this.lblCivilStatus.Text = "Civil Status:";
            // 
            // cmbCivilStatus
            // 
            this.cmbCivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Separated"});
            this.cmbCivilStatus.Location = new System.Drawing.Point(171, 317);
            this.cmbCivilStatus.Name = "cmbCivilStatus";
            this.cmbCivilStatus.Size = new System.Drawing.Size(228, 24);
            this.cmbCivilStatus.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 363);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 359);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(34, 405);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(106, 16);
            this.lblContact.TabIndex = 15;
            this.lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(171, 402);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(285, 22);
            this.txtContact.TabIndex = 16;
            // 
            // lblSkillsHeader
            // 
            this.lblSkillsHeader.AutoSize = true;
            this.lblSkillsHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSkillsHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSkillsHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblSkillsHeader.Location = new System.Drawing.Point(34, 917);
            this.lblSkillsHeader.Name = "lblSkillsHeader";
            this.lblSkillsHeader.Size = new System.Drawing.Size(64, 23);
            this.lblSkillsHeader.TabIndex = 35;
            this.lblSkillsHeader.Text = "SKILLS";
            // 
            // txtSkills
            // 
            this.txtSkills.Location = new System.Drawing.Point(34, 960);
            this.txtSkills.Multiline = true;
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.Size = new System.Drawing.Size(422, 85);
            this.txtSkills.TabIndex = 36;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.Navy;
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(171, 1365);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(137, 37);
            this.btnSaveProfile.TabIndex = 46;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click_1);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.White;
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateProfile.Location = new System.Drawing.Point(331, 1365);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(137, 37);
            this.btnUpdateProfile.TabIndex = 47;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click_1);
            // 
            // lblAddressHeader
            // 
            this.lblAddressHeader.AutoSize = true;
            this.lblAddressHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddressHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddressHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblAddressHeader.Location = new System.Drawing.Point(34, 459);
            this.lblAddressHeader.Name = "lblAddressHeader";
            this.lblAddressHeader.Size = new System.Drawing.Size(212, 23);
            this.lblAddressHeader.TabIndex = 17;
            this.lblAddressHeader.Text = "ADDRESS INFORMATION";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(34, 501);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(113, 16);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "House No./Street:";
            // 
            // lblBarangay
            // 
            this.lblBarangay.AutoSize = true;
            this.lblBarangay.Location = new System.Drawing.Point(34, 544);
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Size = new System.Drawing.Size(69, 16);
            this.lblBarangay.TabIndex = 20;
            this.lblBarangay.Text = "Barangay:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(34, 587);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(106, 16);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "City/Municipality:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(34, 629);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(63, 16);
            this.lblProvince.TabIndex = 24;
            this.lblProvince.Text = "Province:";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(34, 672);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(66, 16);
            this.lblZipCode.TabIndex = 26;
            this.lblZipCode.Text = "ZIP Code:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(171, 498);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(285, 22);
            this.txtStreet.TabIndex = 19;
            // 
            // txtBarangay
            // 
            this.txtBarangay.Location = new System.Drawing.Point(171, 541);
            this.txtBarangay.Name = "txtBarangay";
            this.txtBarangay.Size = new System.Drawing.Size(285, 22);
            this.txtBarangay.TabIndex = 21;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(171, 583);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(285, 22);
            this.txtCity.TabIndex = 23;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(171, 626);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(285, 22);
            this.txtProvince.TabIndex = 25;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(171, 669);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(137, 22);
            this.txtZipCode.TabIndex = 27;
            // 
            // lblEducationHeader
            // 
            this.lblEducationHeader.AutoSize = true;
            this.lblEducationHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEducationHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEducationHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblEducationHeader.Location = new System.Drawing.Point(34, 736);
            this.lblEducationHeader.Name = "lblEducationHeader";
            this.lblEducationHeader.Size = new System.Drawing.Size(252, 23);
            this.lblEducationHeader.TabIndex = 28;
            this.lblEducationHeader.Text = "EDUCATIONAL BACKGROUND";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(34, 779);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(92, 16);
            this.lblSchool.TabIndex = 29;
            this.lblSchool.Text = "School Name:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(34, 821);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(103, 16);
            this.lblCourse.TabIndex = 31;
            this.lblCourse.Text = "Course/Degree:";
            // 
            // lblYearGraduated
            // 
            this.lblYearGraduated.AutoSize = true;
            this.lblYearGraduated.Location = new System.Drawing.Point(34, 864);
            this.lblYearGraduated.Name = "lblYearGraduated";
            this.lblYearGraduated.Size = new System.Drawing.Size(106, 16);
            this.lblYearGraduated.TabIndex = 33;
            this.lblYearGraduated.Text = "Year Graduated:";
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(171, 775);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(285, 22);
            this.txtSchool.TabIndex = 30;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(171, 818);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(285, 22);
            this.txtCourse.TabIndex = 32;
            // 
            // txtYearGraduated
            // 
            this.txtYearGraduated.Location = new System.Drawing.Point(171, 861);
            this.txtYearGraduated.Name = "txtYearGraduated";
            this.txtYearGraduated.Size = new System.Drawing.Size(137, 22);
            this.txtYearGraduated.TabIndex = 34;
            // 
            // lblWorkHeader
            // 
            this.lblWorkHeader.AutoSize = true;
            this.lblWorkHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblWorkHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWorkHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblWorkHeader.Location = new System.Drawing.Point(34, 1077);
            this.lblWorkHeader.Name = "lblWorkHeader";
            this.lblWorkHeader.Size = new System.Drawing.Size(164, 23);
            this.lblWorkHeader.TabIndex = 37;
            this.lblWorkHeader.Text = "WORK EXPERIENCE";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(34, 1120);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(68, 16);
            this.lblCompany.TabIndex = 38;
            this.lblCompany.Text = "Company:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(34, 1163);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 16);
            this.lblPosition.TabIndex = 40;
            this.lblPosition.Text = "Position:";
            // 
            // lblYearsWorked
            // 
            this.lblYearsWorked.AutoSize = true;
            this.lblYearsWorked.Location = new System.Drawing.Point(34, 1205);
            this.lblYearsWorked.Name = "lblYearsWorked";
            this.lblYearsWorked.Size = new System.Drawing.Size(97, 16);
            this.lblYearsWorked.TabIndex = 42;
            this.lblYearsWorked.Text = "Years Worked:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(34, 1248);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 16);
            this.lblDescription.TabIndex = 44;
            this.lblDescription.Text = "Job Description:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(171, 1117);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(285, 22);
            this.txtCompany.TabIndex = 39;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(171, 1159);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(285, 22);
            this.txtPosition.TabIndex = 41;
            // 
            // txtYearsWorked
            // 
            this.txtYearsWorked.Location = new System.Drawing.Point(171, 1202);
            this.txtYearsWorked.Name = "txtYearsWorked";
            this.txtYearsWorked.Size = new System.Drawing.Size(137, 22);
            this.txtYearsWorked.TabIndex = 43;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(171, 1245);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(342, 85);
            this.txtDescription.TabIndex = 45;
            // 
            // FormApplicantProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1069, 1055);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblCivilStatus);
            this.Controls.Add(this.cmbCivilStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblAddressHeader);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblBarangay);
            this.Controls.Add(this.txtBarangay);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblEducationHeader);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblYearGraduated);
            this.Controls.Add(this.txtYearGraduated);
            this.Controls.Add(this.lblSkillsHeader);
            this.Controls.Add(this.txtSkills);
            this.Controls.Add(this.lblWorkHeader);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblYearsWorked);
            this.Controls.Add(this.txtYearsWorked);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.btnUpdateProfile);
            this.Name = "FormApplicantProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Profile";
            this.Load += new System.EventHandler(this.FormApplicantProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;

        // Address
        private System.Windows.Forms.Label lblAddressHeader;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblBarangay;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblZipCode;

        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtBarangay;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCivilStatus;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;

        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbCivilStatus;

        // Education
        private System.Windows.Forms.Label lblEducationHeader;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblYearGraduated;

        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtYearGraduated;

        // Skills
        private System.Windows.Forms.Label lblSkillsHeader;
        private System.Windows.Forms.TextBox txtSkills;

        // Work Experience
        private System.Windows.Forms.Label lblWorkHeader;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblYearsWorked;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtYearsWorked;
        private System.Windows.Forms.TextBox txtDescription;

        // Buttons
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnUpdateProfile;
        #endregion

    }
}
