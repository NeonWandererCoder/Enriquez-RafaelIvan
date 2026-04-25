namespace EmployeeNamespace
{
    public class Employee
    {
        private string employeeId;
        private string firstName;
        private string lastName;
        private string position;

        // Default constructor
        public Employee()
        {
            this.employeeId = "";
            this.firstName = "";
            this.lastName = "";
            this.position = "";
        }

        // Overloaded constructor with all parameters
        public Employee(string employeeId, string firstName, string lastName, string position)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }

        // Properties with get and set
        public string EmployeeId
        {
            get { return this.employeeId; }
            set { this.employeeId = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
    }
}
