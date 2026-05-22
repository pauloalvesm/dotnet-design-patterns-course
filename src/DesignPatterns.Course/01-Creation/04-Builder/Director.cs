using DesignPatterns.Course._01_Creation._04_Builder.Builders;

namespace DesignPatterns.Course._01_Creation._04_Builder;

public class Director
{
    public void BuildStudio(StudioBuilder studioBuilder)
    {
        studioBuilder.ChooseFlooring();
        studioBuilder.SetStudioValue();
        studioBuilder.ChooseFinancing();
    }
}
