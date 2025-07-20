namespace FacadePattern;

public class HomeTheaterFacade
{
    private readonly UnderSystem.TV _tv;
    private readonly UnderSystem.SoundSystem _soundSystem;
    private readonly UnderSystem.StreamingService _streamingService;

    public HomeTheaterFacade(UnderSystem.TV tv,
                             UnderSystem.SoundSystem soundSystem,
                             UnderSystem.StreamingService streamingService)
    {
        _tv = tv;
        _soundSystem = soundSystem;
        _streamingService = streamingService;
    }

    public void WatchMovie()
    {
        _tv.On();
        _soundSystem.On();
        _streamingService.Start();
        Console.WriteLine("Film izləməyə hazırsan! 🍿");
    }
}