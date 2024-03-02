using System.Text.RegularExpressions;
using Day01Part2;

string[] lines = File.ReadAllLines("input.txt");

int total = 0;

Regex rgFirst = new Regex("\\d|one|two|three|four|five|six|seven|eight|nine");
Regex rgLast = new Regex("\\d|one|two|three|four|five|six|seven|eight|nine", RegexOptions.RightToLeft);
foreach (string line in lines)
{
    Console.WriteLine(line);
    var first = Helper.WordToNumber(rgFirst.Matches(line).First().Value);
    var last = Helper.WordToNumber(rgLast.Matches(line).First().Value);
    string value = first + last;
    Console.WriteLine(value);
    
    total += int.Parse(value);
}
Console.WriteLine(total);