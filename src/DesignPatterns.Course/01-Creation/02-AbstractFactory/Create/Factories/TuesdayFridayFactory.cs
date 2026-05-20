using DesignPatterns.Course._01_Creation._02_AbstractFactory.Create.Interfaces;
using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Create.Factories;

public class TuesdayFridayFactory : IFactory
{
    public TuesdayFridayFactory()
    {
        this.GetDailyRoutine();
    }

    public void GetDailyRoutine()
    {
        Console.WriteLine("Tuesday and Friday Factory Created.");
        var diet = new TuesdayFridayDiet();
        var workout = new TuesdayFridayWorkout();

        diet.GetNutrition();
        workout.GetWorkout();
    }
}
