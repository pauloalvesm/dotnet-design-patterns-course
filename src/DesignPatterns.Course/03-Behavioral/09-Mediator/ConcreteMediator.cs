using DesignPatterns.Course._03_Behavioral._09_Mediator.AbstractModel;

namespace DesignPatterns.Course._03_Behavioral._09_Mediator;

public class ConcreteMediator : Mediator
{
    private Attendant _attendant;
    private Patient _patient;

    public Attendant Attendant
    {
        set
        {
            _attendant = value;
        }
    }

    public Patient Patient
    {
        set
        {
            _patient = value;
        }
    }

    public override void Send(string message, Contact contact)
    {
        if (contact == _patient)
        {
            _attendant.Notify(message);
        }
        else
        {
            _patient.Notify(message);
        }
    }
}
