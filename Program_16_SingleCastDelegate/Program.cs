//defining the delegate
public delegate int MathOperation(int x, int y);

public class Calculate
{
    //method 1 : add
    public int Add(int x, int y)
    {
        Console.WriteLine("Add Method is called");
        return x + y;   
    }

    //method 2: substract
    public int Subtract(int x, int y) 
    {
        Console.WriteLine("Substract method is called");
        return x - y;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculate calc = new Calculate();

        //creating reference variable of the delegate for Add method
        MathOperation addOp = new MathOperation(calc.Add);
        int result = addOp(2, 3);
        Console.WriteLine("Add Operation result: {0}", result);

        MathOperation subOp = new MathOperation(calc.Subtract);
        result = subOp(3, 2);
        Console.WriteLine("Subtract Operation result : {0}", result);
    }
}


/*
Add Method is called
Add Operation result: 5
Substract method is called
Subtract Operation result : 1
 */