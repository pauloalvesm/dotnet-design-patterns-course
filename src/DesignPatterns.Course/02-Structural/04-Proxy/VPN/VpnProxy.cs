using DesignPatterns.Course._02_Structural._04_Proxy.Interfaces;
using DesignPatterns.Course._02_Structural._04_Proxy.Models;
using DesignPatterns.Course._02_Structural._04_Proxy.SQL;

namespace DesignPatterns.Course._02_Structural._04_Proxy.VPN;

public class VpnProxy : IProxy
{
    public void AccessVpn(User user)
    {
        var sql = new DatabaseConnection();
        sql.LogVpnAccess(user);
        Console.WriteLine(new String('-', 40));

        var vpn = new Vpn();
        vpn.AccessVpn(user);
    }
}