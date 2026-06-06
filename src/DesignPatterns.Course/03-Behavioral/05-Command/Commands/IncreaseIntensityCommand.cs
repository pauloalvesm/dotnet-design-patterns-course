using DesignPatterns.Course._03_Behavioral._05_Command.Interfaces;
using DesignPatterns.Course._03_Behavioral._05_Command.Receivers;

namespace DesignPatterns.Course._03_Behavioral._05_Command.Commands;

public class IncreaseIntensityCommand : ICommand
{
    private readonly LampLightReceiver _lampLightReceiver;

    public IncreaseIntensityCommand(LampLightReceiver lampLightReceiver)
    {
        _lampLightReceiver = lampLightReceiver;
    }

    public void Execute()
    {
        _lampLightReceiver.IncreaseIntensity();
    }
}
