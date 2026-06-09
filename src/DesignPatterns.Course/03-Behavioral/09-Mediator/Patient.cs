using DesignPatterns.Course._03_Behavioral._09_Mediator.AbstractModel;

namespace DesignPatterns.Course._03_Behavioral._09_Mediator;

public class Patient : Contact
{
    public Patient(Mediator mediator) : base(mediator) { }

    public void SendMessage(string message)
    {
        Console.WriteLine("Patient typing...");
        Thread.Sleep(3000);
        this.Mediator.Send(message, this);
        Thread.Sleep(3000);
    }

    public void Notify(string message)
    {
        Console.WriteLine($"To Patient: {message}");
    }
}
