namespace AbstractPerson
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoadPeople();
            Application.Run(new Form1());
        }
        public static PersonManager mgr = new();
        public static void LoadPeople()
        {
            var allLines = File.ReadAllLines("data.txt");
            foreach (var line in allLines)
            {
                var arr = line.Split("=>");
                if (arr.Length < 2) continue;
                mgr.Add(arr[0], arr[1]);
            }
        }
        public static List<TypeText> PersonTypeTexts = new List<TypeText>()
        {
        new TypeText(){Type=typeof(Student), Text="Student"},
        new TypeText(){Type=typeof(Teacher), Text="Teacher"},
        new TypeText(){Type=typeof(Employee), Text="Employee"}
        };
        public static string[] Genders { get; set; } = new string[] { "Female", "Male" };
}
}