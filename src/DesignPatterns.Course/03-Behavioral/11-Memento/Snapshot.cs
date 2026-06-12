namespace DesignPatterns.Course._03_Behavioral._11_Memento;

public class Snapshot
{
    private readonly string _state;

    public Snapshot(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }
}
