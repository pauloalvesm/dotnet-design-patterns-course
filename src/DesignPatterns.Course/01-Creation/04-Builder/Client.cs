using DesignPatterns.Course._01_Creation._04_Builder.Builders;
using DesignPatterns.Course._01_Creation._04_Builder.Studios;

namespace DesignPatterns.Course._01_Creation._04_Builder;

public class Client
{
    public void ConsumeStudioData()
    {
        Director director = new Director();
        StudioBuilder studioBuilder;
        Studio studio;

        studioBuilder = new Studio24sqmBuilder();
        director.BuildStudio(studioBuilder);
        studio = studioBuilder.GetStudio();
        PrintResult(studio, "24sqm1");

        studioBuilder = new Studio26sqmBuilder();
        director.BuildStudio(studioBuilder);
        studio = studioBuilder.GetStudio();
        PrintResult(studio, "26sqm1");

        studioBuilder = new Studio28sqmBuilder();
        director.BuildStudio(studioBuilder);
        studio = studioBuilder.GetStudio();
        PrintResult(studio, "28sqm1");
    }

    private void PrintResult(Studio studio, string name)
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"[+] - Studio {name}");
        Console.WriteLine("Value: {0}\nFlooring: {1}\nFinancing: {2}",
            studio.StudioValue.ToString("C"),
            studio.FlooringType,
            studio.FinancingType);
    }
}