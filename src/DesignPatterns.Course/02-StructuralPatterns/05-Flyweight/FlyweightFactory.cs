using DesignPatterns.Course._02_StructuralPatterns._05_Flyweight.Flyweights;
using DesignPatterns.Course._02_StructuralPatterns._05_Flyweight.Models;

namespace DesignPatterns.Course._02_StructuralPatterns._05_Flyweight;

public class FlyweightFactory
{
    private Dictionary<string, Spaceship> _spaceships = new Dictionary<string, Spaceship>();

    public Spaceship GetSpaceship(string color)
    {
        Spaceship spaceship = null;

        if (_spaceships.ContainsKey(color))
        {
            spaceship = _spaceships[color];
        }
        else
        {
            switch (color)
            {
                case "blue":
                    spaceship = new Blue();
                    break;
                case "gray":
                    spaceship = new Gray();
                    break;
                case "red":
                    spaceship = new Red();
                    break;
                default:
                    break;
            }

            _spaceships.Add(color, spaceship);
        }

        return spaceship;
    }
}
