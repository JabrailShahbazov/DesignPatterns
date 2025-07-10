namespace SingletonDesignPattern;

public sealed class Logger
{
    private static Logger? _instance;
    
    private Logger(){}

    public static Logger? GetInstance()
    {
        return _instance ??= new Logger();
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}