using DesignPatterns.Course._02_StructuralPatterns._04_Proxy.Models;
using DesignPatterns.Course._02_StructuralPatterns._04_Proxy.VPN;

namespace DesignPatterns.Course._02_StructuralPatterns._04_Proxy;

public class Client
{
    public void TryVpnClientConnection()
    {
        var proxy = new VpnProxy();

        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        var user = new User(username, password);
        proxy.AccessVpn(user);
    }
}
