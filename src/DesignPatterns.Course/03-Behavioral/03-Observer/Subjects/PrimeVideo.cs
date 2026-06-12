using DesignPatterns.Course._03_Behavioral._03_Observer.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._03_Observer.Subjects;

public class PrimeVideo : ISubject
{
    public List<IObserver> Observers { get; set; }

    public PrimeVideo()
    {
        Observers = new List<IObserver>();
    }

    public void AddObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in Observers)
        {
            observer.Update();
            Console.WriteLine(new string('-', 50));
        }
    }
}