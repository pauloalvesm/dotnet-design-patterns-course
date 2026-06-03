namespace DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Weaknesses;

public class Strength : IWeakness
{
    public void Interpret(Context context)
    {
        context.Content += "[-] - Lack of Strength\n";
    }
}
