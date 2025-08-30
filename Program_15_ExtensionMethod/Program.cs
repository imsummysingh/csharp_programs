//static class for the extension method
public static class StringExtension
{
    //static method which is the extension method
    public static string ToUpperCase(this string str)
    {
      return str.ToUpper();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string name = "hello world";
        //calling the extension method
        string upperName = name.ToUpperCase();
        Console.WriteLine("Extension Method for UpperCase : {0}", upperName);
    }
}