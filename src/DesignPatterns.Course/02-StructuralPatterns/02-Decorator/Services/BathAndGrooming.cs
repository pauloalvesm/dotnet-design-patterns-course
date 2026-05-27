using DesignPatterns.Course._02_StructuralPatterns._02_Decorator.Interfaces;

namespace DesignPatterns.Course._02_StructuralPatterns._02_Decorator.Services;

public class BathAndGrooming : IPet
{
    private string _serviceName;
    private double _serviceValue;

    public BathAndGrooming(string serviceName, double serviceValue)
    {
        _serviceName = serviceName;
        _serviceValue = serviceValue;
    }

    public string GetServiceName()
    {
        return _serviceName;
    }

    public double GetServiceValue()
    {
        return _serviceValue;
    }
}
