
namespace File_Txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // write file txt
            try
            {
                FileStream fileStream = new FileStream("example.txt", FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                string[] texts = { "Line 1", "Line 2", "Line 3" };
                foreach (var line in texts)
                {
                    streamWriter.WriteLine(line);
                }
                streamWriter.Close();
                var person = new Person()
                {
                    Name = "Sok Dara",
                    Gender = "Female",
                    Age = 35
                };

                using (StreamWriter streamWriter1 = new StreamWriter("example.txt"))
                {
                    streamWriter1.WriteLine($"{nameof(Person.Name)}:{person.Name}");
                    streamWriter1.Write($"{nameof(Person.Gender)}:");
                    streamWriter1.WriteLine(person.Gender);
                    streamWriter1.Write($"{nameof(Person.Age)}:");
                    streamWriter1.WriteLine(person.Age);
                }
            }catch (Exception ex) { }
            // read file txt
            try
            {
                FileStream file = new FileStream("example.txt", FileMode.Open);
                StreamReader streamReader = new StreamReader(file);
                var contents = streamReader.ReadToEnd();
                string[] lines1 = contents.Split(new[] { Environment.NewLine },
                StringSplitOptions.None);
                using (StreamReader streamReader1 = new StreamReader("example.txt"))
                {
                    List<string> lines = new();
                    string? line = null;
                    while ((line = streamReader1.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                Person? person1 = null;
                using (StreamReader streamReader1 = new StreamReader("example.txt"))
                {
                    var temp = new Person();
                    var isOK = false;
                    for (int count = 1; count <= 3; count++)
                    {
                        var line = streamReader.ReadLine();
                        if (line == null) break;
                        var parts = line.Split(":");
                        if (parts[0] == nameof(Person.Name)) temp.Name = parts[1];
                        else if (parts[0] == nameof(Person.Gender)) temp.Gender = parts[1];
                        else if (parts[0] == nameof(Person.Age))
                            temp.Age = byte.Parse(parts[1]);
                        isOK = true;
                    }
                    
                    if (isOK) person1 = temp;
                    
                }
                Console.WriteLine("Hello Save");

            }
            catch(Exception e) { }
            Console.ReadKey();
        }
    }
}
