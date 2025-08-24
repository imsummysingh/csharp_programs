//swap two variable using ref

public class Swapper
{
    public static void swap(ref int a, ref int b)
    {
        Console.WriteLine("(Inside method) Before swap : a={0} & b={1}", a, b);
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("(Inside method) After swap : a={0} & b={1}", a, b);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        Console.WriteLine("(outside method) Before swap: x={0} & y={1}", x, y);
        Swapper.swap(ref x, ref y);
        Console.WriteLine("(outside method) After swap: x={0} & y={1}", x, y);
    }
}

/*
Output:
(outside method) Before swap: x=10 & y=20
(Inside method) Before swap : a=10 & b=20
(Inside method) After swap : a=20 & b=10
(outside method) After swap: x=20 & y=10
 */