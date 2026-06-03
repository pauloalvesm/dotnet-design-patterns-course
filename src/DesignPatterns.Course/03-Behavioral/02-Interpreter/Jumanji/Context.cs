namespace DesignPatterns.Course._03_Behavioral._02_Interpreter.Jumanji;

public class Context
{
    public string Character { get; set; }
    public string Content { get; set; }

    public Context(string character)
    {
        Character = character;
        this.Content = string.Empty;
    }
}