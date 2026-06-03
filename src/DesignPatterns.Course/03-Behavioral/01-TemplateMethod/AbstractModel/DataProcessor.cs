using DesignPatterns.Course._03_Behavioral._01_TemplateMethod.Models;

namespace DesignPatterns.Course._03_Behavioral._01_TemplateMethod.AbstractModel;

public abstract class DataProcessor
{
    protected List<Person> people;
    protected string json;
    protected string xml;

    protected DataProcessor(string xml = "", string json = "")
    {
        if (!string.IsNullOrEmpty(xml))
        {
            this.xml = xml;
        }
        else if (!string.IsNullOrEmpty(json)) 
        {
            this.json = json;
        }

        this.people = new List<Person>();
    }

    public virtual void ProcessXml() { }
    public virtual void ProcessJson() { }

    protected void DisplayValues()
    {
        foreach (var person in people)
        {
            Console.WriteLine(new string('#', 40));
            Console.WriteLine($"Client: {person.Name}\n");

            double totalValue = 0;

            foreach (var activity in person.Activities)
            {
                Console.WriteLine(new string('-', 30));
                totalValue += activity.UnitValue * activity.Quantity;
                Console.WriteLine($"Code: {activity.Code}\nUnit Value: {activity.UnitValue.ToString("C")}\nQuantity: {activity.Quantity}\nTotal Value: {totalValue.ToString("C")}");
            }
        }
    }
}