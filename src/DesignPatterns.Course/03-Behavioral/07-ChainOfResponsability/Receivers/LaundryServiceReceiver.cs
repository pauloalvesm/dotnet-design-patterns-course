using DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability.AbstractModel;

namespace DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability.Receivers;

public class LaundryServiceReceiver : BillingReceiver
{
    public override Checkout ExecuteServiceBilling(Checkout checkout)
    {
        Console.WriteLine("Charging laundry service fee...");
        checkout.TotalValue += (checkout.TotalValue * 0.028);

        return base.ExecuteServiceBilling(checkout);
    }
}
