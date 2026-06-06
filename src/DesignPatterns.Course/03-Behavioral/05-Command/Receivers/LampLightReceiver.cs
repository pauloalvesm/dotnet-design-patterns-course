namespace DesignPatterns.Course._03_Behavioral._05_Command.Receivers;

public class LampLightReceiver
{
    private bool _isOn = false;
    private int _intensity = 100;

    public string GetLampState() => _isOn ? "On" : "Off";

    public void TurnOnLight()
    {
        if (_isOn)
        {
            Console.WriteLine("The light is already on.");
        }
        else
        {
            _isOn = !_isOn;
            Console.WriteLine($"The light was turned {GetLampState()}");
        }
    }

    public void TurnOffLight()
    {
        if (!_isOn)
        {
            Console.WriteLine("The light is already off.");
        }
        else
        {
            _isOn = !_isOn;
            Console.WriteLine($"The light was turned {GetLampState()}");
        }
    }

    public void IncreaseIntensity()
    {
        if (_intensity >= 0 && _intensity < 100)
        {
            _intensity += 20;
            Console.WriteLine($"Intensity was increased to {_intensity}%");
        }
        else
        {
            Console.WriteLine($"Intensity is already at {_intensity}%");
        }
    }

    public void DecreaseIntensity()
    {
        if (_intensity > 0 && _intensity <= 100)
        {
            _intensity -= 20;
            Console.WriteLine($"Intensity was decreased to {_intensity}%");
        }
        else
        {
            Console.WriteLine($"Intensity is already at {_intensity}%");
        }
    }
}
