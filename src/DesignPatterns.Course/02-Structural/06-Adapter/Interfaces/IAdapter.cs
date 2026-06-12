namespace DesignPatterns.Course._02_Structural._06_Adapter.Interfaces;

public interface IAdapter
{
    string ExecuteAccountsPayableRoutine(string month);
    string ExecuteAccountsReceivableRoutine(string month);
}
