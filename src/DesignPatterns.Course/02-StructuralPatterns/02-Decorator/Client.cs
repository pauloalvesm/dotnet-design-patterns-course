using DesignPatterns.Course._02_StructuralPatterns._02_Decorator.Decorators;
using DesignPatterns.Course._02_StructuralPatterns._02_Decorator.Interfaces;
using DesignPatterns.Course._02_StructuralPatterns._02_Decorator.Services;

namespace DesignPatterns.Course._02_StructuralPatterns._02_Decorator;

public class Client
{
    public void ConsumeServices()
    {
        IPet bathAndGrooming = new BathAndGrooming("Bath and Grooming", 45.00);

        IPet accessoryDecorator = new AccessoryDecorator(bathAndGrooming);
        IPet luxurySpaDecorator = new LuxurySpaDecorator(accessoryDecorator);

        Console.WriteLine("Pet Shop Services Summary");
        Console.WriteLine(luxurySpaDecorator.GetServiceName());
        Console.WriteLine("Total value: " + luxurySpaDecorator.GetServiceValue());
    }
}
