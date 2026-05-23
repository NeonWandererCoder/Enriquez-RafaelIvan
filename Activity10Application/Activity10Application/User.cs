namespace UserNamespace
{
    public abstract class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool verifyLogin(string id, string pass)
        {
            if (this.user_id.Equals(id) && this.user_password.Equals(pass))
                return true;
            return false;
        }

        public abstract void updatePassword(string newPassword);
    }
}
