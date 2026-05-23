using System;
using System.Windows.Forms;
using UserNamespace;

namespace Activity10Application
{
    public partial class frmAdminPanel : Form
    {
        private Administrator admin;

        // Constructor receives the logged-in admin object
        public frmAdminPanel(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
            lblWelcome.Text = "Welcome, " + admin.getAdminName() + "!";
        }

        // Update Password button
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPass))
            {
                ShowMessage("Please enter a new password.", false);
                return;
            }

            if (!newPass.Equals(confirmPass))
            {
                ShowMessage("Passwords do not match.", false);
                return;
            }

            // Call the overridden updatePassword method (polymorphism)
            admin.updatePassword(newPass);
            ShowMessage("Password updated successfully!", true);
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        // Update Admin Name button
        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            string newName = txtNewName.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                ShowMessage("Please enter a new admin name.", false);
                return;
            }

            // Call updateAdminName from Administrator class
            admin.updateAdminName(newName);
            lblWelcome.Text = "Welcome, " + admin.getAdminName() + "!";
            ShowMessage("Admin name updated to \"" + newName + "\"!", true);
            txtNewName.Clear();
        }

        // Logout button - go back to login form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Show the existing hidden login form instead of creating a new one
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmLogin)
                {
                    form.Show();
                    break;
                }
            }
            this.Close();
        }

        // Helper method to show status messages
        private void ShowMessage(string message, bool isSuccess)
        {
            lblMessage.ForeColor = isSuccess
                ? System.Drawing.Color.FromArgb(34, 197, 94)
                : System.Drawing.Color.FromArgb(220, 53, 69);
            lblMessage.Text = message;
            lblMessage.Visible = true;
        }
    }
}
