namespace DesignPatterns.Course._02_Structural._03_Facade.ComplexEnvironment;

public class NorthZone
{
    public List<object> ExecuteLostSalesRoutine(DateTime period)
    {
        Console.WriteLine("[-] - Executing complex lost sales routine for the North region");
        return new List<object>();
    }
}
