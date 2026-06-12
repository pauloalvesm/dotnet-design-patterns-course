using DesignPatterns.Course._03_Behavioral._04_Visitor.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._04_Visitor.Products;

public class PerishableProduct : IProduct
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public PerishableProduct(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public double GetTax(IVisitor visitor)
    {
        return visitor.CalculatePerishableProductTax(this);
    }
}
