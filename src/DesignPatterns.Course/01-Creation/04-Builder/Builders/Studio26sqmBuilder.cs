using DesignPatterns.Course._01_Creation._04_Builder.Studios;

namespace DesignPatterns.Course._01_Creation._04_Builder.Builders;

public class Studio26sqmBuilder : StudioBuilder
{
    public Studio26sqmBuilder()
    {
        studio = new Studio26sqm();
    }

    public override void SetStudioValue()
    {
        studio.SetStudioValue(190000.00m);
    }

    public override void ChooseFinancing()
    {
        studio.ChooseFinancing("Investi Fácil");
    }

    public override void ChooseFlooring()
    {
        studio.ChooseFlooring("Ceramic");
    }
}
