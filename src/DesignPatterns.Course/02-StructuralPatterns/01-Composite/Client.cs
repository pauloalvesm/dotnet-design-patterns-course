using DesignPatterns.Course._02_StructuralPatterns._01_Composite.Models;
using DesignPatterns.Course._02_StructuralPatterns._01_Composite.Products;

namespace DesignPatterns.Course._02_StructuralPatterns._01_Composite;

public class Client
{
    public void Checkout()
    {
        ComponentModel product01 = new ProductLeaf("Batman Mug", 25.00);
        ComponentModel product02 = new ProductLeaf("Star Wars T-Shirt", 80.00);
        ComponentModel product03 = new ProductLeaf("Avengers Keychain", 10.00);

        ComponentModel product04 = new ProductLeaf("Thanos Statue", 500.00);

        ComponentModel smallBox = new ProductComposite();
        smallBox.Add(product01, product02, product03);

        ComponentModel bigBox = new ProductComposite();
        bigBox.Add(smallBox, product04);

        var totalValue = bigBox.Operation();

        Console.WriteLine($"\nTotal Value: {totalValue.ToString("C")}");
    }
}
