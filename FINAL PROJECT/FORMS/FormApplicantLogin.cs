using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT.FORMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Check HR Users (Admin, HR Staff, HR Manager)
                    string hrQuery = @"
    SELECT UserID, RoleID, FullName
    FROM Users
    WHERE Email = @Email
    AND PasswordHash = @Password
    AND IsActive = TRUE";

                    MySqlCommand cmd = new MySqlCommand(hrQuery, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int userID = Convert.ToInt32(reader["UserID"]);
                        int roleID = Convert.ToInt32(reader["RoleID"]);
                        string fullName = reader["FullName"].ToString();
                        reader.Close();

                        Session.UserID = userID;          
                        Session.RoleID = roleID;            
                        Session.HRFullName = fullName;    

                        if (roleID == 1)
                        {
                            MessageBox.Show($"Welcome, {fullName}! (Admin)");
                            FormHRDashboard dash = new FormHRDashboard();
                            dash.Show();
                            this.Hide();
                        }
                        else if (roleID == 2)
                        {
                            MessageBox.Show($"Welcome, {fullName}! (HR Staff)");
                            FormHRDashboard dash = new FormHRDashboard();
                            dash.Show();
                            this.Hide();
                        }
                        else if (roleID == 3)
                        {
                            MessageBox.Show($"Welcome, {fullName}! (HR Manager)");
                            FormHRDashboard dash = new FormHRDashboard();
                            dash.Show();
                            this.Hide();
                        }
                        return;
                    }
                    reader.Close();

                    // Check Applicants
                    string applicantQuery = @"
    SELECT ApplicantAccountID
    FROM ApplicantAccounts
    WHERE Email = @Email
    AND PasswordHash = @Password
    AND IsActive = TRUE";

                    MySqlCommand cmd2 = new MySqlCommand(applicantQuery, conn);
                    cmd2.Parameters.AddWithValue("@Email", email);
                    cmd2.Parameters.AddWithValue("@Password", password);

                    object applicantResult = cmd2.ExecuteScalar();

                    if (applicantResult != null)
                    {
      
                        Session.ApplicantAccountID = Convert.ToInt32(applicantResult);
                        Session.Email = email;

  
                        string getApplicant = @"
        SELECT ApplicantID, FirstName, LastName 
        FROM Applicants 
        WHERE ApplicantAccountID = @ID";

                        MySqlCommand cmd3 = new MySqlCommand(getApplicant, conn);
                        cmd3.Parameters.AddWithValue("@ID", Session.ApplicantAccountID);

                        MySqlDataReader reader2 = cmd3.ExecuteReader();
                        if (reader2.Read())
                        {
                            Session.ApplicantID = Convert.ToInt32(reader2["ApplicantID"]);
                            Session.FullName = reader2["FirstName"].ToString() + " " + reader2["LastName"].ToString();
                        }
                        reader2.Close();

                        MessageBox.Show("Welcome Applicant!");
                        FormApplicantDashboard dash = new FormApplicantDashboard();
                        dash.Show();
                        this.Hide();
                        return;
                    }

                    MessageBox.Show("Invalid email or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormApplicantRegister reg = new FormApplicantRegister();
            reg.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
