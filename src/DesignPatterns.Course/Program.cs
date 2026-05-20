// using DesignPatterns.Course._01_Creation._01_FactoryMethod;
using DesignPatterns.Course._01_Creation._02_AbstractFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********** Design Patterns Course **********");

        #region FactoryMethod

        //var client = new Client();
        //client.ExecuteProductCreation();

        #endregion

        #region AbstractFactory

        var client = new Client();
        client.ConsultStudentRoutine();

        #endregion

        Console.ReadKey();
    }
}