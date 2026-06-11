namespace DesignPatterns.Course._03_Behavioral._11_Memento;

public class Originator
{
    private string _state;

    public string State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine($"Current video state: {_state}");
        }
    }

    public Snapshot CreateSnapshot()
    {
        return new Snapshot(_state);
    }

    public void Restore(Snapshot snapshot)
    {
        Console.WriteLine("Restoring state...");
        State = snapshot.GetState();
    }
}
