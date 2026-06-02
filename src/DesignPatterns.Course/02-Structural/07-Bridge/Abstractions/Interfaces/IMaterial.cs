using DesignPatterns.Course._02_Structural._07_Bridge.Implementations.Interfaces;

namespace DesignPatterns.Course._02_Structural._07_Bridge.Abstractions.Interfaces;

public interface IMaterial
{
    public IColor ColorImplementation { get; set; }

    string CheckStock();
}