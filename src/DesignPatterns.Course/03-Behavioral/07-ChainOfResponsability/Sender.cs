using DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability.Receivers;

namespace DesignPatterns.Course._03_Behavioral._07_ChainOfResponsability;

public class Sender
{
    public void PerformCheckout()
    {
        Checkout checkout = new Checkout(1001, 20, 23.50);

        Console.WriteLine($"\nBefore:\nTotal checkout value: {checkout.TotalValue.ToString("C")}");
        Console.WriteLine(new string('-', 40));

        var laundry = new LaundryServiceReceiver();
        var roomService = new RoomServiceReceiver();
        var cleaning = new CleaningServiceReceiver();

        laundry.AddNext(roomService);
        roomService.AddNext(cleaning);

        laundry.ExecuteServiceBilling(checkout);

        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"\nAfter:\nTotal checkout value: {checkout.TotalValue.ToString("C")}");
    }
}
