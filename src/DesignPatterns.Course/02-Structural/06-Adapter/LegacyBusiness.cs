namespace DesignPatterns.Course._02_Structural._06_Adapter;

public class LegacyBusiness
{
    public string ExecuteAccountsPayableRoutine(string month)
    {
        var result = SqlAccess.GetPayableData(month);
        var time = 3000;

        Console.WriteLine("\nProcessing accounts payable business rules...");
        Thread.Sleep(time);

        return result;
    }

    public string ExecuteAccountsReceivableRoutine(string month)
    {
        var result = SqlAccess.GetReceivableData(month);
        var time = 3000;

        Console.WriteLine("\nProcessing accounts receivable business rules...");
        Thread.Sleep(time);

        return result;
    }
}

public class SqlAccess
{
    public static string GetPayableData(string month)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic.Add("june", "june\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");
        dic.Add("july", "july\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");
        dic.Add("august", "august\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");
        dic.Add("september", "september\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");
        dic.Add("october", "october\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");

        return dic[month.ToLower()];
    }

    public static string GetReceivableData(string month)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic.Add("june", "june\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");
        dic.Add("july", "july\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");
        dic.Add("august", "august\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");
        dic.Add("september", "september\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");
        dic.Add("october", "october\nEIN/TaxID:32643030000102\nCompany name: Lojas Prudente\nValue: 1200.00\nContact: (11) 1232-2333");

        return dic[month.ToLower()];
    }
}
