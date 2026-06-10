using DesignPatterns.Course._03_Behavioral._10_State.States;

namespace DesignPatterns.Course._03_Behavioral._10_State;

public class Client
{
    public void ExecuteContext()
    {
        Context context = new Context(new StateA());

        context.Request();
        context.Request();
    }
}
