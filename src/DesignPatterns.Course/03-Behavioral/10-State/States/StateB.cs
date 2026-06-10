using DesignPatterns.Course._03_Behavioral._10_State.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._10_State.States;

public class StateB : IState
{
    public void Action(Context context)
    {
        Console.WriteLine("Executing actions for State B");
        context.State = new StateA();
    }
}
