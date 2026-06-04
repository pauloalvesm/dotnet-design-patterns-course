using DesignPatterns.Course._03_Behavioral._03_Observer.Interfaces;
using DesignPatterns.Course._03_Behavioral._03_Observer.Models;
using DesignPatterns.Course._03_Behavioral._03_Observer.Observers;
using DesignPatterns.Course._03_Behavioral._03_Observer.Subjects;
using System.Globalization;

namespace DesignPatterns.Course._03_Behavioral._03_Observer;

public class EmailSender
{
    public void SendEmails()
    {
        string currentMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month);

        string nonSubscriberMsg = $"We noticed you are not yet part of the largest and best series and movies platform! Don't miss out on our {currentMonth} promotions and access our platform to check the latest releases.";

        string subscriberMsg = $"New releases for {currentMonth} straight from the cinema to your screen.";

        List<IObserver> observers = new List<IObserver>()
            {
                new NonSubscriber(new Person(1, "José", "jose@gmail.com"), nonSubscriberMsg),
                new NonSubscriber(new Person(2, "Maria", "maria@gmail.com"), nonSubscriberMsg),
                new Subscriber(new Person(3, "João", "joao@gmail.com"), subscriberMsg),
                new Subscriber(new Person(4, "Marta", "marta@gmail.com"), subscriberMsg)
            };

        PrimeVideo primeVideo = new PrimeVideo();

        foreach (var observer in observers)
        {
            primeVideo.AddObserver(observer);
        }

        primeVideo.NotifyObservers();
    }
}
