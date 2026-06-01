using DesignPatterns.Course._02_StructuralPatterns._07_Bridge.Implementations.Interfaces;

namespace DesignPatterns.Course._02_StructuralPatterns._07_Bridge.Abstractions.Interfaces;

public interface IMaterial
{
    public IColor ColorImplementation { get; set; }

    string CheckStock();
}