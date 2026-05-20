using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.Interfaces;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

public class TuesdayFridayDiet : IDiet
{
    public TuesdayFridayDiet()
    {
        this.GetNutrition();
    }

    public void GetNutrition()
    {
        Console.WriteLine("Tuesday and Friday Diet...");
    }
}
