public class User
{
    private string _fname;
    private string _lname;
    private readonly DateTime DateOfBirth;

    //constructor
    public User(string fname, string lname, DateTime dob)
    {
        this._fname = fname;
        this._lname = lname;
        this.DateOfBirth = dob;
    }

    //expression-bodied member syntax
    //It provides a concise way to define members (like properties or methods) that return a single expression.
    public string fullName => $"{_fname} {_lname}";

    // Read-only property to calculate age.
    public int Age
    {
        get
        {
            int age = DateTime.Today.Year - DateOfBirth.Year;

            if (DateTime.Today.DayOfYear < DateOfBirth.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
    
}

public class Program
{
    public static void Main(string[] args)
    {
        User user = new User("Jane", "Doe", new DateTime(1990, 5, 15));
        Console.WriteLine($"Full Name: {user.fullName}"); // Output: Full Name: Jane Doe
        Console.WriteLine($"Age: {user.Age}"); // Output: Age: (calculated age based on current date)
    }
}