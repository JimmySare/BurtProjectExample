namespace BurtProject.LDAP;

public static class LDAP
{
    public static string GetLogonServer()
    {
        var logonServer = Environment.GetEnvironmentVariable("LOGONSERVER").Trim('\\');
        if(logonServer == null)
        {
            Console.WriteLine("This totally failed.");
            System.Environment.Exit(1);
        }

        return logonServer;
    }
}