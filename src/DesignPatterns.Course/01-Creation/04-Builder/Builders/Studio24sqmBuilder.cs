using DesignPatterns.Course._01_Creation._04_Builder.Studios;

namespace DesignPatterns.Course._01_Creation._04_Builder.Builders;

public class Studio24sqmBuilder : StudioBuilder
{
    public Studio24sqmBuilder()
    {
        studio = new Studio24sqm();
    }

    public override void SetStudioValue()
    {
        studio.SetStudioValue(180000.00M);
    }

    public override void ChooseFinancing()
    {
        studio.ChooseFinancing("FinaModelFinanciamentos");
    }

    public override void ChooseFlooring()
    {
        studio.ChooseFlooring("Ceramic");
    }
}