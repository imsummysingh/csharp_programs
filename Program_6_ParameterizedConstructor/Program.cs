public class Car
{
    //insatnce field
    private string model;
    private string color;
    private int year;

    //parameterized constructor
    public Car(string model, string color, int year)
    {
        this.model = model;
        this.color = color;
        this.year = year;
    }

    //methiod to display information
    public void DisplayInfo()
    {
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car("Alto K10", "Golden", 2012);
        car.DisplayInfo();
    }
}