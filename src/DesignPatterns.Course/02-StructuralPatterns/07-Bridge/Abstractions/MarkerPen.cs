using DesignPatterns.Course._02_StructuralPatterns._07_Bridge.Abstractions.Interfaces;
using DesignPatterns.Course._02_StructuralPatterns._07_Bridge.Implementations.Interfaces;

namespace DesignPatterns.Course._02_StructuralPatterns._07_Bridge.Abstractions;

public class MarkerPen : IMaterial
{
    public IColor ColorImplementation { get; set; }

    public string CheckStock()
    {
        return this.ColorImplementation.CheckQuantityByColor("Marker Pen");
    }
}
