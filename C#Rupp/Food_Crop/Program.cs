namespace Food_Crop
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
            //  ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            string[] provinces = new[] { "Kampot", "Kandal", "Siemreap", "Takeo" };
            string[] crops = new[] { "Bean", "Corn", "Rice" };
            Buying buying = new(provinces, crops);
            ViewBuying(buying);
            while (true)
            {
                InputAmount(buying);
                ViewBuying(buying);
                Console.WriteLine("\nAny key to another input or Esc to stop");
                if (Console.ReadKey().Key == ConsoleKey.Escape) break;
            }
        }
        static void InputAmount(Buying buying)
        {
            Console.WriteLine();
            Console.WriteLine("[Changing/Adding up bought amount]");
            Console.Write("Provinces: ");
            for (int r = 0; r < buying.Provinces.Length; r++)
                Console.Write($"{r}-{buying.Provinces[r]}{(r == buying.Provinces.Length - 1 ? " " : ",")} ");
            Console.Write("\nCrops: ");
            for (int c = 0; c < buying.Crops.Length; c++)
                Console.Write($"{c}-{buying.Crops[c]}{(c == buying.Crops.Length - 1 ? " " : ",")} ");
            Console.Write("\nData formatted: province crop amount addup?, eg. 0 1 300 0 or 1 2 500 1");
            while (true)
            {
                Console.Write("\nInput data: ");
                string[]? data = Console.ReadLine()?.Split(" ");
                if (data == null || data.Length < 4)
                {
                    Console.WriteLine("Input data is not enough");
                    continue;
                }
                if (
                (int.TryParse(data[0], out int row) == false || row < 0 || row >= buying.Provinces.Length)
                || (int.TryParse(data[1], out int col) == false || col < 0 || col >= buying.Crops.Length)
                || double.TryParse(data[2], out double amount) == false
                || int.TryParse(data[3], out int add) == false)
                {
                    Console.WriteLine("Invalid input data");
                    continue;
                }
                bool isAdded = (add == 0 ? false : true);
                buying.SetValue(amount, row, col, isAdded);
                break;
            }
        }
        static void ViewBuying(Buying buying)
        {
            Console.WriteLine();
            Console.WriteLine("[Buying Matrix]");
            Console.Write($"{"Province",10} ");
            foreach (var crop in buying.Crops) Console.Write($"{crop,10} ");
            Console.WriteLine($"{"Total",10}");
            Console.WriteLine(new string('-', (10 + 1) * (1 + buying.Crops.Length + 1)));
            for (int r = 0; r < buying.Provinces.Length; r++)
            {
                Console.Write($"{buying.Provinces[r],10} ");
                for (int c = 0; c < buying.Crops.Length; c++)
                {
                    Console.Write($"{buying.GetValue(r, c),10:n2} ");
                }
                Console.WriteLine($"{buying.TotalRow(r),10:n2} ");
            }
            Console.WriteLine(new string('-', (10 + 1) * (1 + buying.Crops.Length + 1)));
            Console.Write($"{"Total",10} ");
            for (int c = 0; c < buying.Crops.Length; c++)
                Console.Write($"{buying.TotalColumn(c),10:n2} ");
            Console.WriteLine($"{buying.Total(),10:n2} ");
        }
    }
}