// using DesignPatterns.Course._01_Creation._01_FactoryMethod;
// using DesignPatterns.Course._01_Creation._02_AbstractFactory;
// using DesignPatterns.Course._01_Creation._03_Singleton;
// using DesignPatterns.Course._01_Creation._04_Builder;
// using DesignPatterns.Course._01_Creation._05_Prototype;
// using DesignPatterns.Course._02_StructuralPatterns._01_Composite;
// using DesignPatterns.Course._02_StructuralPatterns._02_Decorator;
// using DesignPatterns.Course._02_StructuralPatterns._03_Facade;
// using DesignPatterns.Course._02_StructuralPatterns._04_Proxy;
// using DesignPatterns.Course._02_StructuralPatterns._05_Flyweight;
// using DesignPatterns.Course._02_StructuralPatterns._06_Adapter;
// using DesignPatterns.Course._02_StructuralPatterns._07_Bridge;
// using DesignPatterns.Course._02_StructuralPatterns._07_Bridge.Abstractions;
// using DesignPatterns.Course._02_StructuralPatterns._07_Bridge.Implementations;

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

        #region Composite

        //var client = new Client();
        //client.Checkout();

        #endregion

        #region Decorator

        //var client = new Client();
        //client.ConsumeServices();

        #endregion

        #region Facade

        //var facade = new FacadeManager();
        //facade.ExecuteComplexity();

        #endregion

        #region Proxy

        // var client = new Client();
        // client.TryVpnClientConnection();

        #endregion

        #region Flyweight

        //var client = new Client();
        //client.ConsumeFlyweight();

        #endregion

        #region Adapter

        //var cloud = new CloudComputing();
        //cloud.ProcessAccounts("September");

        #endregion

        #region Bridge

        //Client client;
        //Random random;

        //while (true)
        //{
        //    client = new Client();
        //    random = new Random();

        //    if (random.Next(2) == 1)
        //    {
        //        client.Material = new BallpointPen();
        //    }
        //    else
        //    {
        //        client.Material = new MarkerPen();
        //    }

        //    if (random.Next(1, 4) == 1)
        //    {
        //        client.Material.ColorImplementation = new Blue();
        //    }
        //    else if (random.Next(1, 4) == 2)
        //    {
        //        client.Material.ColorImplementation = new Black();
        //    }
        //    else
        //    {
        //        client.Material.ColorImplementation = new Red();
        //    }

        //    client.CheckPensAndMarkersStock();

        //    Console.WriteLine("Press Enter to continue or any other key to exit...");
        //    ConsoleKeyInfo key = Console.ReadKey();

        //    if (key.Key != ConsoleKey.Enter)
        //    {
        //        break;
        //    }
        //}

        #endregion

        Console.ReadKey();
    }
}