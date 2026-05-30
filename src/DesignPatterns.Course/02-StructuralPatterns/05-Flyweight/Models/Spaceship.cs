namespace DesignPatterns.Course._02_StructuralPatterns._05_Flyweight.Models;

public abstract class Spaceship
{
    protected string condition;
    protected string action;

    public string Color { get; set; }
    public string Size { get; set; }

    public abstract void Display(string color, string size);
}