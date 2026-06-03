
using System;
using System.ComponentModel;
using System.Drawing;    
using System.Windows.Forms;


namespace jebb
{
    partial class Form1
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblCivilStatus = new Label();
            cmbCivilStatus = new ComboBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblSkillsHeader = new Label();
            txtSkills = new TextBox();
            btnSaveProfile = new Button();
            btnUpdateProfile = new Button();
            lblAddressHeader = new Label();
            lblStreet = new Label();
            lblBarangay = new Label();
            lblCity = new Label();
            lblProvince = new Label();
            lblZipCode = new Label();
            txtStreet = new TextBox();
            txtBarangay = new TextBox();
            txtCity = new TextBox();
            txtProvince = new TextBox();
            txtZipCode = new TextBox();
            lblEducationHeader = new Label();
            lblSchool = new Label();
            lblCourse = new Label();
            lblYearGraduated = new Label();
            txtSchool = new TextBox();
            txtCourse = new TextBox();
            txtYearGraduated = new TextBox();
            lblWorkHeader = new Label();
            lblCompany = new Label();
            lblPosition = new Label();
            lblYearsWorked = new Label();
            lblDescription = new Label();
            txtCompany = new TextBox();
            txtPosition = new TextBox();
            txtYearsWorked = new TextBox();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(250, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(263, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "APPLICANT PROFILE";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(30, 100);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(150, 97);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 2;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(30, 140);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(82, 15);
            lblMiddleName.TabIndex = 3;
            lblMiddleName.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(150, 137);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(200, 23);
            txtMiddleName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(30, 180);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(150, 177);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(30, 220);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(62, 15);
            lblBirthDate.TabIndex = 7;
            lblBirthDate.Text = "Birth Date:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(150, 217);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 8;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(30, 260);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 9;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(150, 257);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(200, 23);
            cmbGender.TabIndex = 10;
            // 
            // lblCivilStatus
            // 
            lblCivilStatus.AutoSize = true;
            lblCivilStatus.Location = new Point(30, 300);
            lblCivilStatus.Name = "lblCivilStatus";
            lblCivilStatus.Size = new Size(68, 15);
            lblCivilStatus.TabIndex = 11;
            lblCivilStatus.Text = "Civil Status:";
            // 
            // cmbCivilStatus
            // 
            cmbCivilStatus.Items.AddRange(new object[] { "Single", "Married", "Widowed", "Separated" });
            cmbCivilStatus.Location = new Point(150, 297);
            cmbCivilStatus.Name = "cmbCivilStatus";
            cmbCivilStatus.Size = new Size(200, 23);
            cmbCivilStatus.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 340);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 337);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 14;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(30, 380);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(99, 15);
            lblContact.TabIndex = 15;
            lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(150, 377);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(250, 23);
            txtContact.TabIndex = 16;
            // 
            // lblSkillsHeader
            // 
            lblSkillsHeader.AutoSize = true;
            lblSkillsHeader.BackColor = Color.WhiteSmoke;
            lblSkillsHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSkillsHeader.ForeColor = Color.Navy;
            lblSkillsHeader.Location = new Point(30, 860);
            lblSkillsHeader.Name = "lblSkillsHeader";
            lblSkillsHeader.Size = new Size(52, 19);
            lblSkillsHeader.TabIndex = 35;
            lblSkillsHeader.Text = "SKILLS";
            // 
            // txtSkills
            // 
            txtSkills.Location = new Point(30, 900);
            txtSkills.Multiline = true;
            txtSkills.Name = "txtSkills";
            txtSkills.Size = new Size(370, 80);
            txtSkills.TabIndex = 36;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.BackColor = Color.Navy;
            btnSaveProfile.ForeColor = Color.White;
            btnSaveProfile.Location = new Point(150, 1280);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(120, 35);
            btnSaveProfile.TabIndex = 46;
            btnSaveProfile.Text = "Save Profile";
            btnSaveProfile.UseVisualStyleBackColor = false;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.BackColor = Color.White;
            btnUpdateProfile.ForeColor = Color.Navy;
            btnUpdateProfile.Location = new Point(290, 1280);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(120, 35);
            btnUpdateProfile.TabIndex = 47;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = false;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // lblAddressHeader
            // 
            lblAddressHeader.AutoSize = true;
            lblAddressHeader.BackColor = Color.WhiteSmoke;
            lblAddressHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddressHeader.ForeColor = Color.Navy;
            lblAddressHeader.Location = new Point(30, 430);
            lblAddressHeader.Name = "lblAddressHeader";
            lblAddressHeader.Size = new Size(173, 19);
            lblAddressHeader.TabIndex = 17;
            lblAddressHeader.Text = "ADDRESS INFORMATION";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(30, 470);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(101, 15);
            lblStreet.TabIndex = 18;
            lblStreet.Text = "House No./Street:";
            // 
            // lblBarangay
            // 
            lblBarangay.AutoSize = true;
            lblBarangay.Location = new Point(30, 510);
            lblBarangay.Name = "lblBarangay";
            lblBarangay.Size = new Size(59, 15);
            lblBarangay.TabIndex = 20;
            lblBarangay.Text = "Barangay:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(30, 550);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(102, 15);
            lblCity.TabIndex = 22;
            lblCity.Text = "City/Municipality:";
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Location = new Point(30, 590);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(56, 15);
            lblProvince.TabIndex = 24;
            lblProvince.Text = "Province:";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(30, 630);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(58, 15);
            lblZipCode.TabIndex = 26;
            lblZipCode.Text = "ZIP Code:";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(150, 467);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(250, 23);
            txtStreet.TabIndex = 19;
            // 
            // txtBarangay
            // 
            txtBarangay.Location = new Point(150, 507);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.Size = new Size(250, 23);
            txtBarangay.TabIndex = 21;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(150, 547);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(250, 23);
            txtCity.TabIndex = 23;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(150, 587);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(250, 23);
            txtProvince.TabIndex = 25;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(150, 627);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(120, 23);
            txtZipCode.TabIndex = 27;
            // 
            // lblEducationHeader
            // 
            lblEducationHeader.AutoSize = true;
            lblEducationHeader.BackColor = Color.WhiteSmoke;
            lblEducationHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEducationHeader.ForeColor = Color.Navy;
            lblEducationHeader.Location = new Point(30, 690);
            lblEducationHeader.Name = "lblEducationHeader";
            lblEducationHeader.Size = new Size(207, 19);
            lblEducationHeader.TabIndex = 28;
            lblEducationHeader.Text = "EDUCATIONAL BACKGROUND";
            // 
            // lblSchool
            // 
            lblSchool.AutoSize = true;
            lblSchool.Location = new Point(30, 730);
            lblSchool.Name = "lblSchool";
            lblSchool.Size = new Size(81, 15);
            lblSchool.TabIndex = 29;
            lblSchool.Text = "School Name:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(30, 770);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(89, 15);
            lblCourse.TabIndex = 31;
            lblCourse.Text = "Course/Degree:";
            // 
            // lblYearGraduated
            // 
            lblYearGraduated.AutoSize = true;
            lblYearGraduated.Location = new Point(30, 810);
            lblYearGraduated.Name = "lblYearGraduated";
            lblYearGraduated.Size = new Size(90, 15);
            lblYearGraduated.TabIndex = 33;
            lblYearGraduated.Text = "Year Graduated:";
            // 
            // txtSchool
            // 
            txtSchool.Location = new Point(150, 727);
            txtSchool.Name = "txtSchool";
            txtSchool.Size = new Size(250, 23);
            txtSchool.TabIndex = 30;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(150, 767);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(250, 23);
            txtCourse.TabIndex = 32;
            // 
            // txtYearGraduated
            // 
            txtYearGraduated.Location = new Point(150, 807);
            txtYearGraduated.Name = "txtYearGraduated";
            txtYearGraduated.Size = new Size(120, 23);
            txtYearGraduated.TabIndex = 34;
            // 
            // lblWorkHeader
            // 
            lblWorkHeader.AutoSize = true;
            lblWorkHeader.BackColor = Color.WhiteSmoke;
            lblWorkHeader.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWorkHeader.ForeColor = Color.Navy;
            lblWorkHeader.Location = new Point(30, 1010);
            lblWorkHeader.Name = "lblWorkHeader";
            lblWorkHeader.Size = new Size(135, 19);
            lblWorkHeader.TabIndex = 37;
            lblWorkHeader.Text = "WORK EXPERIENCE";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(30, 1050);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(62, 15);
            lblCompany.TabIndex = 38;
            lblCompany.Text = "Company:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(30, 1090);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(53, 15);
            lblPosition.TabIndex = 40;
            lblPosition.Text = "Position:";
            // 
            // lblYearsWorked
            // 
            lblYearsWorked.AutoSize = true;
            lblYearsWorked.Location = new Point(30, 1130);
            lblYearsWorked.Name = "lblYearsWorked";
            lblYearsWorked.Size = new Size(81, 15);
            lblYearsWorked.TabIndex = 42;
            lblYearsWorked.Text = "Years Worked:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 1170);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(91, 15);
            lblDescription.TabIndex = 44;
            lblDescription.Text = "Job Description:";
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(150, 1047);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(250, 23);
            txtCompany.TabIndex = 39;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(150, 1087);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(250, 23);
            txtPosition.TabIndex = 41;
            // 
            // txtYearsWorked
            // 
            txtYearsWorked.Location = new Point(150, 1127);
            txtYearsWorked.Name = "txtYearsWorked";
            txtYearsWorked.Size = new Size(120, 23);
            txtYearsWorked.TabIndex = 43;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(150, 1167);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 80);
            txtDescription.TabIndex = 45;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(917, 1061);
            Controls.Add(lblTitle);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtMiddleName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblBirthDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(lblCivilStatus);
            Controls.Add(cmbCivilStatus);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblContact);
            Controls.Add(txtContact);
            Controls.Add(lblAddressHeader);
            Controls.Add(lblStreet);
            Controls.Add(txtStreet);
            Controls.Add(lblBarangay);
            Controls.Add(txtBarangay);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblProvince);
            Controls.Add(txtProvince);
            Controls.Add(lblZipCode);
            Controls.Add(txtZipCode);
            Controls.Add(lblEducationHeader);
            Controls.Add(lblSchool);
            Controls.Add(txtSchool);
            Controls.Add(lblCourse);
            Controls.Add(txtCourse);
            Controls.Add(lblYearGraduated);
            Controls.Add(txtYearGraduated);
            Controls.Add(lblSkillsHeader);
            Controls.Add(txtSkills);
            Controls.Add(lblWorkHeader);
            Controls.Add(lblCompany);
            Controls.Add(txtCompany);
            Controls.Add(lblPosition);
            Controls.Add(txtPosition);
            Controls.Add(lblYearsWorked);
            Controls.Add(txtYearsWorked);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnSaveProfile);
            Controls.Add(btnUpdateProfile);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applicant Profile";
            ResumeLayout(false);
            PerformLayout();
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
