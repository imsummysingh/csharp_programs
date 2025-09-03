//create the delegate
public delegate void LogMsg(string message);

public class Logger
{
    public void LogConsole(string msg)
    {
        Console.WriteLine("Console Log Message: {0}", msg);
    }

    public void LogFile(string msg) 
    {
        Console.WriteLine($"File Log Message: {msg}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Logger log = new Logger();

        //create reference of the delegate type
        //starting with empty deleagate
        LogMsg logmsg = null;

        //adding first delegate
        logmsg += log.LogConsole;

        //adding second delegate
        logmsg += log.LogFile;

        //the message will be passed to both the methods
        logmsg("This is the message inserted into delegate");

        Console.WriteLine("Removing the delegate");

        //remove both the delegate
        logmsg -= log.LogConsole;

        logmsg("Unsubscribed the first method");

    }
}

/*
Console Log Message: This is the message inserted into delegate
File Log Message: This is the message inserted into delegate
Removing the delegate
File Log Message: Unsubscribed the first method
 */