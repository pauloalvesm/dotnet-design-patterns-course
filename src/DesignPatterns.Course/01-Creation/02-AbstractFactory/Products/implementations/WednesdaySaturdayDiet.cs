using DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.Interfaces;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory.Products.implementations;

public class WednesdaySaturdayDiet : IDiet
{
    public WednesdaySaturdayDiet()
    {
        this.GetNutrition();
    }

    public void GetNutrition()
    {
        Console.WriteLine("Wednesday to Saturday Diet...");
    }
}
