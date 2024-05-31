namespace ClassLibrary1
{
    
    public class Class1
    {
        public static PersonListX PersonList = new();
        private static void LoadPeople()
        {
            var allLines = File.ReadAllLines("people.txt");
            foreach (var line in allLines)
            {
                var newPerson = Person.CreateInstance(line);
                if (newPerson != null)
                {
                    PersonList.Add(newPerson);
                }
            }
        }

    }
}
