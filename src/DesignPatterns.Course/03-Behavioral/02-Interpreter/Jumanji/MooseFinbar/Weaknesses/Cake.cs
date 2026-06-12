namespace DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Weaknesses;

public class Cake : IWeakness
{
    public void Interpret(Context context)
    {
        context.Content += "[-] - Lethal Cake Allergy\n";
    }
}
