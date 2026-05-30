namespace EmployeeInterface
{
    public interface IEmployee
    {
        // Properties declared in the interface
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double BasicSalary { get; set; }

        // Method declared in the interface
        void computeSalary(int hoursWorked, double ratePerHour);
    }
}