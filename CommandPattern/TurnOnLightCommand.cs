namespace CommandPattern;

public class TurnOnLightCommand : ICommand
{
    private readonly Light _light;

    public TurnOnLightCommand(Light light) =>
        _light = light;

    public void Execute() =>
        _light.TurnOn();
}