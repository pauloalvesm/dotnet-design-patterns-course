using DesignPatterns.Course._03_Behavioral._05_Command.Interfaces;
using DesignPatterns.Course._03_Behavioral._05_Command.Receivers;

namespace DesignPatterns.Course._03_Behavioral._05_Command.Commands;

public class TurnOnLampCommand : ICommand
{
    private readonly LampLightReceiver _lampLightReceiver;

    public TurnOnLampCommand(LampLightReceiver lampLightReceiver)
    {
        _lampLightReceiver = lampLightReceiver;
    }

    public void Execute()
    {
        _lampLightReceiver.TurnOnLight();
    }
}
