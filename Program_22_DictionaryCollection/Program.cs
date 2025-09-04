Dictionary<int, string> studentRecord = new Dictionary<int, string>();

//void Add(TKey, TValue) : Adds an element (key/value pair).
//adding the new record using add() method
studentRecord.Add(101, "John");
studentRecord.Add(102, "Steve");
studentRecord.Add(103, "Bill");
studentRecord.Add(104, "Ram");

//adding the new record in dictionary using indexer
studentRecord[105] = "Ron";

//access the value of the key
string name = studentRecord[102];
Console.WriteLine("Id: 102 & Name: {0}", name);


//bool ContainsKey(TKey) : Determines whether the specified key exists.
if (studentRecord.ContainsKey(104))
{
    Console.WriteLine(studentRecord[104]);
}
else
{
    Console.WriteLine("Student 104 not found.");
}

//iterate over the dictionary using foreach loop
foreach (KeyValuePair<int, string> student in studentRecord)
{
    Console.WriteLine($"Id: {student.Key} & Name: {student.Value}");
}
