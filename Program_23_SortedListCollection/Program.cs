SortedList<int, string> empRecord = new SortedList<int, string>();

empRecord.Add(101, "John");
empRecord.Add(102, "Smith");
empRecord.Add(103, "David");

foreach (KeyValuePair<int, string> emp in empRecord)
{
    Console.WriteLine("Key: " + emp.Key + ", Value: " + emp.Value);
}

foreach(var emp in empRecord)
{
    Console.WriteLine($"Key: {emp.Key} & Value: {emp.Value}");
}