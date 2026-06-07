using DesignPatterns.Course._03_Behavioral._06_Strategy.Enums;
using DesignPatterns.Course._03_Behavioral._06_Strategy.Interfaces;
using DesignPatterns.Course._03_Behavioral._06_Strategy.Models;
using DesignPatterns.Course._03_Behavioral._06_Strategy.Services;

namespace DesignPatterns.Course._03_Behavioral._06_Strategy;

public class ServiceTaxRoutine
{
    public void ExecuteRoutine()
    {
        var penthouse01 = new Budget(01, 70, 30, ServicePercentage.Penthouse);
        var penthouse02 = new Budget(02, 70, 65, ServicePercentage.Penthouse);
        var master01 = new Budget(03, 50, 20, ServicePercentage.Master, true);
        var master02 = new Budget(04, 50, 60, ServicePercentage.Master, true);
        var master03 = new Budget(05, 50, 15, ServicePercentage.Master);
        var premium01 = new Budget(06, 40, 23, ServicePercentage.Premium, true);
        var premium02 = new Budget(06, 40, 23, ServicePercentage.Premium);
        var traditional01 = new Budget(07, 30, 20, ServicePercentage.Traditional);
        var traditional02 = new Budget(08, 30, 32, ServicePercentage.Traditional, true);

        var servicesBudgets = new List<IService>()
            {
                new PenthouseService(penthouse01),
                new PenthouseService(penthouse02),
                new MasterService(master01),
                new MasterService(master02),
                new MasterService(master03),
                new PremiumService(premium01),
                new PremiumService(premium02),
                new TraditionalService(traditional01),
                new TraditionalService(traditional02)
            };

        ServiceTaxCalculator taxCalculator = new ServiceTaxCalculator();

        taxCalculator.Calculate(servicesBudgets);
    }
}
