using System;
using System.Collections;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        // Form Load event - populate the combo boxes
        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            // Add default placeholder items
            cmbDay.Items.Add("-Day-");
            cmbMonth.Items.Add("-Month-");
            cmbYear.Items.Add("-Year-");
            cmbProgram.Items.Add("-Select program-");

            // Use a loop to add days 1 to 31
            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day);
            }

            // Create a string array that contains the 12 months of the year
            string[] months = { "January", "February", "March", "April",
                                "May", "June", "July", "August",
                                "September", "October", "November", "December" };

            // Use a foreach loop to add the months to the Month combo box
            foreach (string month in months)
            {
                cmbMonth.Items.Add(month);
            }

            // Use a loop to add years from 1900 to the current year
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                cmbYear.Items.Add(year);
            }

            // Create an ArrayList that contains the list of programs
            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            // Use a foreach loop to add the programs to the Program combo box
            foreach (string program in programs)
            {
                cmbProgram.Items.Add(program);
            }

            // Set default selection to the placeholder text
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbProgram.SelectedIndex = 0;
        }

        // Browse button - open file dialog to select a photo
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Set the file filter to only show image files
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Show the file dialog and check if user selected a file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                picStudent.ImageLocation = openFileDialog1.FileName;
            }
        }

        // THREE (3) OVERLOADED METHODS - DisplayInfo
        // Same method name, different parameters
    

        // Overloaded Method 1: Displays name, gender, date of birth, and program (4 parameters)
        private void DisplayInfo(string name, string gender, string dateOfBirth, string program)
        {
            string message = "Student name: " + name + "\n"
                           + "Gender: " + gender + "\n"
                           + "Date of birth: " + dateOfBirth + "\n"
                           + "Program: " + program;

            MessageBox.Show(message);
        }

        // Overloaded Method 2: Displays name and program only (2 parameters)
        private void DisplayInfo(string name, string program)
        {
            string message = "Student name: " + name + "\n"
                           + "Program: " + program;

            MessageBox.Show(message);
        }

        // Overloaded Method 3: Displays first and last name and gets program from combo box (1 parameter)
        private void DisplayInfo(string name)
        {
            string program = cmbProgram.SelectedItem.ToString();

            string message = "Student name: " + txtLastName.Text + " " +txtFirstName.Text +" \n"
                           + "Program: " + program;

            MessageBox.Show(message);
        }

        // Register student button click event
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

            // Validate that a gender is selected
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Please select a gender.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate combo boxes
            if (cmbDay.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a day.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMonth.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a month.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbYear.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a year.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbProgram.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a program.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the values from the form
            string day = cmbDay.SelectedItem.ToString();
            string month = cmbMonth.SelectedItem.ToString();
            string year = cmbYear.SelectedItem.ToString();
            string program = cmbProgram.SelectedItem.ToString();

            // Determine the gender
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }

            // Build the full name and date of birth
            string fullName = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;
            string dateOfBirth = day + "/" + month + "/" + year;

            // Invoke the 3 overloaded methods - each shows a different message box
            DisplayInfo(fullName, gender, dateOfBirth, program);  // Method 1: 4 parameters
            DisplayInfo(fullName, program);                        // Method 2: 2 parameters
            DisplayInfo(fullName);                                 // Method 3: 1 parameter
        }
    }
}
