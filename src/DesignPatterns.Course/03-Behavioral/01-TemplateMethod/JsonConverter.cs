using DesignPatterns.Course._03_Behavioral._01_TemplateMethod.AbstractModel;
using DesignPatterns.Course._03_Behavioral._01_TemplateMethod.Models;
using Newtonsoft.Json;

namespace DesignPatterns.Course._03_Behavioral._01_TemplateMethod;

public class JsonConverter : DataProcessor
{
    public JsonConverter(string json) : base(json: json) { }

    public override void ProcessJson()
    {
        this.people = JsonConvert.DeserializeObject<List<Person>>(this.json);
        this.DisplayValues();
    }
}
