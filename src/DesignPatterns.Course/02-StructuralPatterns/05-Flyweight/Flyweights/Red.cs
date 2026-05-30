using DesignPatterns.Course._02_StructuralPatterns._05_Flyweight.Models;

namespace DesignPatterns.Course._02_StructuralPatterns._05_Flyweight.Flyweights;

public class Red : Spaceship
{
    public Red()
    {
        this.condition = "flying in a straight line - ";
        this.action = "firing lasers";
    }

    public override void Display(string color, string size)
    {
        this.Color = color;
        this.Size = size;
        Console.WriteLine($"Spaceship {this.Size} and {this.Color} {this.condition} {this.action}");
    }
}
