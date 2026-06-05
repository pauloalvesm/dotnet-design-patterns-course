using DesignPatterns.Course._03_Behavioral._04_Visitor.Interfaces;
using DesignPatterns.Course._03_Behavioral._04_Visitor.Products;
using DesignPatterns.Course._03_Behavioral._04_Visitor.Visitors;

namespace DesignPatterns.Course._03_Behavioral._04_Visitor;

public class TaxInspector
{
    public void CalculateTaxes()
    {
        CalculatePerishableProducts();
        Console.WriteLine(new string('-', 40));
        CalculateNonPerishableProducts();
    }

    private static void CalculatePerishableProducts()
    {
        List<PerishableProduct> perishableProducts = new List<PerishableProduct>()
            {
                new PerishableProduct("Spices", 2500),
                new PerishableProduct("Fruit pulps", 2000)
            };

        Console.WriteLine("\nCalculating tax for perishable products:\n");

        foreach (var pp in perishableProducts)
        {
            Console.WriteLine($"Product: {pp.Name}\nWeight: {pp.Weight}");

            foreach (var visitor in GetVisitors())
            {
                visitor.CalculatePerishableProductTax(pp);
            }
            Console.WriteLine();
        }
    }

    private static void CalculateNonPerishableProducts()
    {
        List<NonPerishableProduct> nonPerishableProducts = new List<NonPerishableProduct>()
            {
                new NonPerishableProduct("Wi-Fi antenna", 500),
                new NonPerishableProduct("French perfume", 1000)
            };

        Console.WriteLine("\nCalculating tax for NON-perishable products:\n");

        foreach (var pnp in nonPerishableProducts)
        {
            Console.WriteLine($"Product: {pnp.Name}\nWeight: {pnp.Weight}");

            foreach (var visitor in GetVisitors())
            {
                visitor.CalculateNonPerishableProductTax(pnp);
            }
            Console.WriteLine();
        }
    }

    private static List<IVisitor> GetVisitors() => new List<IVisitor>()
        {
            new RioDeJaneiroVisitor(), new SaoPauloVisitor()
        };
}
