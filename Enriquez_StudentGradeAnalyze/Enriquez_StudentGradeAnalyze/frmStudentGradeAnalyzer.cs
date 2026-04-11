using System;
using System.Windows.Forms;

namespace Enriquez_StudentGradeAnalyzer
{
    // Structure to store student-related data
    public struct Student
    {
        public string studentNumber;
        public string studentName;
        public double prelimGrade;
        public double midtermGrade;
        public double finalGrade;
        public double average;
        public string remarks;
    }

    public partial class frmStudentGradeAnalyzer : Form
    {
        public frmStudentGradeAnalyzer()
        {
            InitializeComponent();
        }

        
        // VALUE-RETURNING METHOD: Compute average of 5 grades
        private double ComputeAverage(double grade1, double grade2, double grade3, double grade4, double grade5)
        {
            double average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            return average;
        }

        
        // OVERLOADED METHOD: Compute average of 3 grades only
        // (Same method name, different parameters = method overloading)
        private double ComputeAverage(double grade1, double grade2, double grade3)
        {
            double average = (grade1 + grade2 + grade3) / 3;
            return average;
        }

        
        // STATIC METHOD: Determine if the student passed or failed
        public static string DetermineRemarks(double average)
        {
            // Passed if average is 75 and above, Failed if below 75
            if (average >= 75)
            {
                return "Passed";
            }
            else
            {
                return "Failed";
            }
        }


        // VOID METHOD: Display the student information in the listbox
        private void DisplayInfo(Student student)
        {
            lstOutput.Items.Add("===================================");
            lstOutput.Items.Add("Student Number: " + student.studentNumber);
            lstOutput.Items.Add("Student Name: " + student.studentName);
            lstOutput.Items.Add("Prelim: " + student.prelimGrade.ToString("F2")
                             + " | Midterm: " + student.midtermGrade.ToString("F2")
                             + " | Final: " + student.finalGrade.ToString("F2"));
            lstOutput.Items.Add("Average: " + student.average.ToString("F2"));
            lstOutput.Items.Add("Remarks: " + student.remarks);
            lstOutput.Items.Add("===================================");
        }

        // Compute button click event
        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Validate that the student number is not empty
            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                MessageBox.Show("Please enter the student number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNumber.Focus();
                return;
            }

            // Validate that the student name is not empty
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter the student name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return;
            }

            // Validate that all grade fields contain valid numbers
            double prelim, midterm, final_grade;

            if (!double.TryParse(txtPrelim.Text, out prelim))
            {
                MessageBox.Show("Please enter a valid Prelim grade.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrelim.Focus();
                return;
            }

            if (!double.TryParse(txtMidterm.Text, out midterm))
            {
                MessageBox.Show("Please enter a valid Midterm grade.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMidterm.Focus();
                return;
            }

            if (!double.TryParse(txtFinal.Text, out final_grade))
            {
                MessageBox.Show("Please enter a valid Final grade.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFinal.Focus();
                return;
            }

            // Create a Student structure and store the values
            Student student;
            student.studentNumber = txtStudentNumber.Text;
            student.studentName = txtStudentName.Text;
            student.prelimGrade = prelim;
            student.midtermGrade = midterm;
            student.finalGrade = final_grade;

            // Call the overloaded method (3 grades) to compute the average
            student.average = ComputeAverage(prelim, midterm, final_grade);

            // Call the static method to determine remarks
            student.remarks = DetermineRemarks(student.average);

            // Call the void method to display the results
            DisplayInfo(student);
        }

        // Clear button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all TextBox inputs
            txtStudentNumber.Clear();
            txtStudentName.Clear();
            txtPrelim.Clear();
            txtMidterm.Clear();
            txtFinal.Clear();

            // Clear the output display
            lstOutput.Items.Clear();

            // Return cursor focus to Student Number
            txtStudentNumber.Focus();
        }
    }
}
