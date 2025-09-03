//create a public delegate
public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

//create the publisher class
public class Stock
{
    private string _symbol;
    private decimal _price;

    //it will create a private delegate behind the scene
    public event PriceChangedHandler PriceChanged;

    public decimal Price
    {
        get { return _price; }

        set
        {
            if (_price != value)
            {
                decimal oldPrice = _price;
                _price = value;

                //check if there are any subscriber, check if it is null or not
                PriceChanged?.Invoke(oldPrice, value);
            }
        }
    }

    //constructor
    public Stock(string symbol, decimal startPrice)
    {
        _symbol = symbol;
        _price = startPrice;
    }
}

//create the subscriber class
public class  StockLog
{
    public void OnPriceChanged(decimal oldPrice, decimal newPrice)
    {
        Console.WriteLine($"Stock price changed from {oldPrice} to {newPrice}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //creating object for both publisher and subscriber class
        Stock Tesla = new Stock("TSLA", 600.00m);
        StockLog log = new StockLog();

        //subscribe to the event
        Tesla.PriceChanged += log.OnPriceChanged; //(publisher -> subscriber)

        //change the price to trigger the event and call the subscriber class
        Tesla.Price = 650.00m;
    }
}


//Stock price changed from 600.00 to 650.00