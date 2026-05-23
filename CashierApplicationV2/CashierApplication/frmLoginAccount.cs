using System;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        // Create a Cashier object with hardcoded credentials
        private Cashier cashier = new Cashier("Nirma Nora", "Finance", "cashier101", "pass1234");

        // Track failed login attempts
        private int failedAttempts = 0;
        private const int MAX_ATTEMPTS = 3;

        public frmLoginAccount()
        {
            InitializeComponent();
        }

        // Login button click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate empty fields
            if (string.IsNullOrWhiteSpace(username))
            {
                lblError.Text = "Please enter your username.";
                lblError.Visible = true;
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter your password.";
                lblError.Visible = true;
                txtPassword.Focus();
                return;
            }

            // Call the overridden validateLogin method (polymorphism - runtime)
            if (cashier.validateLogin(username, password))
            {
                // Successful login - show welcome message
                string welcomeMsg = "Welcome " + cashier.getFullName() + " of " + cashier.getDepartment();
                MessageBox.Show(welcomeMsg, "Login Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the main form and hide this login form
                frmPurchaseDiscountedItem mainForm = new frmPurchaseDiscountedItem(cashier);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                failedAttempts++;
                int remaining = MAX_ATTEMPTS - failedAttempts;

                if (failedAttempts >= MAX_ATTEMPTS)
                {
                    lblError.Text = "Too many failed attempts. Application will close.";
                    lblError.Visible = true;
                    btnLogin.Enabled = false;
                    MessageBox.Show("Maximum login attempts reached. The application will now close.",
                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    lblError.Text = "Invalid username or password. " + remaining + " attempt(s) remaining.";
                    lblError.Visible = true;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        // Show/hide password toggle
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Allow pressing Enter to login
        private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        // Clear error message when user starts typing
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
