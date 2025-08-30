public class Repository<T>  //It says repository of what type?
{
    private List<T> _items = new List<T>(); //it will create a list of that type

    public void Add(T item) //Add method to add an item of that type
    {
        _items.Add(item);
    }

    public T GetIndex(int index)
    {
        return _items[index];
    }
}

//employee type of class
public class Employee
{
    //it will have names of employee
    public string name { get; set; }
}

//product type of class
public class Product
{
    //it will have names of product
    public string productName { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        //repository of employee type
        Repository<Employee> employeeRepository = new Repository<Employee>();
        employeeRepository.Add(new Employee { name="Summy"});       //adding a employee in the repository employee list
    }
}