using DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability.AbstractModel;

namespace DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability.Receivers;

public class CleaningServiceReceiver : BillingReceiver
{
    public override Checkout ExecuteServiceBilling(Checkout checkout)
    {
        Console.WriteLine("Charging cleaning service fee...");
        checkout.TotalValue += (checkout.TotalValue * 0.025);

        return base.ExecuteServiceBilling(checkout);
    }
}