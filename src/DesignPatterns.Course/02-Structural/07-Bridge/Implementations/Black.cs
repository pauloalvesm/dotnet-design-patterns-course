using DesignPatterns.Course._02_Structural._07_Bridge.Implementations.Interfaces;

namespace DesignPatterns.Course._02_Structural._07_Bridge.Implementations;

public class Black : IColor
{
    public string CheckQuantityByColor(string abstractionType)
    {
        var random = new Random();
        var quantity = random.Next(100, 500);

        return $"There are {quantity} Black units for {abstractionType} in stock.";
    }
}
