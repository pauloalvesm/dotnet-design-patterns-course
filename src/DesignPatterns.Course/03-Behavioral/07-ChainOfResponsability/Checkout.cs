namespace DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability;

public class Checkout
{
    public int CustomerId { get; set; }
    public int DaysQuantity { get; set; }
    public double DailyRate { get; set; }
    public double TotalValue { get; set; }

    public Checkout(int customerId, int daysQuantity, double dailyRate)
    {
        CustomerId = customerId;
        DaysQuantity = daysQuantity;
        DailyRate = dailyRate;
        CalculateTotal();
    }

    private void CalculateTotal()
    {
        this.TotalValue = this.DaysQuantity * this.DailyRate;
    }
}