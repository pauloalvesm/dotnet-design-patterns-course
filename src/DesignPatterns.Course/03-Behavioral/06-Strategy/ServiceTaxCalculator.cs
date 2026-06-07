using DesignPatterns.Course._03_Behavioral._06_Strategy.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._06_Strategy;

public class ServiceTaxCalculator
{
    public void Calculate(List<IService> services)
    {
        foreach (IService service in services)
        {
            service.CalculateService();
            Console.WriteLine(new string('-', 40));
        }
    }
}
