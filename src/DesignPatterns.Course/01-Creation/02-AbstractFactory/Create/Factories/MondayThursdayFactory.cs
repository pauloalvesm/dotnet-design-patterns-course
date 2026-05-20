using DesignPatterns.Course._01_Creation._02_AbstractFactory.Create.Interfaces;
using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Create.Factories;

public class MondayThursdayFactory : IFactory
{
    public MondayThursdayFactory()
    {
        this.GetDailyRoutine();
    }

    public void GetDailyRoutine()
    {
        Console.WriteLine("Monday and Thursday Factory Created.");
        var diet = new MondayThursdayDiet();
        var workout = new MondayThursdayWorkout();

        diet.GetNutrition();
        workout.GetWorkout();
    }
}
