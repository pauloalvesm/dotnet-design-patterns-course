using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.Interfaces;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

public class TuesdayFridayWorkout : IWorkout
{
    public TuesdayFridayWorkout()
    {
        this.GetWorkout();
    }

    public void GetWorkout()
    {
        Console.WriteLine("Tuesday and Friday Workout...");
    }
}
