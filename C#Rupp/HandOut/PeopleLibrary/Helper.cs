using MenuLibrary;
using PeopleLibrary;

namespace PeopleManagement
{
    public static class Helper
    {
        public static string DataFile { get; set; } = "people.txt";
        private static bool isModifed = false;
        public static bool IsModified => isModifed;
     
        private static PersonManager mgr = PersonManager.GetInstance();
        public static MenuBank MenuBank { get; set; } = new MenuBank()
        {
            Title = "People",
            Menues = new List<Menu>()
            {
                new Menu(){ Text= "Viewing", Action=ViewingPeople},
                new Menu(){ Text= "Creating", Action=CreatingPeople},
                new Menu(){ Text= "Updating", Action=UpdatingPeople},
                new Menu(){ Text= "Deleting", Action=DeletingPeople},
                new Menu(){ Text= "Saving", Action=SavingPeople},
                new Menu(){ Text= "Exiting", Action = ExitingProgram}
            }
        };

        public static void ExitingProgram()
        {
            Console.WriteLine("\n[Exiting Program]");
            Helper.SavingConfirm();
            Environment.Exit(0);
        }

        private static void DeletingPeople()
        {
            Console.WriteLine("\n[Deleting People]");
            while (true)
            {
                Console.Write("Person No: ");
                int.TryParse(Console.ReadLine(), out int no);

                var result = mgr.Remove(no);
                if (result != null)
                {
                    Console.WriteLine($"Successfully removed the person named {result.Name}");
                    isModifed = true;
                }
                else
                {
                    Console.WriteLine($"Failed to remove a person with no, {no}");
                }

                Console.WriteLine();
                Console.Write("ESC to stop or any key for more deleting...");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine(keyInfo.KeyChar);
                    break;
                }
                Console.WriteLine(keyInfo.KeyChar);
            }
        }
        
        private static void UpdatingPeople()
        {
            Console.WriteLine("\n[Updating People]");
            while (true)
            {
                Console.Write("Person No: ");
                int.TryParse(Console.ReadLine(), out int no);

                var found = mgr.Get(no);
                if (found == null)
                {
                    Console.WriteLine($"No people with the no, {no}");
                }
                else
                {
                    Console.Write("New Name  : ");
                    string name = Console.ReadLine() ?? "";
                    Console.Write("New Gender: ");
                    string gender = Console.ReadLine() ?? "";
                    Console.Write("New Age   : ");
                    byte.TryParse(Console.ReadLine(), out byte age);

                    found.Name = name;
                    found.Gender = gender;
                    found.Age = age;
                    if (mgr.Update(found) == true)
                    {
                        Console.WriteLine($"Successfully update the person the no, {found.No}");
                        isModifed = true;
                    }
                    else
                    {
                        Console.WriteLine($"Failed to update the person with the no, {found.No}");
                    }
                }
                
                Console.WriteLine();
                Console.Write("ESC to stop or any key for more updating...");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine(keyInfo.KeyChar);
                    break;
                }
                Console.WriteLine(keyInfo.KeyChar);
            }
        }

        private static void CreatingPeople()
        {
            Console.WriteLine("\n[Creating People]");
            while (true)
            {
                Console.Write("No (int)       : ");
                int.TryParse(Console.ReadLine(), out int no);
                Console.Write("Name (string)  : ");
                string name = Console.ReadLine() ?? "";
                Console.Write("Gender (string): ");
                string gender = Console.ReadLine() ?? "";
                
                Console.Write("Age (int)      : ");
                byte.TryParse(Console.ReadLine(), out byte age);
                try
                {
                    mgr.Add(no, name, gender, age);
                    Console.WriteLine("Successfully added");
                    isModifed = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Failed > {ex.Message}");
                }
                

                Console.WriteLine();
                Console.Write("ESC to stop or any key for more person...");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine(keyInfo.KeyChar);
                    break;
                }
                Console.WriteLine(keyInfo.KeyChar);
            }
        }
       
        private static void ViewingPeople()
        {
            Console.WriteLine("\n[Viewing People]");
            int count = mgr.Count;
            Console.WriteLine($"People: {count}");
            if (count == 0) return;

            var people = mgr.All;
            Console.WriteLine($"{"No",8} {"Name",-30} {"Gender",-7} {"Age",3}");
            Console.WriteLine(new string('=', 51));
            foreach (var p in people.OrderBy(e => e.No))
            {
                Console.WriteLine($"{p.No,8} {p.Name,-30} {p.Gender,-7} {p.Age,3}");
            }
        }

        public static void LoadingPeople()
        {
            mgr.Clear();
            if (System.IO.File.Exists(DataFile) == false) return;
            using(var streamReader=new StreamReader(DataFile))
            {
                string? line = null;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var parts = line.Split("|");
                    if (parts.Length < 4) continue;
                    int.TryParse(parts[0], out var no);
                    byte.TryParse(parts[3], out var age);
                    try
                    {
                        mgr.Add(no, parts[1], parts[2], age);
                    }
                    catch (Exception) { }
                }
            }
            Console.WriteLine("Successfully loaded");
            isModifed = false;
        }

        private static void SavingPeople()
        {
            Console.WriteLine("\n[Saving People]");
            if (isModifed == true)
            {

                using (var streamWriter = new StreamWriter(DataFile))
                {
                    mgr.All.ForEach(p =>
                    {
                        streamWriter.WriteLine($"{p.No}|{p.Name}|{p.Gender}|{p.Age}");
                    });
                }
            }
            Console.WriteLine("Successfully saved");
            isModifed = false;
        }
        
        public static void SavingConfirm()
        {
            if (isModifed == true)
            {
                Console.Write("People are modified, Save Changes?(y/n): ");
                ConsoleKeyInfo keyInfo = new();
                while (true)
                {
                    keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Y || keyInfo.Key == ConsoleKey.N)
                    {
                        Console.WriteLine(keyInfo.KeyChar);
                        break;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Y) SavingPeople();
            }
        }
    }
}