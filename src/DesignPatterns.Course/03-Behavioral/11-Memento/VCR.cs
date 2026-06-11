namespace DesignPatterns.Course._03_Behavioral._11_Memento;

public class VCR
{
    public void ExecuteVideoAction()
    {
        Originator originator = new Originator();
        originator.State = "play";

        Caretaker caretaker = new Caretaker();
        caretaker.AddSnapshot(originator.CreateSnapshot());

        originator.State = "pause";

        originator.Restore(caretaker.GetSnapshot());
    }
}
