namespace DesignPatterns.Course._01_Creation._03_Singleton;

public class Client
{
    public void ConsumeDatabase()
    {
        var instance = DbContext.Instance;
        instance.ExecuteQuery("SELECT * FROM TableName;");

        instance = DbContext.Instance;
        instance.ExecuteQuery("INSERT INTO TableName (value) VALUES (0001);");

        instance = DbContext.Instance;
        instance.ExecuteQuery("UPDATE TableName SET value=0002 WHERE Id=01;");

        instance = DbContext.Instance;
        instance.ExecuteQuery("DELETE FROM TableName WHERE Id=01;");
    }
}
