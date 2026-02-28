using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        // Form Load event - populate the combo boxes using loops
        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            // Add default placeholder items first
            cmbDay.Items.Add("-Day-");
            cmbMonth.Items.Add("-Month-");
            cmbYear.Items.Add("-Year-");

            // Use a loop to add days 1 to 31
            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day);
            }

            // Use a loop to add months 1 to 12
            for (int month = 1; month <= 12; month++)
            {
                cmbMonth.Items.Add(month);
            }

            // Use a loop to add years from 1900 to the current year
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                cmbYear.Items.Add(year);
            }

            // Set default selection to the placeholder text
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }

        // Button click event - validate inputs and display the message box
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate that the last name is not empty
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the last name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return;
            }

            // Validate that the first name is not empty
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the first name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return;
            }

            // Validate that the middle name is not empty
            if (string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Please enter the middle name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMiddleName.Focus();
                return;
            }

            // Validate that a gender is selected using a decision statement
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Please select a gender.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that the user selected a day (not the placeholder)
            if (cmbDay.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a day.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that the user selected a month (not the placeholder)
            if (cmbMonth.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a month.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that the user selected a year (not the placeholder)
            if (cmbYear.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a year.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected values from the combo boxes
            string day = cmbDay.SelectedItem.ToString();
            string month = cmbMonth.SelectedItem.ToString();
            string year = cmbYear.SelectedItem.ToString();

            // Determine the gender using a decision statement
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }

            // Build the full name: First Middle Last
            string fullName = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;

            // Build the date of birth string
            string dateOfBirth = day + "/" + month + "/" + year;

            // Display the student information in a message box
            string message = "Student name: " + fullName + "\n"
                           + "Gender: " + gender + "\n"
                           + "Date of birth: " + dateOfBirth;

            MessageBox.Show(message);
        }
    }
}
