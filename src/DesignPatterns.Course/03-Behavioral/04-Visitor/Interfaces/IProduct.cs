namespace DesignPatterns.Course._03_Behavioral._04_Visitor.Interfaces;

public interface IProduct
{
    string Name { get; set; }
    double Weight { get; set; }

    double GetTax(IVisitor visitor);
}
