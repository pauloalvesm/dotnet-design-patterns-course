namespace DesignPatterns.Course._03_Behavioral._09_Mediator.AbstractModel;

public abstract class Contact
{
    protected Mediator Mediator;

    protected Contact(Mediator mediator)
    {
        Mediator = mediator;
    }
}
