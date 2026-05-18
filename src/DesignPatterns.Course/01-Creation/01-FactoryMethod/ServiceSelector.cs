using DesignPatterns.Course._01_Creation._01_FactoryMethod.Enums;
using DesignPatterns.Course._01_Creation._01_FactoryMethod.Interfaces;
using DesignPatterns.Course._01_Creation._01_FactoryMethod.Services;

namespace DesignPatterns.Course._01_Creation._01_FactoryMethod;

public class ServiceSelector : ServiceFactory
{
    public override IService ManufactureProduct(ServiceType serviceType)
    {
        switch (serviceType)
        {
            case ServiceType.Traditional:
                return new TraditionalService();
            case ServiceType.Premium:
                return new PremiumService();
            case ServiceType.Master:
                return new MasterService();
            case ServiceType.Coverage:
                return new CoverageService();
            default:
                return null;
        }
    }
}
