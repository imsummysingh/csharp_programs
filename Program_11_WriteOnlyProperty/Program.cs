public class PasswordManager
{
    private string _password;

    public string Password
    {
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
            }
            else
            {
                _password = value;
                Console.WriteLine("Password Saved Successfully");
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PasswordManager manager = new PasswordManager();
        manager.Password = "short"; // Invalid password
    }
}