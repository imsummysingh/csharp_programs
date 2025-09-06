string s1 = "Hello-I-am-a-Program";
char[] remover = { '-' };
//split the string in array of strings
string[] updatedValue = s1.Split(remover);
foreach (string s in updatedValue)
{
    Console.WriteLine(s);
}



/*
Methods of String

1. ToUpper() & ToLower()
string s1 = "asdfghjk";
string s2 = "ASDFGHJKL";
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s2.ToLower());

2. SubString()
string s1 = "Hello I am a Program";
Console.WriteLine("Substring is : {0}",s1.Substring(6));        //I am a Program

3. Replace()
string s1 = "Hello I am a Program";
Console.WriteLine("Substring is : {0}",s1.Replace("Program","Code"));   

4. Split()
string s1 = "Hello-I-am-a-Program";
char[] remover = { '-' };
//split the string in array of strings
string[] updatedValue = s1.Split(remover);
foreach (string s in updatedValue)
{
    Console.WriteLine(s);
}





 */