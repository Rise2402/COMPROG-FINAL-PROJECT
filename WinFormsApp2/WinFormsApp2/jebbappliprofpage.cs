using System;
using System.Windows.Forms;

namespace jebb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            string profileInfo =
                "First Name: " + txtFirstName.Text +
                "\nMiddle Name: " + txtMiddleName.Text +
                "\nLast Name: " + txtLastName.Text +
                "\nBirth Date: " + dtpBirthDate.Value.ToShortDateString() +
                "\nGender: " + cmbGender.Text +
                "\nCivil Status: " + cmbCivilStatus.Text +
                "\nEmail: " + txtEmail.Text +
                "\nContact: " + txtContact.Text +
                "\nStreet: " + txtStreet.Text +
                "\nBarangay: " + txtBarangay.Text +
                "\nCity: " + txtCity.Text +
                "\nProvince: " + txtProvince.Text +
                "\nZIP Code: " + txtZipCode.Text +
                "\nSchool: " + txtSchool.Text +
                "\nCourse: " + txtCourse.Text +
                "\nYear Graduated: " + txtYearGraduated.Text +
                "\nSkills: " + txtSkills.Text +
                "\nCompany: " + txtCompany.Text +
                "\nPosition: " + txtPosition.Text +
                "\nYears Worked: " + txtYearsWorked.Text +
                "\nJob Description: " + txtDescription.Text;

            MessageBox.Show(profileInfo, "Profile Saved");
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Name = "Form1";
            ResumeLayout(false);

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile Updated!");
        }
    }
}