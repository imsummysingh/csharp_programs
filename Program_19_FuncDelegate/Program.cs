public class Program
{  
    public static void Main(string[] args)
    {
        //func delegate for add operation
        Func<int, int, int> add = (x, y) => x + y;

        Console.WriteLine("Addition: " + add(10, 20));
    }
}