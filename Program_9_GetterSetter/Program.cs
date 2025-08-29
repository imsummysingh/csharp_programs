public class User
{
    private string _name;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Name cannot be empty.");
            }
            else
            {
                this._name = value;
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        User user = new User();
        user.Name= "Alice"; // Valid name
        string name = user.Name;
        Console.WriteLine(name); // Output: Alice
    }
}