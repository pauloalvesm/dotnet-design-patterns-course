using DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.Interfaces;
using DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Strengths;
using DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Weaknesses;

namespace DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji;

public class Skills : IExpression
{
    private List<IStrength> _strengths;
    private List<IWeakness> _weaknesses;

    public Skills(List<IStrength> strengths, List<IWeakness> weaknesses)
    {
        _strengths = strengths;
        _weaknesses = weaknesses;
    }

    public void Interpret(Context context)
    {
        Console.WriteLine($"\nCharacter: {context.Character}");

        context.Content += "Displaying Skills...\n\nStrengths:\n";

        foreach (var strength in _strengths)
        {
            strength.Interpret(context);
        }

        context.Content += "\nWeaknesses:\n";

        foreach (var weakness in _weaknesses)
        {
            weakness.Interpret(context);
        }

        Console.WriteLine(context.Content);
    }
}
