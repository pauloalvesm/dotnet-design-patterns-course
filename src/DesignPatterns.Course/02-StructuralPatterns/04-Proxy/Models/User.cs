namespace DesignPatterns.Course._02_StructuralPatterns._04_Proxy.Models;

public class User
{
    public string Username { get; private set; }
    public string Password { get; private set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
