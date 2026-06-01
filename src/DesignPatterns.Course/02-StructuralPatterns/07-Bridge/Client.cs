using DesignPatterns.Course._02_StructuralPatterns._07_Bridge.Abstractions.Interfaces;

namespace DesignPatterns.Course._02_StructuralPatterns._07_Bridge;

public class Client
{
    public IMaterial Material { get; set; }

    public void CheckPensAndMarkersStock()
    {
        Console.WriteLine(this.Material.CheckStock());
    }
}
