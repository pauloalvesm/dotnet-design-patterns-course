using DesignPatterns.Course._03_Behavioral._04_Visitor.Interfaces;
using DesignPatterns.Course._03_Behavioral._04_Visitor.Products;

namespace DesignPatterns.Course._03_Behavioral._04_Visitor.Visitors;

public class SaoPauloVisitor : IVisitor
{
    public double CalculateNonPerishableProductTax(NonPerishableProduct nonPerishableProduct)
    {
        var tax = (nonPerishableProduct.Weight / 100) + 7;

        Console.WriteLine($"São Paulo Tax: {tax}");

        return tax;
    }

    public double CalculatePerishableProductTax(PerishableProduct perishableProduct)
    {
        var tax = (perishableProduct.Weight / 100) + 12;

        Console.WriteLine($"São Paulo Tax: {tax}");

        return tax;
    }
}
