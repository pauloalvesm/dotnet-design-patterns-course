using DesignPatterns.Course._01_Creation._05_Prototype.Models;

namespace DesignPatterns.Course._01_Creation._05_Prototype.Studios;

public class Studio : StudioModel
{
    private string _studioType;
    private string _financingType;
    private decimal _studioValue;

    public Studio(string studioType, string financingType, decimal studioValue)
    {
        _studioType = studioType;
        _financingType = financingType;
        _studioValue = studioValue;
    }

    public override StudioModel Clone()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"Cloned Studio: {_studioType}\nFinancing: {_financingType}\nValue: {_studioValue.ToString("C")}\n");
        return this.MemberwiseClone() as StudioModel;
    }
}
