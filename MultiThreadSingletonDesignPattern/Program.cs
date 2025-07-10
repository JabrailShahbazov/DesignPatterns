using MultiThreadSingletonDesignPattern;

Parallel.For(1, 6, i =>
                   {
                       var logger = Logger.GetInstance();
                       
                       logger?.Log($"Task {i} işləyir | Instance Hash: {logger.GetHashCode()}");
                       
                       Thread.Sleep(500);
                       
                       logger?.Log($"Task {i} bitdi | Instance Hash: {logger.GetHashCode()}");
                   });

Console.WriteLine("✅ Bütün tasklar tamamlandı.");