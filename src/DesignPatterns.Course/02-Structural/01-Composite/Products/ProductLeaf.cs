using DesignPatterns.Course._02_Structural._01_Composite.Models;

namespace DesignPatterns.Course._02_StructuralPatterns._01_Composite.Products;

public class ProductLeaf : ComponentModel
{
    private string _name;
    private double _value;

    public ProductLeaf(string name, double value)
    {
        _name = name;
        _value = value;
    }

    public override void Add(params ComponentModel[] components)
    {
        Console.WriteLine("Cannot add items to a Leaf object.");
    }

    public override ComponentModel GetChild(int index)
    {
        Console.WriteLine("Cannot get items from a Leaf object.");
        return null;
    }

    public override double Operation()
    {
        Console.WriteLine($"Product: {_name}\nValue: {_value.ToString("C")}");
        Console.WriteLine(new string('-', 40));
        return _value;
    }

    public override void Remove(ComponentModel component)
    {
        Console.WriteLine("Cannot remove items from a Leaf object.");
    }
}
