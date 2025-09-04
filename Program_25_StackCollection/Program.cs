Stack<int> numbers = new Stack<int>();

numbers.Push(1);
numbers.Push(2);
numbers.Push(3);
numbers.Push(4);
numbers.Push(5);

Console.WriteLine("Stack contents:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Popped item: {numbers.Pop()}");

Console.WriteLine($"Last item in stack: {numbers.Peek()}");

Console.WriteLine("Latest Stack Content:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}   