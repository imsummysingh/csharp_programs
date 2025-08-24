public class player
{
    //private fields for data hiding in encapsulation
    private int _health = 100;
    private int _heal = 100;

    //public properties to access private fields and to manage the damage
    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("Damage cannot be negative.");
            return; //exit the method
        }

        _health -= damage;
        Console.WriteLine($"player took {damage} damage");

        if (_health < 0)
        {
            _health = 0; //prevent health from going below zero
        }

        Console.WriteLine($"player's health is now {_health}");
    }

    //public properties to manage healing
    public void Heal(int healAmount)
    {
        if(healAmount < 0)
        {
            Console.WriteLine("Heal amount cannot be negative.");
            return; //exit the method
        }

        _health += healAmount;

        if(_health > _heal)
        {
            _health = _heal; //prevent health from exceeding maximum heal
        }

        Console.WriteLine($"player healed {healAmount} health");
        Console.WriteLine($"player's health is now {_health}");
    }
}

public class Program()
{

   public static void Main(string[] args)
    {
        player player1 = new player();

        //Test the TakeDamage method
        player1.TakeDamage(20);
        player1.TakeDamage(50);
        player1.TakeDamage(40); // This should not reduce health below 0

        //Test the Heal method
        player1.Heal(30);
        player1.Heal(80); // This should not exceed maximum heal
    }
}   