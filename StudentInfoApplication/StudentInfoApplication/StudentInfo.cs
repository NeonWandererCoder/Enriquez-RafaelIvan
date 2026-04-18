namespace StudentNamespace
{
    public class StudentInfo
    {
        // Private instance variables (encapsulation - hiding data)
        private string studentId;
        private string lastName;
        private string firstName;

        // Constructor 1: Default constructor (no parameters)
        public StudentInfo()
        {
            this.studentId = "";
            this.lastName = "";
            this.firstName = "";
        }

        // Constructor 2: Overloaded constructor (with parameters)
        // Uses the 'this' keyword to refer to the current object
        public StudentInfo(string studentId, string lastName, string firstName)
        {
            this.studentId = studentId;
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // Property for Student ID (get and set methods)
        public string StudentId
        {
            get { return this.studentId; }
            set { this.studentId = value; }
        }

        // Property for Last Name (get and set methods)
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        // Property for First Name (get and set methods)
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
    }
}
