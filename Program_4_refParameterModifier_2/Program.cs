public class Person
{
    public string name;
}

public class Program
{
    public static void SwapPerson(ref Person p1, ref Person p2)
    {
        Person temp = p1;
        p1 = p2;
        p2 = temp;
    }

    public static void Main(string[] args)
    {
        Person p1 = new Person { name = "Alice" };
        Person p2 = new Person { name = "Bob" };
        System.Console.WriteLine($"Before Swap: p1.name = {p1.name}, p2.name = {p2.name}");
        SwapPerson(ref p1, ref p2); // Swap the references of p1 and p2
        Console.WriteLine($"After Swap: p1.name = {p1.name}, p2.name = {p2.name}");
    }
}


/*
Output:
Before Swap: p1.name = Alice, p2.name = Bob
After Swap: p1.name = Bob, p2.name = Alice
 */