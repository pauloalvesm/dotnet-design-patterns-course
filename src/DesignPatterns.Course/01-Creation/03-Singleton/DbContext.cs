namespace DesignPatterns.Course._01_Creation._03_Singleton;

public class DbContext
{
    private static DbContext _instance = null;

    private DbContext() {}

    public static DbContext Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DbContext();
                Console.WriteLine("DbContext instance successfully created!");
            }
            return _instance;
        }
    }

    public void ExecuteQuery(string query)
    {
        Console.WriteLine(query);
    }
}
