namespace DesignPatterns.Course._03_Behavioral._01_TemplateMethod;

public class Client
{
    public void ConsumeXmlEndpoint()
    {
        Console.WriteLine("\n____________XML____________\n");

        var xml = ApiDataFetcher.EndpointXml();
        XmlConverter xmlConverter = new XmlConverter(xml);

        xmlConverter.ProcessXml();
    }

    public void ConsumeJsonEndpoint()
    {
        Console.WriteLine("\n____________JSON____________\n");

        var json = ApiDataFetcher.EndpointJson();
        JsonConverter jsonConverter = new JsonConverter(json);

        jsonConverter.ProcessJson();
    }
}