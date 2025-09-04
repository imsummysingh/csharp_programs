HashSet<string> tags = new HashSet<string>();

tags.Add("csharp");
tags.Add("dotnet");
tags.Add("programming");

//check if the tag exist or not
bool isAdded = tags.Add("csharp");
Console.WriteLine($"Was chsarp added again?: {isAdded}");

Console.WriteLine("Tags:");
foreach (var tag in tags)
{
    Console.WriteLine(tag);
}