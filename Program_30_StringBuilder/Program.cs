using System.Text;

StringBuilder sb = new StringBuilder();

for(int i = 0; i < 1000; i++)
{
    sb.Append(i);
    sb.Append(", ");
}

Console.WriteLine("Value in the string builder object");
Console.WriteLine(sb.ToString());