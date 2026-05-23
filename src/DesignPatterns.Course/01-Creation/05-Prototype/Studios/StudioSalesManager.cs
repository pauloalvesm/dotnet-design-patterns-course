using DesignPatterns.Course._01_Creation._05_Prototype.Models;

namespace DesignPatterns.Course._01_Creation._05_Prototype.Studios;

public class StudioSalesManager
{
    private Dictionary<string, StudioModel> _studioModels = new Dictionary<string, StudioModel>();

    public StudioModel this[string key]
    {
        get { return _studioModels[key]; }
        set { _studioModels[key] = value; }
    }
}
