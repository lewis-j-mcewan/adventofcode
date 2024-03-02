using System.Text.RegularExpressions;

string[] lines = File.ReadAllLines("input.txt");

int total = 0;

Regex rg = new Regex("\\d");
foreach (string line in lines)
{
    MatchCollection matchedChars = rg.Matches(line);
    
    var first = matchedChars.First().Value;
    var last = matchedChars.Last().Value;
    string value = first + last;
    
    total += int.Parse(value);
}
Console.WriteLine(total);