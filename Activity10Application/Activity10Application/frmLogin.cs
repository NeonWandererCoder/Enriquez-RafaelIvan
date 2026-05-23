using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using UserNamespace;

namespace Activity10Application
{
    public partial class frmLogin : Form
    {
        private Administrator admin = new Administrator("Admin User", "admin01", "admin1234");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtLoginId.Text.Trim();
            string pass = txtLoginPass.Text;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(pass))
            {
                lblError.Text = "Please fill in all fields.";
                lblError.Visible = true;
                return;
            }

            // Call verifyLogin from User base class using Equals()
            if (admin.verifyLogin(id, pass))
            {
                lblError.Visible = false;

                // Open admin panel and pass the admin object
                frmAdminPanel adminPanel = new frmAdminPanel(admin);
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid ID or password. Try again.";
                lblError.Visible = true;
                txtLoginPass.Clear();
                txtLoginPass.Focus();
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPass.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void txtLoginId_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtLoginPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtLoginPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
