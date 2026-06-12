using DesignPatterns.Course._03_Behavioral._03_Observer.Interfaces;
using DesignPatterns.Course._03_Behavioral._03_Observer.Models;

namespace DesignPatterns.Course._03_Behavioral._03_Observer.Observers;

public class NonSubscriber : IObserver
{
    public Person Person { get; set; }
    public string Message { get; set; }

    public NonSubscriber(Person person, string message)
    {
        Person = person;
        Message = message;
    }

    public void Update()
    {
        Console.WriteLine($"Sending e-mail to: {Person.Email}\n");
        Console.WriteLine($"Dear {Person.Name},\n{Message}");

        Console.WriteLine($"\nINSERT INTO TB_NOTIFICATION (PersonId, Notified, Month) VALUES ({Person.Id}, 1, {DateTime.Now.Month})\n");
    }
}
