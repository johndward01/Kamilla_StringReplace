static string ReplaceSpace(string str)
{
    return str.Replace(" ", "%20");
}

string oldString = "Jill Scott";
var newString = ReplaceSpace(oldString);

Console.WriteLine(newString);