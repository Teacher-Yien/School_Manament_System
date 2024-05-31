
Console.WriteLine("Hello, File input output!");
/*string inFile = "in.txt";
Console.WriteLine($"Inputting form file {inFile}");
Console.SetIn(File.OpenText(inFile));*/
Console.Write("Name=");
string? Name = Console.ReadLine();
if (String.IsNullOrEmpty(Name)) Name = "(NA)";
Console.Write("University=");
string? univer = Console.ReadLine();
if (String.IsNullOrEmpty(univer)) univer = "RUPP";
string outFile = "out.txt";
Console.WriteLine($"Message was witeten to the file {outFile}");
string message = "Hello " + Name + " Form " + univer;
Console.SetOut(File.CreateText(outFile));
Console.WriteLine(message);
Console.Out.Close();




