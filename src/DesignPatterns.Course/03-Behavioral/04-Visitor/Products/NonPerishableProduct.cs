using DesignPatterns.Course._03_Behavioral._04_Visitor.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._04_Visitor.Products;

public class NonPerishableProduct : IProduct
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public NonPerishableProduct(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public double GetTax(IVisitor visitor)
    {
        return visitor.CalculateNonPerishableProductTax(this);
    }
}