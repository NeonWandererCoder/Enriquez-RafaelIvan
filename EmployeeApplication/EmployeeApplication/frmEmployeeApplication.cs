using System;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            // Set up DataGridView columns on load
            dgvEmployees.Columns.Add("colId", "id");
            dgvEmployees.Columns.Add("colFirstName", "firstName");
            dgvEmployees.Columns.Add("colLastName", "lastName");
            dgvEmployees.Columns.Add("colPosition", "position");

            // Make columns fill the DataGridView width evenly
            foreach (DataGridViewColumn col in dgvEmployees.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validaye all input fields before creating an Employee object
            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
            {
                MessageBox.Show("Please enter the Employee ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the First Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the Last Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Please enter the Position.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPosition.Focus();
                return;
            }

            // Create a new Employee object using the overloaded constructor
            Employee emp = new Employee(txtEmployeeId.Text, txtFirstName.Text,
                                        txtLastName.Text, txtPosition.Text);

            // Add the employee data to the DataGridView using properties
            dgvEmployees.Rows.Add(emp.EmployeeId, emp.FirstName, emp.LastName, emp.Position);

            // Update record count
            lblRecordCount.Text = dgvEmployees.Rows.Count + " employee(s) listed";

            // Clear inputs and return focus
            txtEmployeeId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();
            txtEmployeeId.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();
            dgvEmployees.Rows.Clear();
            lblRecordCount.Text = "0 employee(s) listed";
            txtEmployeeId.Focus();
        }
    }
}
