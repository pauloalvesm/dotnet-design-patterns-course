using DesignPatterns.Course._01_Creation._01_FactoryMethod.Interfaces;

namespace DesignPatterns.Course._01_Creation._01_FactoryMethod.Services;

public class TraditionalService : IService
{
    public TraditionalService()
    {
        Console.WriteLine("Traditional product successfully created!");
    }

    public void ExecuteServiceBilling()
    {
        throw new NotImplementedException();
    }
}
