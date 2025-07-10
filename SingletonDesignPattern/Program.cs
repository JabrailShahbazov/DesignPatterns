using SingletonDesignPattern;

var logger1 = Logger.GetInstance();
var logger2 = Logger.GetInstance();

logger1.Log("System started.");
logger2.Log("User logged in.");

Console.WriteLine(logger1 == logger2 ? "✅ Singleton işləyir" : "❌ Singleton işləmir");