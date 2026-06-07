using DesignPatterns.Course._03_Behavioral._06_Strategy.Interfaces;
using DesignPatterns.Course._03_Behavioral._06_Strategy.Models;

namespace DesignPatterns.Course._03_Behavioral._06_Strategy.Services;

public class PenthouseService : IService
{
    private readonly Budget _budget;

    public PenthouseService(Budget budget)
    {
        _budget = budget;
    }

    public void CalculateService()
    {
        var percentageValue = _budget.TotalValue * ((double)_budget.Percentage / 100);
        _budget.TotalValue += percentageValue;

        if (_budget.Quantity > 60)
        {
            Console.WriteLine($"\nValue without discount: {_budget.TotalValue.ToString("C")}");
            _budget.TotalValue -= _budget.TotalValue * 0.03;
            Console.WriteLine("Bill over 60 days receives 3% discount for penthouse.\n");
        }

        Console.WriteLine($"Room Type: {_budget.Percentage}\nService Fee: {percentageValue.ToString("C")}\nDays Qty: {_budget.Quantity}\nDaily Rate: {_budget.DailyRate}\n*Total Value: {_budget.TotalValue}");
    }
}
