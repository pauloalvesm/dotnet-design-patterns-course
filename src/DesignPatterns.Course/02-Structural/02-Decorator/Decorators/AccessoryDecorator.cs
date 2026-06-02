using DesignPatterns.Course._02_Structural._02_Decorator.Interfaces;

namespace DesignPatterns.Course._02_Structural._02_Decorator.Decorators;

public class AccessoryDecorator : PetDecorator
{
    public AccessoryDecorator(IPet pet) : base(pet) { }

    public override double GetServiceValue()
    {
        return base.GetServiceValue();
    }

    public override string GetServiceName()
    {
        return base.GetServiceName() + "\n[+] Accessory";
    }
}
