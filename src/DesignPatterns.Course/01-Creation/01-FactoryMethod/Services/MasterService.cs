using DesignPatterns.Course._01_Creation._01_FactoryMethod.Interfaces;

namespace DesignPatterns.Course._01_Creation._01_FactoryMethod.Services;

public class MasterService : IService
{
    public MasterService()
    {
        Console.WriteLine("Master product successfully created!");
    }

    public void ExecuteServiceBilling()
    {
        throw new NotImplementedException();
    }
}
