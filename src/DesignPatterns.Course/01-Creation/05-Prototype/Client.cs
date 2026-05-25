using DesignPatterns.Course._01_Creation._05_Prototype.Models;
using DesignPatterns.Course._01_Creation._05_Prototype.Studios;

namespace DesignPatterns.Course._01_Creation._05_Prototype;

public class Client
{
    public void ConsumeStudioData()
    {
        var manager = new StudioSalesManager();

        manager["24sqm"] = new Studio("24m^2", "FinaEmpreendimentos", 180000.00M);
        manager["26sqm"] = new Studio("26m^2", "Financiamnetos Imóveis Aurora", 190000.00M);
        manager["28sqm"] = new Studio("28m^2", "Imóveis Tabajara", 200000.00M);

        StudioModel firstClone01 = manager["24sqm"].Clone();
        StudioModel firstClone02 = manager["24sqm"].Clone();
        StudioModel studio26 = manager["26sqm"].Clone();
        StudioModel studio28 = manager["28sqm"].Clone();
    }
}
