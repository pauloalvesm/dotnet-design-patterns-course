using DesignPatterns.Course._03_Behavioral._01_TemplateMethod.AbstractModel;
using DesignPatterns.Course._03_Behavioral._01_TemplateMethod.Models;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.Course._03_Behavioral._01_TemplateMethod;

public class XmlConverter : DataProcessor
{
    public XmlConverter(string xml) : base(xml: xml) { }

    public override void ProcessXml()
    {
        XmlSerializer serializer = new XmlSerializer(this.people.GetType());
        var stringReader = new StringReader(this.xml);

        using (var reader = XmlReader.Create(stringReader))
        {
            this.people = (List<Person>)serializer.Deserialize(reader);
        }

        this.DisplayValues();
    }
}
