using DesignPatterns.Course._02_Structural._06_Adapter.Interfaces;

namespace DesignPatterns.Course._02_Structural._06_Adapter;

public class CloudComputing
{
    private IAdapter _adapter;

    public CloudComputing()
    {
        _adapter = new Adapter(new LegacyBusiness());
    }

    public void ProcessAccounts(string month)
    {
        var time = 3000;

        var result = _adapter.ExecuteAccountsPayableRoutine(month);
        Console.WriteLine("Processing cloud computing layer for accounts payable...");
        Console.WriteLine(result);
        Thread.Sleep(time);

        Console.WriteLine(new string('-', 40));

        result = _adapter.ExecuteAccountsReceivableRoutine(month);
        Console.WriteLine("Processing cloud computing layer for accounts receivable...");
        Console.WriteLine(result);
        Thread.Sleep(time);

        Console.WriteLine("\nProcess successfully completed!");
    }
}
