using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.Interfaces;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

public class WednesdaySaturdayWorkout : IWorkout
{
    public WednesdaySaturdayWorkout()
    {
        this.GetWorkout();
    }

    public void GetWorkout()
    {
        Console.WriteLine("Wednesday and Saturday Workout...");
    }
}
