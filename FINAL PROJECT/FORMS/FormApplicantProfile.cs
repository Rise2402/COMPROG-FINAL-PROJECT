using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormApplicantProfile : Form
    {
        public FormApplicantProfile()
        {
            InitializeComponent();
        }

        private void FormApplicantProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT * FROM Applicants 
                        WHERE ApplicantAccountID = @AccountID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccountID", Session.ApplicantAccountID);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["FirstName"].ToString();
                        txtMiddleName.Text = reader["MiddleName"].ToString();
                        txtLastName.Text = reader["LastName"].ToString();

                        if (reader["BirthDate"] != DBNull.Value)
                            dtpBirthDate.Value = Convert.ToDateTime(reader["BirthDate"]);

                        cmbGender.Text = reader["Gender"].ToString();
                        txtContact.Text = reader["ContactNumber"].ToString();
                        txtStreet.Text = reader["AddressLine"].ToString();
                        txtCity.Text = reader["City"].ToString();
                        txtProvince.Text = reader["Province"].ToString();

                        // Parse Education
                        string education = reader["Education"].ToString();
                        var eduParts = education.Split('|');
                        foreach (var part in eduParts)
                        {
                            if (part.Contains("School:")) txtSchool.Text = part.Replace("School:", "").Trim();
                            if (part.Contains("Course:")) txtCourse.Text = part.Replace("Course:", "").Trim();
                            if (part.Contains("Year Graduated:")) txtYearGraduated.Text = part.Replace("Year Graduated:", "").Trim();
                        }

                        // Skills
                        txtSkills.Text = reader["Skills"].ToString();

                        // Parse WorkExperience
                        string workExp = reader["WorkExperience"].ToString();
                        var workParts = workExp.Split('|');
                        foreach (var part in workParts)
                        {
                            if (part.Contains("Company:")) txtCompany.Text = part.Replace("Company:", "").Trim();
                            if (part.Contains("Position:")) txtPosition.Text = part.Replace("Position:", "").Trim();
                            if (part.Contains("Years Worked:")) txtYearsWorked.Text = part.Replace("Years Worked:", "").Trim();
                            if (part.Contains("Description:")) txtDescription.Text = part.Replace("Description:", "").Trim();
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Check if profile already exists
                    string checkQuery = "SELECT COUNT(*) FROM Applicants WHERE ApplicantAccountID = @AccountID";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@AccountID", Session.ApplicantAccountID);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Profile already exists. Use Update instead.");
                        return;
                    }

                    string query = @"
                        INSERT INTO Applicants 
                        (ApplicantAccountID, FirstName, MiddleName, LastName,
                         BirthDate, Gender, ContactNumber, AddressLine, City, Province,
                         Education, Skills, WorkExperience)
                        VALUES
                        (@AccountID, @FirstName, @MiddleName, @LastName,
                         @BirthDate, @Gender, @Contact, @Address, @City, @Province,
                         @Education, @Skills, @WorkExperience)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccountID", Session.ApplicantAccountID);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtStreet.Text.Trim());
                    cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                    cmd.Parameters.AddWithValue("@Province", txtProvince.Text.Trim());
                    cmd.Parameters.AddWithValue("@Education",
                        $"School: {txtSchool.Text.Trim()} | Course: {txtCourse.Text.Trim()} | Year Graduated: {txtYearGraduated.Text.Trim()}");
                    cmd.Parameters.AddWithValue("@Skills", txtSkills.Text.Trim());
                    cmd.Parameters.AddWithValue("@WorkExperience",
                        $"Company: {txtCompany.Text.Trim()} | Position: {txtPosition.Text.Trim()} | Years Worked: {txtYearsWorked.Text.Trim()} | Description: {txtDescription.Text.Trim()}");

                    cmd.ExecuteNonQuery();

                    // Update Session
                    string getID = "SELECT ApplicantID FROM Applicants WHERE ApplicantAccountID = @AccountID";
                    MySqlCommand getCmd = new MySqlCommand(getID, conn);
                    getCmd.Parameters.AddWithValue("@AccountID", Session.ApplicantAccountID);
                    Session.ApplicantID = Convert.ToInt32(getCmd.ExecuteScalar());
                    Session.FullName = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();

                    MessageBox.Show("Profile saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile: " + ex.Message);
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE Applicants SET
                            FirstName = @FirstName,
                            MiddleName = @MiddleName,
                            LastName = @LastName,
                            BirthDate = @BirthDate,
                            Gender = @Gender,
                            ContactNumber = @Contact,
                            AddressLine = @Address,
                            City = @City,
                            Province = @Province,
                            Education = @Education,
                            Skills = @Skills,
                            WorkExperience = @WorkExperience
                        WHERE ApplicantAccountID = @AccountID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AccountID", Session.ApplicantAccountID);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtStreet.Text.Trim());
                    cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                    cmd.Parameters.AddWithValue("@Province", txtProvince.Text.Trim());
                    cmd.Parameters.AddWithValue("@Education",
                        $"School: {txtSchool.Text.Trim()} | Course: {txtCourse.Text.Trim()} | Year Graduated: {txtYearGraduated.Text.Trim()}");
                    cmd.Parameters.AddWithValue("@Skills", txtSkills.Text.Trim());
                    cmd.Parameters.AddWithValue("@WorkExperience",
                        $"Company: {txtCompany.Text.Trim()} | Position: {txtPosition.Text.Trim()} | Years Worked: {txtYearsWorked.Text.Trim()} | Description: {txtDescription.Text.Trim()}");

                    cmd.ExecuteNonQuery();

                    // Update session name
                    Session.FullName = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();

                    MessageBox.Show("Profile updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnSaveProfile_Click_1(object sender, EventArgs e)
        {
            btnSaveProfile_Click(sender, e); 
        }

        private void btnUpdateProfile_Click_1(object sender, EventArgs e)
        {
            btnUpdateProfile_Click(sender, e);
        }
    }
}