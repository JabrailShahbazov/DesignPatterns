namespace FacadePattern;

public class UnderSystem
{
    public class TV { public void On() => Console.WriteLine("TV açıldı."); }
    public class SoundSystem { public void On() => Console.WriteLine("Səs sistemi qoşuldu."); }
    public class StreamingService { public void Start() => Console.WriteLine("Netflix açıldı."); }
}