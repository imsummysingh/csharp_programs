public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point Coordinates: ({X}, {Y})");
    }
}   

public class Program
{
    public static void Main(string[] args)
    {
        Point point = new Point(10, 20);
        point.Display();
    }
}

//Point Coordinates: (10, 20)