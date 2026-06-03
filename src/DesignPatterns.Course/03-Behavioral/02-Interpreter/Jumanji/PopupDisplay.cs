using DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Strengths;
using DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji.MooseFinbar.Weaknesses;

namespace DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji;

public class PopupDisplay
{
    public void DisplaySkillsPopup()
    {
        List<IStrength> strengths = new List<IStrength>()
        {
            new WeaponHandler(), new Zoology()
        };

        List<IWeakness> weaknesses = new List<IWeakness>()
        {
            new Cake(), new Strength(), new Speed()
        };

        var mooseFinbar = new Context("Moose Finbar");

        Skills skills = new Skills(strengths, weaknesses);
        skills.Interpret(mooseFinbar);
    }
}
