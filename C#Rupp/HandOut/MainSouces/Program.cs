using System.Runtime.CompilerServices;

namespace PeopleManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("People Management");
            Helper.LoadingPeople();
            Helper.MenuBank.MenuSimulate(() => { Console.WriteLine(); });
        }
    }
}