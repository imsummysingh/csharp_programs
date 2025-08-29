public class AppConfig
{
    //static field
    public static readonly string FilePath;

    //static constructor to initialize the static field
    static AppConfig() 
    {
        Console.WriteLine("Inside the Static constructor.");

        FilePath = "C:\\AppConfig\\config.json";
    }

    public static void LogMessage(string message)
    {
        Console.WriteLine($"Logging to {FilePath} : {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AppConfig.LogMessage("Hello");
    }
}