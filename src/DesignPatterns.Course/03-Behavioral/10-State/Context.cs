using DesignPatterns.Course._03_Behavioral._10_State.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._10_State;

public class Context
{
    private IState _state;

    public Context(IState state)
    {
        _state = state;
    }

    public IState State
    {
        get { return _state; }
        set
        {
            _state = value;
            Console.WriteLine($"Changing to {_state.GetType().Name}");
        }
    }

    public void Request()
    {
        _state.Action(this);
    }
}