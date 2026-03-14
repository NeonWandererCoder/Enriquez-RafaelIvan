using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Validate that the name field is not empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the student's name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Variables for parsing each grade
            double english, math, science, filipino, history, programming;

            // Validate that all grade fields contain valid numbers
            if (!double.TryParse(txtEnglish.Text, out english) ||
                !double.TryParse(txtMath.Text, out math) ||
                !double.TryParse(txtScience.Text, out science) ||
                !double.TryParse(txtFilipino.Text, out filipino) ||
                !double.TryParse(txtHistory.Text, out history)  ||
                !double.TryParse(txtProgramming.Text, out programming))

            {
                MessageBox.Show("Please enter valid numeric grades for all subjects.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate the average of the five subjects
            double average = (english + math + science + filipino + history + programming) / 6;

            // Use the ternary operator to determine pass or fail
            // Condition: average >= 75.00 means passed, otherwise failed
            string status = (average >= 75.00) ? "passed" : "failed";

            // Display the result in the label
            lblResult.Text = "The student " + status + ".\n"
                + "The general average of " + txtName.Text + " is " + average.ToString("F2") + ".";
        }

    }
}