using DesignPatterns.Course._01_Creation._04_Builder.Studios;

namespace DesignPatterns.Course._01_Creation._04_Builder.Builders;

public abstract class StudioBuilder
{
    protected Studio studio;

    public Studio GetStudio()
    {
        return studio;
    }

    public abstract void ChooseFlooring();
    public abstract void ChooseFinancing();
    public abstract void SetStudioValue();
}
