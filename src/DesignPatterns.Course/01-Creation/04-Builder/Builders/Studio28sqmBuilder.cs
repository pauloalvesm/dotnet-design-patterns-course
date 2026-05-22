using DesignPatterns.Course._01_Creation._04_Builder.Studios;

namespace DesignPatterns.Course._01_Creation._04_Builder.Builders;

public class Studio28sqmBuilder : StudioBuilder
{
    public Studio28sqmBuilder()
    {
        studio = new Studio28sqm();
    }

    public override void SetStudioValue()
    {
        studio.SetStudioValue(200000.00m);
    }

    public override void ChooseFinancing()
    {
        studio.ChooseFinancing("FinaInvesti Imoveis");
    }

    public override void ChooseFlooring()
    {
        studio.ChooseFlooring("Vinyl Flooring");
    }
}