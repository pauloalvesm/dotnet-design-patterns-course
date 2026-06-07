using DesignPatterns.Course._03_Behavioral._06_Strategy.Enums;

namespace DesignPatterns.Course._03_Behavioral._06_Strategy.Models;

public class Budget
{
    public int CustomerId { get; set; }
    public double DailyRate { get; set; }
    public int Quantity { get; set; }
    public double TotalValue { get; set; }
    public bool DiscountCoupon { get; set; }
    public ServicePercentage Percentage { get; set; }

    public Budget(int customerId,
                  double dailyRate,
                  int quantity,
                  ServicePercentage percentage,
                  bool discountCoupon = false)
    {
        CustomerId = customerId;
        DailyRate = dailyRate;
        Quantity = quantity;
        DiscountCoupon = discountCoupon;
        Percentage = percentage;
        CalculateTotalValue();
    }

    private void CalculateTotalValue()
    {
        this.TotalValue = this.Quantity * this.DailyRate;
    }
}
