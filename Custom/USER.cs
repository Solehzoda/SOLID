namespace SOLID
{
    public class USER
    {
        public string FirstName { get; private set; }
        private string Password;

        public USER(string firstName, string password)
        {
            FirstName = firstName;
            Password = HashPassword(password);
        }

        private string HashPassword(string password)
        {
            return password.GetHashCode().ToString();
        }

        public bool VerifyPassword(string password)
        {
            return Password == HashPassword(password);
        }
    }
}
    
    