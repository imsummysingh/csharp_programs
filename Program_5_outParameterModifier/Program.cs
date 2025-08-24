public class Divide
{
    public bool TryDivide(double numerator, double denominator, out double result)
    {
        if (denominator == 0)
        {
            result = 0;
            return false;
        }
        result = numerator / denominator;
        return true;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Divide d = new Divide();
        d.TryDivide(20, 2, out double divResult);
        if (divResult != 0)
        {
            //it will give back the result to the calle mathod, in the out parameter
            Console.WriteLine($"20 / 2 = {divResult}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
}

// Output: 20 / 2 = 10