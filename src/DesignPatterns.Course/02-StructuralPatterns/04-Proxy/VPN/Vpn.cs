using DesignPatterns.Course._02_StructuralPatterns._04_Proxy.Interfaces;
using DesignPatterns.Course._02_StructuralPatterns._04_Proxy.Models;

namespace DesignPatterns.Course._02_StructuralPatterns._04_Proxy.VPN;

public class Vpn : IProxy
{
    public void AccessVpn(User user)
    {
        Console.WriteLine("[+] - ACCESSING VPN\n");
        Thread.Sleep(2000);
        Console.WriteLine($"{user.Username}, you are logged into the VPN");
    }
}