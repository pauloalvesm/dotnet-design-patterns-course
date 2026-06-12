using DesignPatterns.Course._03_Behavioral._06_Strategy.Interfaces;
using DesignPatterns.Course._03_Behavioral._06_Strategy.Models;

namespace DesignPatterns.Course._03_Behavioral._06_Strategy.Services;

public class TraditionalService : IService
{
    private readonly Budget _budget;

    public TraditionalService(Budget budget)
    {
        _budget = budget;
    }

    public void CalculateService()
    {
        var percentageValue = _budget.TotalValue * ((double)_budget.Percentage / 100);
        _budget.TotalValue += percentageValue;

        if (_budget.DiscountCoupon)
        {
            Console.WriteLine($"\nValue without discount: {_budget.TotalValue.ToString("C")}");
            _budget.TotalValue -= _budget.TotalValue * 0.01;
            Console.WriteLine("1% discount coupon applied for traditional room.\n");
        }

        Console.WriteLine($"Room Type: {_budget.Percentage}\nService Fee: {percentageValue.ToString("C")}\nDays Qty: {_budget.Quantity}\nDaily Rate: {_budget.DailyRate}\n*Total Value: {_budget.TotalValue}");
    }
}
