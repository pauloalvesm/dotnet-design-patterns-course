using DesignPatterns.Course._03_Behavioral._05_Command.Commands;
using DesignPatterns.Course._03_Behavioral._05_Command.Receivers;

namespace DesignPatterns.Course._03_Behavioral._05_Command;

public class Client
{
    public void IssueCommands()
    {
        var lamp = new LampLightReceiver();
        var control = new ControlInvoker();

        control.AddCommand("TurnOnLight", new TurnOnLampCommand(lamp));
        control.AddCommand("TurnOffLight", new TurnOffLampCommand(lamp));
        control.AddCommand("IncreaseIntensity", new IncreaseIntensityCommand(lamp));
        control.AddCommand("DecreaseIntensity", new DecreaseIntensityCommand(lamp));

        control.ExecuteCommand("TurnOnLight");

        control.ExecuteCommand("IncreaseIntensity");

        control.ExecuteCommand("DecreaseIntensity");
        control.ExecuteCommand("DecreaseIntensity");
        control.ExecuteCommand("DecreaseIntensity");
        control.ExecuteCommand("DecreaseIntensity");
        control.ExecuteCommand("DecreaseIntensity");

        control.ExecuteCommand("DecreaseIntensity");

        control.ExecuteCommand("IncreaseIntensity");
        control.ExecuteCommand("IncreaseIntensity");
        control.ExecuteCommand("IncreaseIntensity");
        control.ExecuteCommand("IncreaseIntensity");
        control.ExecuteCommand("IncreaseIntensity");

        control.ExecuteCommand("TurnOffLight");
    }
}
