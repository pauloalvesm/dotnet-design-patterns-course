namespace DesignPatterns.Course._03_Behavioral._11_Memento;

public class Caretaker
{
    private Snapshot _snapshot;

    public void AddSnapshot(Snapshot snapshot)
    {
        _snapshot = snapshot;
    }

    public Snapshot GetSnapshot()
    {
        return _snapshot;
    }
}
