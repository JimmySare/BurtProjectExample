namespace BurtProject;

public class Program
{
    static void Main(string[] args)
    {
        var logonServer = BurtProject.LDAP.LDAP.GetLogonServer();
        Console.WriteLine(logonServer);
    }
}