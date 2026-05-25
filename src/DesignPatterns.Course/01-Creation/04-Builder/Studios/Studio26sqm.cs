namespace DesignPatterns.Course._01_Creation._04_Builder.Studios;

public class Studio26sqm : Studio
{
    public override void SetStudioValue(decimal value)
    {
        StudioValue = value;
    }

    public override void ChooseFinancing(string financing)
    {
        FinancingType = financing;
    }

    public override void ChooseFlooring(string flooring)
    {
        FlooringType = flooring;
    }
}