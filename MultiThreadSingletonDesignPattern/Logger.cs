namespace MultiThreadSingletonDesignPattern;

public class Logger
{
    private static Logger? _instance;
    private static readonly Lock Lock = new Lock();

    private Logger() { }

    public static Logger? GetInstance()
    {
        if (_instance != null) return _instance;
        
        lock (Lock)
        {
            _instance ??= new Logger();
        }
        
        return _instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss}] {message}");
    }
}