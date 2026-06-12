using DesignPatterns.Course._03_Behavioral._05_Command.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._05_Command;

public class ControlInvoker
{
    private readonly Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

    public void AddCommand(string key, ICommand command)
    {
        _commands.Add(key, command);
    }

    public void ExecuteCommand(string key)
    {
        if (!_commands.ContainsKey(key))
        {
            Console.WriteLine("Command does not exist");
        }
        else
        {
            _commands[key].Execute();
        }
    }
}
