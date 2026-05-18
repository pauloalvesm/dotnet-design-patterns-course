using DesignPatterns.Course._01_Creation._01_FactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Design Patterns Course **********");

        #region FactoryMethod

        var client = new Client();
        client.ExecuteProductCreation();

        #endregion

        Console.ReadKey();
    }
}