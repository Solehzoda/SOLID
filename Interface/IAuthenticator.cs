namespace SOLID
{
    public interface IAuthenticator
    {
        bool Authenticate(USER user, string password);
    }
}