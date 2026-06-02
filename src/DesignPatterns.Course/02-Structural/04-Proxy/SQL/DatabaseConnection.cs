using DesignPatterns.Course._02_Structural._04_Proxy.Models;

namespace DesignPatterns.Course._02_Structural._04_Proxy.SQL;

public class DatabaseConnection
{
    public void LogVpnAccess(User user)
    {
        var query = $@"INSERT INTO TB_VpnAccessLog (User, Password, Timestamp)
            \nVALUES('{user.Username}', '{user.Password}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')\n";

        Console.WriteLine("[!] - Logging access through proxy...\n");
        Console.WriteLine(query);
    }
}