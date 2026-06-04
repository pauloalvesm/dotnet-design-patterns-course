namespace DesignPatterns.Course._03_Behavioral._03_Observer.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Person(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}
