using System;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        // Compute Salary button click
        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Validate all input fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the first name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the last name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Please enter the department.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartment.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("Please enter the job title.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobTitle.Focus();
                return;
            }

            double ratePerHour;
            int hoursWorked;

            if (!double.TryParse(txtRatePerHour.Text, out ratePerHour) || ratePerHour <= 0)
            {
                MessageBox.Show("Please enter a valid rate per hour.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRatePerHour.Focus();
                return;
            }

            if (!int.TryParse(txtHoursWorked.Text, out hoursWorked) || hoursWorked <= 0)
            {
                MessageBox.Show("Please enter valid total hours worked.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoursWorked.Focus();
                return;
            }

            // Create PartTimeEmployee object using the constructor
            PartTimeEmployee emp = new PartTimeEmployee(
                txtFirstName.Text,
                txtLastName.Text,
                txtDepartment.Text,
                txtJobTitle.Text
            );

            // Call computeSalary method from the interface
            emp.computeSalary(hoursWorked, ratePerHour);

            // Display employee info by accessing properties (get)
            lblFirstNameValue.Text = emp.FirstName;
            lblLastNameValue.Text = emp.LastName;
            lblDepartmentValue.Text = emp.Department;
            lblJobTitleValue.Text = emp.JobTitle;
            lblSalaryValue.Text = "₱ " + emp.getSalary().ToString("N2");

            // Show the result panel
            pnlResult.Visible = true;

            // Add to history listbox
            string historyEntry = emp.FirstName + " " + emp.LastName
                + " | " + emp.JobTitle
                + " | ₱ " + emp.getSalary().ToString("N2");
            lstHistory.Items.Insert(0, historyEntry);
        }

        // Clear button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDepartment.Clear();
            txtJobTitle.Clear();
            txtRatePerHour.Clear();
            txtHoursWorked.Clear();

            lblFirstNameValue.Text = "—";
            lblLastNameValue.Text = "—";
            lblDepartmentValue.Text = "—";
            lblJobTitleValue.Text = "—";
            lblSalaryValue.Text = "₱ 0.00";

            pnlResult.Visible = false;
            txtFirstName.Focus();
        }

        // Clear History button click
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }
    }
}