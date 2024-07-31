using Singleton;

// SingletonBase singleton1 = StaticSingletonLogger.GetInstance();
// SingletonBase singleton2 = StaticSingletonLogger.GetInstance();

// SingletonBase singleton1 = ThreadSafeSingletonLogger.GetInstance();
// SingletonBase singleton2 = ThreadSafeSingletonLogger.GetInstance();

// SingletonBase singleton1 = ClassicSingletonLogger.GetInstance;
// SingletonBase singleton2 = ClassicSingletonLogger.GetInstance;

SingletonBase singleton1 = LazySingletonLogger.GetInstance();
SingletonBase singleton2 = LazySingletonLogger.GetInstance();

if (singleton1 == singleton2)
{
    Console.WriteLine("Objects are the same instance - singleton pattern works");
}

singleton1.Log("This is a log message using the singleton pattern");