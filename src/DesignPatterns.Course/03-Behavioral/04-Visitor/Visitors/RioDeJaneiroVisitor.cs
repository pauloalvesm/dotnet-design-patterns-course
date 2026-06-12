using DesignPatterns.Course._03_Behavioral._04_Visitor.Interfaces;
using DesignPatterns.Course._03_Behavioral._04_Visitor.Products;

namespace DesignPatterns.Course._03_Behavioral._04_Visitor.Visitors;

public class RioDeJaneiroVisitor : IVisitor
{
    public double CalculateNonPerishableProductTax(NonPerishableProduct nonPerishableProduct)
    {
        var tax = (nonPerishableProduct.Weight / 100) + 5;

        Console.WriteLine($"Rio de Janeiro Tax: {tax}");

        return tax;
    }

    public double CalculatePerishableProductTax(PerishableProduct perishableProduct)
    {
        var tax = (perishableProduct.Weight / 100) + 10;

        Console.WriteLine($"Rio de Janeiro Tax: {tax}");

        return tax;
    }
}
