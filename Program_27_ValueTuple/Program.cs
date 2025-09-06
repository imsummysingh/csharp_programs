//creating value tuple
//this method's return type is value tuple

public class Program
{
    public (string, int) GetPerson()
    {
        string name = "John";
        int age = 30;
        return (name, age);
    }

    public static void Main(string[] args)
    {
        //adding value tuple
        (string name, int age) person = ("Bob", 29);

        Console.WriteLine($"Name: {person.name} & Age: {person.age}");


    }
}
