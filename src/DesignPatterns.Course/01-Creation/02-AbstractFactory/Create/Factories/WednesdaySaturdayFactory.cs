using DesignPatterns.Course._01_Creation._02_AbstractFactory.Create.Interfaces;
using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Create.Factories;

public class WednesdaySaturdayFactory : IFactory
{
    public WednesdaySaturdayFactory()
    {
        this.GetDailyRoutine();
    }

    public void GetDailyRoutine()
    {
        Console.WriteLine("Wednesday and Saturday Factory Created.");
        var diet = new WednesdaySaturdayDiet();
        var workout = new WednesdaySaturdayWorkout();

        diet.GetNutrition();
        workout.GetWorkout();
    }
}
