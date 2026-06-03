using DesignPatterns.Course._03_Behavioral._01_TemplateMethod.Models;
using Newtonsoft.Json;
using System.Xml.Serialization;


namespace DesignPatterns.Course._03_Behavioral._01_TemplateMethod;

public class ApiDataFetcher
{
    public static string EndpointXml()
    {
        List<Person> people = GetPeople();
        XmlSerializer serializer = new XmlSerializer(people.GetType());
        string xml = string.Empty;

        using (var sw = new StringWriter())
        {
            serializer.Serialize(sw, people);
            xml = sw.ToString();
        }

        return xml;
    }

    public static string EndpointJson()
    {
        List<Person> people = GetPeople();
        var json = JsonConvert.SerializeObject(people, Formatting.Indented);

        return json;
    }

    private static List<Person> GetPeople()
    {
        return new List<Person>()
            {
                new Person()
                {
                    Name = "José",
                    CPF = "234.445.221-09",
                    Activities = new List<Activity>()
                    {
                        new Activity("AAAA3", 50, 15.44),
                        new Activity("AAAA4", 80, 22.44)
                    }
                },
                new Person()
                {
                    Name = "Magali",
                    CPF = "345.556.111-10",
                    Activities = new List<Activity>()
                    {
                        new Activity("GGGG6", 50, 15.44),
                        new Activity("TRRR3", 80, 5.44)
                    }
                }
            };
    }
}
