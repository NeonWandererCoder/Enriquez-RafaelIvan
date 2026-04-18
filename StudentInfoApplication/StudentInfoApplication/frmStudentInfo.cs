using System;
using System.Windows.Forms;
using StudentNamespace;  // Access the public members of StudentNamespace

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        // Track how many records have been added
        int recordCount = 0;

        public frmStudentInfo()
        {
            InitializeComponent();
        }

        // Submit button click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate that the Student ID is not empty
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Please enter the Student ID.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentId.Focus();
                return;
            }

            // Validate that the Last Name is not empty
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the Last Name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            // Validate that the First Name is not empty
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the First Name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            // Create a new StudentInfo object using the overloaded constructor
            StudentInfo student = new StudentInfo(txtStudentId.Text, txtLastName.Text, txtFirstName.Text);

            // Add the student information to the list boxes using properties
            lstStudentId.Items.Add(student.StudentId);
            lstFirstName.Items.Add(student.FirstName);
            lstLastName.Items.Add(student.LastName);

            // Update the record count
            recordCount++;
            lblRecordCount.Text = recordCount + (recordCount == 1 ? " record" : " records");

            // Clear the textboxes after submitting
            txtStudentId.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtStudentId.Focus();
        }

        // Clear button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtStudentId.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();

            // Clear all list boxes
            lstStudentId.Items.Clear();
            lstFirstName.Items.Clear();
            lstLastName.Items.Clear();

            // Reset record count
            recordCount = 0;
            lblRecordCount.Text = "0 records";

            // Focus back to Student ID
            txtStudentId.Focus();
        }
    }
}
