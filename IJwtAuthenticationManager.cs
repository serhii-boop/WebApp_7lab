namespace WebApp_7lab
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password); 
    }
}
