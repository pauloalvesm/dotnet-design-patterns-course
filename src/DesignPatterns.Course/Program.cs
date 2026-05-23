// using DesignPatterns.Course._01_Creation._01_FactoryMethod;
// using DesignPatterns.Course._01_Creation._02_AbstractFactory;
// using DesignPatterns.Course._01_Creation._03_Singleton;
// using DesignPatterns.Course._01_Creation._04_Builder;
// using DesignPatterns.Course._01_Creation._05_Prototype;

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

        //var client = new Client();
        //client.ConsultStudentRoutine();

        #endregion

        #region Singleton

        //var client = new Client();
        //client.ConsumeDatabase();

        #endregion

        #region Builder

        //var client = new Client();
        //client.ConsumeStudioData();

        #endregion

        #region Prototype

        //var client = new Client();
        //client.ConsumeStudioData();

        #endregion

        Console.ReadKey();
    }
}