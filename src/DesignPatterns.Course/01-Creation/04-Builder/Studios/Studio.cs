namespace DesignPatterns.Course._01_Creation._04_Builder.Studios;

public abstract class Studio
{
    public string FlooringType { get; protected set; }
    public string FinancingType { get; protected set; }
    public decimal StudioValue { get; protected set; }

    public abstract void ChooseFlooring(string flooring);
    public abstract void ChooseFinancing(string financing);
    public abstract void SetStudioValue(decimal value);
}
