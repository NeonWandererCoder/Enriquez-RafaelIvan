namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password)
            : base(name, uName, password)
        {
            this.department = department;
        }

        // Override validateLogin - checks if username and password match
        public override bool validateLogin(string uName, string password)
        {
            if (this.user_name == uName && this.user_password == password)
                return true;
            return false;
        }

        public string getDepartment()
        {
            return this.department;
        }
    }
}
