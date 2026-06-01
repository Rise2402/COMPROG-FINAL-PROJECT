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
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (email == "" || password == "")
                {
                    MessageBox.Show("Please enter email and password.");
                    return;
                }

                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string applicantQuery = @"
                SELECT ApplicantAccountID
                FROM ApplicantAccounts
                WHERE Email=@Email AND PasswordHash=@Password";

                    MySqlCommand cmd1 = new MySqlCommand(applicantQuery, conn);
                    cmd1.Parameters.AddWithValue("@Email", email);
                    cmd1.Parameters.AddWithValue("@Password", password);

                    object applicantResult = cmd1.ExecuteScalar();

                    if (applicantResult != null)
                    {
                        MessageBox.Show("Welcome Applicant!");

                        FormApplicantDashboard dash = new FormApplicantDashboard();
                        dash.Show();
                        this.Hide();
                        return;
                    }

                    string hrQuery = @"
                SELECT u.UserID, r.RoleName
                FROM Users u
                INNER JOIN Roles r ON u.RoleID = r.RoleID
                WHERE u.Username=@Username AND u.PasswordHash=@Password";

                    MySqlCommand cmd2 = new MySqlCommand(hrQuery, conn);
                    cmd2.Parameters.AddWithValue("@Username", email); // email textbox used as username
                    cmd2.Parameters.AddWithValue("@Password", password);

                    MySqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["RoleName"].ToString();

                        MessageBox.Show("Welcome " + role);

                        FormHRDashboard dash = new FormHRDashboard();
                        dash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!");
                    }
                }
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
