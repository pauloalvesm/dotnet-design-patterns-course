using DesignPatterns.Course._02_Structural._03_Facade.ComplexEnvironment;

namespace DesignPatterns.Course._02_Structural._03_Facade;

public class FacadeManager
{
    public void ExecuteComplexity()
    {
        var northZone = new NorthZone();
        var southZone = new SouthZone();
        var cloud = new CloudComputing();

        var south = southZone.ExecuteLostSalesRoutine(DateTime.Now);
        var north = northZone.ExecuteLostSalesRoutine(DateTime.Now);

        cloud.GenerateProfitAndLossReport(south, north);
    }
}
