using DesignPatterns.Course._03_Behavioral._06_Strategy.Interfaces;
using DesignPatterns.Course._03_Behavioral._06_Strategy.Models;

namespace DesignPatterns.Course._03_Behavioral._06_Strategy.Services;

public class MasterService : IService
{
    private readonly Budget _budget;

    public MasterService(Budget budget)
    {
        _budget = budget;
    }

    public void CalculateService()
    {
        var percentageValue = _budget.TotalValue * ((double)_budget.Percentage / 100);
        _budget.TotalValue += percentageValue;

        if (_budget.DiscountCoupon && _budget.Quantity > 60)
        {
            Console.WriteLine($"\nValue without discount: {_budget.TotalValue.ToString("C")}");
            _budget.TotalValue -= _budget.TotalValue * 0.03;
            Console.WriteLine("Bill over 60 days with discount coupon receives 3% discount for Master suite.\n");
        }
        else if (_budget.DiscountCoupon)
        {
            Console.WriteLine($"\nValue without discount: {_budget.TotalValue.ToString("C")}");
            _budget.TotalValue -= _budget.TotalValue * 0.02;
            Console.WriteLine("2% discount coupon applied for Master suite.\n");
        }

        Console.WriteLine($"Room Type: {_budget.Percentage}\nService Fee: {percentageValue.ToString("C")}\nDays Qty: {_budget.Quantity}\nDaily Rate: {_budget.DailyRate}\n*Total Value: {_budget.TotalValue}");
    }
}
