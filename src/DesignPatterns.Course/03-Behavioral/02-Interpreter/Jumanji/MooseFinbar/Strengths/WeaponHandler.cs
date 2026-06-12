namespace DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Strengths;

public class WeaponHandler : IStrength
{
    public void Interpret(Context context)
    {
        context.Content += "[+] - Weapon Handling\n";
    }
}