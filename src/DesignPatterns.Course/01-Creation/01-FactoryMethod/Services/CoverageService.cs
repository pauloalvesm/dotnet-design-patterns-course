using DesignPatterns.Course._01_Creation._01_FactoryMethod.Interfaces;

namespace DesignPatterns.Course._01_Creation._01_FactoryMethod.Services;

public class CoverageService : IService
{
    public CoverageService()
    {
        Console.WriteLine("Coverage product successfully created!");
    }

    public void ExecuteServiceBilling()
    {
        throw new NotImplementedException();
    }
}
