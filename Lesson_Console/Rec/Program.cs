namespace Rec
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
            
            Application.Run(new Form1());
        }
      /*  private static LoadRec(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(filename);
        }*/
        public static List<Rectangle> Rectangles = new();
    }
}