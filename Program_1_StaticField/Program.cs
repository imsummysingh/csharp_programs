public class User
{
    public string name;
    public static int userCount = 0; // Static field to keep track of the number of User instances

    public User(string name)
    {
        this.name = name;
        userCount++; // Increment the static field whenever a new User is created
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Initial User Count: " + User.userCount); // Output the initial user count
        User u1 = new User("Alice");
        User u2 = new User("Bob");
        Console.WriteLine("User Count after creating two users object: " + User.userCount); // Output the user count after creating two users        
    }
}