using DesignPatterns.Course._02_Structural._02_Decorator.Interfaces;

namespace DesignPatterns.Course._02_Structural._02_Decorator.Decorators;

public abstract class PetDecorator : IPet
{
    protected IPet _pet;

    protected PetDecorator(IPet pet)
    {
        _pet = pet;
    }

    public virtual string GetServiceName()
    {
        return _pet.GetServiceName();
    }

    public virtual double GetServiceValue()
    {
        return _pet.GetServiceValue();
    }
}
