
Console.WriteLine("Hello, Standard input output!");
Console.Write("Name=");
string ? Name = Console.ReadLine();
if (String.IsNullOrEmpty(Name)) Name = "(NA)";
Console.Write("University=");
string ? univer = Console.ReadLine();
if (String.IsNullOrEmpty(univer)) univer = "RUPP";
string message = "Hello " + Name + " Form " + univer;
Console.WriteLine(message);
