using DesignPatterns.Course._03_Behavioral._04_Visitor.Products;

namespace DesignPatterns.Course._03_Behavioral._04_Visitor.Interfaces;

public interface IVisitor
{
    double CalculatePerishableProductTax(PerishableProduct perishableProduct);
    double CalculateNonPerishableProductTax(NonPerishableProduct nonPerishableProduct);
}