using DesignPatterns.Course._03_Behavioral._09_Mediator.AbstractModel;

namespace DesignPatterns.Course._03_Behavioral._09_Mediator;

public class Attendant : Contact
{
    public Attendant(Mediator mediator) : base(mediator) { }

    public void SendMessage(string message)
    {
        Console.WriteLine("Attendant typing...");
        Thread.Sleep(3000);
        this.Mediator.Send(message, this);
        Thread.Sleep(3000);
    }

    public void Notify(string message)
    {
        Console.WriteLine($"To Attendant: {message}");
    }
}
