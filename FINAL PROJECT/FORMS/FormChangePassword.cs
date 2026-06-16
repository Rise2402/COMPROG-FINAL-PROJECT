using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FINAL_PROJECT;

namespace FINAL_PROJECT.FORMS
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;
            txtCurrentPassword.UseSystemPasswordChar = !show;
            txtNewPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // ── Validation ────────────────────────────────────────────
            if (string.IsNullOrEmpty(currentPassword) ||
                string.IsNullOrEmpty(newPassword) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            if (currentPassword == newPassword)
            {
                MessageBox.Show("New password must be different from current password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── Verify current password ───────────────────────────────
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string verifyQuery = @"
                        SELECT COUNT(*) FROM ApplicantAccounts
                        WHERE ApplicantAccountID = @AccountID
                          AND PasswordHash = @CurrentPassword
                          AND IsActive = TRUE";

                    MySqlCommand verifyCmd = new MySqlCommand(verifyQuery, conn);
                    verifyCmd.Parameters.AddWithValue("@AccountID", Session.ApplicantAccountID);
                    verifyCmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                    int match = Convert.ToInt32(verifyCmd.ExecuteScalar());

                    if (match == 0)
                    {
                        MessageBox.Show("Current password is incorrect.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentPassword.Clear();
                        txtCurrentPassword.Focus();
                        return;
                    }

                    // ── Update password ───────────────────────────────
                    string updateQuery = @"
                        UPDATE ApplicantAccounts
                        SET PasswordHash = @NewPassword
                        WHERE ApplicantAccountID = @AccountID";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@AccountID", Session.ApplicantAccountID);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Password changed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing password: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}