namespace DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Strengths;

public class Zoology : IStrength
{
    public void Interpret(Context context)
    {
        context.Content += "[+] - Zoology Expert\n";
    }
}
