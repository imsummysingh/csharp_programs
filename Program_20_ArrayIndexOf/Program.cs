public class Program
{
    public static void Main(string[] args)
    {
        string[] heros = { "Iron Man", "Batman", "Hulk", "Spider-Man" };

        int index = Array.IndexOf(heros, "Hulk");

        if (index != -1)
        {
            Console.WriteLine("Hero found at index: {0}", index);
        }
        else
        {
            Console.WriteLine("No specified Hero found");
        }
    }
}