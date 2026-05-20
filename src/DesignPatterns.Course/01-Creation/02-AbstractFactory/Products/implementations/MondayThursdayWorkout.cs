using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.Interfaces;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

public class MondayThursdayWorkout : IWorkout
{
    public MondayThursdayWorkout()
    {
        this.GetWorkout();
    }

    public void GetWorkout()
    {
        Console.WriteLine("Monday and Thursday Workout...");
    }
}
