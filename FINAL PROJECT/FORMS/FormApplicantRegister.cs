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
    public partial class FormApplicantRegister : Form
    {
        public FormApplicantRegister()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                string confirmPassword = textBox1.Text.Trim();

                if (email == "" || password == "" || confirmPassword == "")
                {
                    MessageBox.Show("Please complete all fields.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (MySqlConnection conn = DBConnection.GetConnection())
                    {
                        conn.Open();

                        string checkQuery =
                            "SELECT COUNT(*) FROM ApplicantAccounts WHERE Email=@Email";

                        MySqlCommand checkCmd =
                            new MySqlCommand(checkQuery, conn);

                        checkCmd.Parameters.AddWithValue("@Email", email);

                        int count =
                            Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Email already exists.",
                                "Duplicate Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        string insertQuery =
                        @"INSERT INTO ApplicantAccounts
                      (
                        Email,
                        PasswordHash
                      )
                      VALUES
                      (
                        @Email,
                        @Password
                      )";

                        MySqlCommand insertCmd =
                            new MySqlCommand(insertQuery, conn);

                        insertCmd.Parameters.AddWithValue("@Email", email);
                        insertCmd.Parameters.AddWithValue("@Password", password);

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Account created successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Form1 login = new Form1();
                        login.Show();

                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
