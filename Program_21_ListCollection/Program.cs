List<int> numbers = new List<int> { 1,2,3,4,5 };
List<int> multipleOfTwo = numbers.ConvertAll(n=> n * 2); //multiply the numbers by 2
for (int i = 0; i < multipleOfTwo.Count; i++)
{
    Console.WriteLine(multipleOfTwo[i]);
}









/*
1)Add method in list

List<int> numbers = new List<int> { 10,20};
numbers.Add(30);
for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
 


2)AddRange in list
List<int> numbers = new List<int> { 10, 20, 30 };
int[] moreNumbers = { 40, 50, 60 };

numbers.AddRange(moreNumbers);
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



3)Insert in list
List<int> numbers = new List<int> { 10, 20 };
numbers.Insert(1, 15);
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



4)Insert Range in list
List<int> numbers = new List<int> { 10, 20 };
int[] moreNumbers = { 40, 50, 60 };
numbers.InsertRange(2, moreNumbers);
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}


5)Remove in the list
List<int> numbers = new List<int> { 10, 20,30,40 };
numbers.Remove(20);
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



6)RemoveAt in the list
List<int> numbers = new List<int> { 10, 20,30,40 };
numbers.RemoveAt(2);
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}


7)RemoveRange in the list
List<int> numbers = new List<int> { 10, 20,30,40 };
numbers.RemoveRange(1,2);
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



8)RemoveAll in the list
List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9 };
numbers.RemoveAll(n => n % 2 == 1);     //remove odd numbers
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



9)Clear in the list
List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9 };
numbers.Clear();
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



10)IndexOf in the list
List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9 };
int index = numbers.IndexOf(5);
Console.WriteLine(index);   //4



11)Binary Search in the list
List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9 };
int index = numbers.BinarySearch(5);
Console.WriteLine(index);



12)Contains in the list - return true or false
List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9 };
Console.WriteLine(numbers.Contains(4)); //true



13)Sort in the list
List<int> numbers = new List<int> { 2,341,133,14,4524,1 };
numbers.Sort();
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



14)Reverse in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
numbers.Reverse();
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}



15)ToArray in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
int[] arrayNumbers = numbers.ToArray();
for (int i = 0; i < arrayNumbers.Length-1; i++)
{
    Console.WriteLine(arrayNumbers[i]);
}
Console.WriteLine(arrayNumbers.GetType().Name);



16)ForEach in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
numbers.ForEach(n => Console.WriteLine(n));



17)Exist in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
Console.WriteLine(numbers.Exists(n => n % 2 == 0)); //true  



18)Find in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
Console.WriteLine(numbers.Find(n => n % 2 == 0)); //2



19)FindIndex in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
Console.WriteLine(numbers.FindIndex(n => n % 2 == 0)); //1



20)FindLast in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
Console.WriteLine(numbers.FindLast(n => n % 2 == 0)); //4



21)FindLastIndex in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
Console.WriteLine(numbers.FindLastIndex(n => n % 2 == 0)); //3



22)FindAll in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
List<int> evenNumbers = numbers.FindAll(n=> n % 2 == 0); //find all even numbers
for (int i = 0; i < evenNumbers.Count; i++)
{
    Console.WriteLine(evenNumbers[i]);
}



23)ConvertAll in the list
List<int> numbers = new List<int> { 1,2,3,4,5 };
List<int> multipleOfTwo = numbers.ConvertAll(n=> n * 2); //multiply the numbers by 2
for (int i = 0; i < multipleOfTwo.Count; i++)
{
    Console.WriteLine(multipleOfTwo[i]);
}
 
 
 */

