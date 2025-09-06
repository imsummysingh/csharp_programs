public class Program
{
    public class Product 
    {
        public string Name;
        public decimal Price;
    }

    static List<Product> products = new List<Product>
    {
        new Product{ Name = "Laptop", Price = 999 },
        new Product{ Name = "Smartphone", Price = 699 },
        new Product{ Name = "Tablet", Price = 499 }
    }; 

    public static void Main(string[] args)
    {
        //select only the names of the products
        IEnumerable<string> productNames = products.Select(p => p.Name);
        Console.WriteLine("Product Names:");
        foreach (var name in productNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("------------------------------------------------------");

        //projecting to an anonymous type with Name and Price after applying a discount
        var discountedProductPrice = products.Select(p => new
        {
            productName = p.Name,
            productPrice = p.Price * 0.9m // 10% discount
        });
        Console.WriteLine("Discounted Product Prices:");
        foreach (var item in discountedProductPrice)
        {
            Console.WriteLine($"{item.productName}: {item.productPrice:C}");
        }
    }
}


/*
 * 
1)Where - Filters a sequence of values based on a predicate.
List<int> scores = new List<int> { 25, 88, 42, 95, 15, 71, 99 };
IEnumerable<int> highScore = scores.Where(s => s > 50);
Console.WriteLine("Scores more than 50");
foreach(int score in highScore)
{
    Console.WriteLine(score);
}


2) OrderBy, OrderByDescending, ThenBy, ThenByDescending - Sorting a sequence of values and returning new sequence
public class Program
{
    public class Product
    {
        public string Category;
        public string Name;
    }

    static List<Product> products = new List<Product>()
    {
        new Product() { Category = "Electronics", Name = "Laptop" },
        new Product() { Category = "Electronics", Name = "Smartphone" },
        new Product() { Category = "Furniture", Name = "Table" },
        new Product() { Category = "Furniture", Name = "Chair" }
    };


    public static void Main(string[] args)
    {
        //sory by a single name
        var sortedByName = products.OrderBy(p => p.Name);
        foreach (var product in sortedByName)
        {
            Console.WriteLine($"{product.Category} - {product.Name}");
        }


        Console.WriteLine("--------------");

        //sort by category and then by name
        var sortedByCategoryAndName = products
            .OrderBy(p => p.Category)
            .ThenBy(p => p.Name);

        foreach (var product in sortedByCategoryAndName)
        {
            Console.WriteLine($"{product.Category} - {product.Name}");
        }

    }
}


3)First and FirstOrDefault - Returns the first element of a sequence, or a default value(null) if no element is found.
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numbers2 = new List<int> { };

//check on numbers
Console.WriteLine("On 1st List of numbers");
Console.WriteLine($"Check First: {numbers.First()}");
Console.WriteLine($"Check FirstorDefault : {numbers.FirstOrDefault()}");

//check on numbers2
Console.WriteLine("On 2st List of numbers");
Console.WriteLine($"Check FirstorDefault : {numbers2.FirstOrDefault()}");
try
{
    Console.WriteLine($"Check First: {numbers2.First()}");
}
catch (InvalidOperationException)
{
    Console.WriteLine("It threw Invalid Operation Exception because the list is empty and there is no first element");
}

4)Select - Projects each element of a sequence into a new form.
public class Program
{
    public class Product 
    {
        public string Name;
        public decimal Price;
    }

    static List<Product> products = new List<Product>
    {
        new Product{ Name = "Laptop", Price = 999 },
        new Product{ Name = "Smartphone", Price = 699 },
        new Product{ Name = "Tablet", Price = 499 }
    }; 

    public static void Main(string[] args)
    {
        //select only the names of the products
        IEnumerable<string> productNames = products.Select(p => p.Name);
        Console.WriteLine("Product Names:");
        foreach (var name in productNames)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("------------------------------------------------------");

        //projecting to an anonymous type with Name and Price after applying a discount
        var discountedProductPrice = products.Select(p => new
        {
            productName = p.Name,
            productPrice = p.Price * 0.9m // 10% discount
        });
        Console.WriteLine("Discounted Product Prices:");
        foreach (var item in discountedProductPrice)
        {
            Console.WriteLine($"{item.productName}: {item.productPrice:C}");
        }
    }
}
 */
