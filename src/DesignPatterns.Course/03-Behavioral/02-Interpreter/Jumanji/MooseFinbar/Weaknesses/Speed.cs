namespace DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Weaknesses;

public class Speed : IWeakness
{
    public void Interpret(Context context)
    {
        context.Content += "[-] - Lack of Speed\n";
    }
}
