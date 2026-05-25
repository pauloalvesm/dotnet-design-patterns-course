using DesignPatterns.Course._01_Creation._01_FactoryMethod.Enums;
using DesignPatterns.Course._01_Creation._01_FactoryMethod.Interfaces;

namespace DesignPatterns.Course._01_Creation._01_FactoryMethod;

public abstract class ServiceFactory
{
    public abstract IService ManufactureProduct(ServiceType serviceType);
}