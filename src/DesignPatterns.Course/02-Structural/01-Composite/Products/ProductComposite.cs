using DesignPatterns.Course._02_Structural._01_Composite.Models;

namespace DesignPatterns.Course._02_StructuralPatterns._01_Composite.Products;

public class ProductComposite : ComponentModel
{
    private List<ComponentModel> _components;

    public ProductComposite()
    {
        _components = new List<ComponentModel>();
    }

    public override void Add(params ComponentModel[] components)
    {
        _components.AddRange(components);
    }

    public override ComponentModel GetChild(int index)
    {
        if (_components.Count == 0)
        {
            Console.WriteLine("No registered products found.");
            return null;
        }

        return _components[index];
    }

    public override double Operation()
    {
        double totalValue = 0;

        for (int i = 0; i < _components.Count; i++)
        {
            var component = _components[i];
            var child = component.GetChild(i);
            totalValue += component.Operation();
        }

        return totalValue;
    }

    public override void Remove(ComponentModel component)
    {
        _components.Remove(component);
    }
}
