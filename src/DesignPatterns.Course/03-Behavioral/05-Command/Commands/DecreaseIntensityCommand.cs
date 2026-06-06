using DesignPatterns.Course._03_Behavioral._05_Command.Interfaces;
using DesignPatterns.Course._03_Behavioral._05_Command.Receivers;

namespace DesignPatterns.Course._03_Behavioral._05_Command.Commands;

public class DecreaseIntensityCommand : ICommand
{
    private readonly LampLightReceiver _lampLightReceiver;

    public DecreaseIntensityCommand(LampLightReceiver lampLightReceiver)
    {
        _lampLightReceiver = lampLightReceiver;
    }

    public void Execute()
    {
        _lampLightReceiver.DecreaseIntensity();
    }
}