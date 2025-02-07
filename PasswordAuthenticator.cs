namespace SOLID
{
    public class PasswordAuthenticator
    {
        public bool Authenticate(USER user, string password)
        {
            return user.VerifyPassword(password);
        }
    }
}