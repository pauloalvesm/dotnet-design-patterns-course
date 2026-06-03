namespace DesignPatterns.Course._03_Behavioral._01_TemplateMethod.Models;

public class Activity
{
    public string Code { get; set; }
    public int Quantity { get; set; }
    public double UnitValue { get; set; }

    public Activity()
    {
    }

    public Activity(string code, int quantity, double unitValue)
    {
        Code = code;
        Quantity = quantity;
        UnitValue = unitValue;
    }
}
