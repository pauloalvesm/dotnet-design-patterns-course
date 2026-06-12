namespace DesignPatterns.Course._03_Behavioral._09_Mediator.AbstractModel;

public abstract class Mediator
{
    public abstract void Send(string message, Contact contact);
}
