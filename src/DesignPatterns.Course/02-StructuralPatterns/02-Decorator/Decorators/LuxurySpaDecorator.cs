using DesignPatterns.Course._02_StructuralPatterns._02_Decorator.Interfaces;

namespace DesignPatterns.Course._02_StructuralPatterns._02_Decorator.Decorators;

public class LuxurySpaDecorator : PetDecorator
{
    public LuxurySpaDecorator(IPet pet) : base(pet) { }

    public override double GetServiceValue()
    {
        return base.GetServiceValue() + 200.00;
    }

    public override string GetServiceName()
    {
        return base.GetServiceName() + "\n[+] Luxury Spa";
    }
}
