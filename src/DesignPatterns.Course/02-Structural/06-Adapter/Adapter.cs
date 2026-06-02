using DesignPatterns.Course._02_Structural._06_Adapter.Interfaces;

namespace DesignPatterns.Course._02_Structural._06_Adapter;

public class Adapter : IAdapter
{
    private LegacyBusiness _legacy;

    public Adapter(LegacyBusiness legacy)
    {
        _legacy = legacy;
    }

    public string ExecuteAccountsPayableRoutine(string month)
    {
        return _legacy.ExecuteAccountsPayableRoutine(month);
    }

    public string ExecuteAccountsReceivableRoutine(string month)
    {
        return _legacy.ExecuteAccountsReceivableRoutine(month);
    }
}
