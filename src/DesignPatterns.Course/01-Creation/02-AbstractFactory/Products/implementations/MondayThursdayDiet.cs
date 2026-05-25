using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.Interfaces;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

public class MondayThursdayDiet : IDiet
{
    public MondayThursdayDiet()
    {
        this.GetNutrition();
    }

    public void GetNutrition()
    {
        Console.WriteLine("Monday and Thursday Diet...");
    }
}
