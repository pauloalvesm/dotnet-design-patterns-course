using DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability.AbstractModel;

namespace DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability.Receivers;

public class RoomServiceReceiver : BillingReceiver
{
    public override Checkout ExecuteServiceBilling(Checkout checkout)
    {
        Console.WriteLine("Charging room service fee...");
        checkout.TotalValue += (checkout.TotalValue * 0.03);

        return base.ExecuteServiceBilling(checkout);
    }
}