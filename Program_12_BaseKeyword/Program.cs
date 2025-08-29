public class Report
{
    public string Title { get; set; }

    public void Print()
    {
        Console.WriteLine("Parent class constructor called");
        Console.WriteLine($"Title : {Title}");
        Console.WriteLine("Done with Parent class Constructor");
    }
}

public class RevenueReport : Report
{
    public int Revenue { get; set; }

    //will call the base class constructor in this, as the name will create confusion.
    public void Print()
    {
        base.Print();
        Console.WriteLine("Child Class Constructor is called after the Base class Constructor");
        Console.WriteLine($"Revenue : {Revenue}");
        Console.WriteLine("Done with Child Class Constructor");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        RevenueReport revenueReport = new RevenueReport();
        revenueReport.Title = "Finance";
        revenueReport.Revenue = 100000;
        revenueReport.Print();
    }
}


/*
Parent class constructor called
Title : Finance
Done with Parent class Constructor
Child Class Constructor is called after the Base class Constructor
Revenue : 100000
Done with Child Class Constructor
 */