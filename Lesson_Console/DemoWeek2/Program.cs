using System.Drawing;

Console.WriteLine("Input Rectangle: ");
int count = 0;
double total = 0;
string result = "";
while (true)
{
    Console.Write($"index: [{count+1}]:");
    string? line = Console.ReadLine();
    if (string.IsNullOrEmpty(line)) break;
    Rectangle rec = new();
    if (rec.SetData(line) == false) continue;
    count++;
    total += rec.GetArea();
    if (result != "") result += "\n";
   // result+= lininfo;
   result += $"{count,8} {rec.GetInfo()}";
}
string heading = $"{"No.",8} {Rectangle.GetHeading()}";
string bar = new string('-', 8) + Rectangle.GetBar('-');
string totalTxt = $"Total:{total:N2}";
string totalInfo = $"{totalTxt,35}";
Console.WriteLine();
Console.WriteLine(heading);
Console.WriteLine(bar);
Console.WriteLine(result);
Console.WriteLine(bar);
Console.WriteLine(totalInfo);