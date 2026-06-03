namespace DesignPatterns.Course._03_Behavioral._01_TemplateMethod.Models;

public class Person
{
    public string Name { get; set; }
    public string CPF { get; set; }
    public List<Activity> Activities { get; set; }

    public Person()
    {
    }

    public Person(string name, string cpf, List<Activity> activities)
    {
        Name = name;
        CPF = cpf;
        Activities = activities;
    }
}
