using DesignPatterns.Course._01_Creation._01_FactoryMethod.Interfaces;

namespace DesignPatterns.Course._01_Creation._01_FactoryMethod.Services;

public class PremiumService : IService
{
    public PremiumService()
    {
        Console.WriteLine("Premium product successfully created!");
    }

    public void ExecuteServiceBilling()
    {
        throw new NotImplementedException();
    }
}
