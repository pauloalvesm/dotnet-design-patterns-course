namespace DesignPatterns.Course._02_Structural._03_Facade.ComplexEnvironment;

public class SouthZone
{
    public List<object> ExecuteLostSalesRoutine(DateTime period)
    {
        Console.WriteLine("[-] - Executing complex lost sales routine for the South region");
        return new List<object>();
    }
}
