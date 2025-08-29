public class User
{
    //instance field
    private string _username;
    private string _email;
    private bool _isActive;

    //chaining this constructor to the master constructor, which is below with this()
    public User(string username, string email) : this(username, email, true)
    {
        Console.WriteLine("Two parameter constructor called.");
    }

    public User(string username, string email, bool isActive)
    {
        _username = username;
        _email = email;
        _isActive = isActive;
        Console.WriteLine("Three parameter constructor called.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        User user = new User("summy", "summy@gmail.com");
    }
}


/*
 * 
 * This call matches the first constructor. It will execute, then immediately 
 * chain to the master constructor before its own body runs.

Three parameter constructor called.
Two parameter constructor called.
 */