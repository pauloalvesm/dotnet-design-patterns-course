namespace DesignPatterns.Course._02_Structural._05_Flyweight;

public class Client
{
    private List<string> _colorsAndSizes = new List<string>
        {
            "blue:small", "gray:medium", "red:large",
            "blue:small", "gray:medium", "red:large",
            "blue:small", "gray:medium", "red:large"
        };

    public void ConsumeFlyweight()
    {
        var factory = new FlyweightFactory();

        foreach (var item in _colorsAndSizes)
        {
            var color = item.Split(":")[0];
            var size = item.Split(":")[1];
            var spaceship = factory.GetSpaceship(color);
            spaceship.Display(color, size);
        }
    }
}
