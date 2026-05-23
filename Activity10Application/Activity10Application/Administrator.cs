namespace UserNamespace
{
    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass)
            : base(id, pass)
        {
            this.admin_name = name;
        }

        // Override of the abstract updatePassword from User
        public override void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            this.admin_name = name;
        }

        public string getAdminName()
        {
            return this.admin_name;
        }
    }
}
