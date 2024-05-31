using System;
using System.Linq;
using System.Reflection;

namespace SL_ArrayDemo_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Array!");
           Demo1D();
            Demo2D();
            DemoJagged();
            Console.ReadKey();
        }
        static void DemoJagged()
        {
            string[][] names = null;
            names = new string[3][]
            {
                new string[3] { "Dara", "Tola", "Manit" },
                null,
                new string[] { "Vanny", "Thida", "lao Kheng", "Long KimTeng", "Mut Vongsa"}
            };
            Console.WriteLine($"Here are all of array of {names.Length} arrays");
            //foreach (string[] row in names)
            //{
            //    if (row == null) { Console.WriteLine("(null)"); continue; }
            //        Console.Write($"{row.Length} elements:");

            //    foreach (string ele in row)
            //        Console.Write($"{(Array.IndexOf(row, ele) > 0 ? "," : "")} {ele}");
            //    Console.WriteLine();
            //}

            for (int r = 0; r < names.Length; r++)
            {
                if (names[r] == null) { Console.WriteLine("(null)"); continue; }
                Console.Write($"{names[r].Length} elements:");

                //for (int c = 0; c < names[r].Length; c++)
                //    Console.Write($"{(c > 0 ? "," : "")} {names[r][c]}");
                string[] ele = names[r];
                for (int c = 0; c < ele.Length; c++)
                    Console.Write($"{(c > 0 ? "," : "")} {ele[c]}");
                Console.WriteLine();
            }

            int[][][] spaces = null;
            spaces = new int[][][]
            {
                new int[3][]
                {
                    new int[] { 1,2,3 },
                    new int[] { 5, 10 },
                    new int[] { 20, 30, 40, 50 }
                },
                new int[][]
                {
                    new int[] { 5, 3, 1 },
                    new int[] { 4, 2 },
                },
                new int[][]
                {
                    new int[]{100,80,60},  //60 here is an element defined by space[2][0][2]:int
                    null,                   //null here is an element defined by space[2][1]:int[]
                    new int[]{30,40,50},
                    new int[]{ },
                    new int[]{7,8,9,5,4,3}
                }
            };

            Console.WriteLine($"\n\nArray of {spaces.Length} arrays");
            foreach (int[][] first in spaces)
            {
                if (first == null) { Console.WriteLine("  (null)"); continue; }
                Console.WriteLine($"  Array of {first.Length} arrays");
                foreach (int[] second in first)
                {
                    if (second == null) { Console.WriteLine("    (null)"); continue; }
                    Console.Write($"    {second.Length} elements:");
                    foreach (int ele in second)
                        Console.Write($"{(Array.IndexOf(second, ele) > 0 ? "," : "")} {ele}");
                    Console.WriteLine();
                }
            }
        }
        static void Demo2D()
        {
            double[,] matrix = null;
            Console.WriteLine("Creating an array > new DataType[rowLength, colLength]");
            matrix = new double[2, 3];
            matrix[0, 2] = 20;
            matrix[1, 1] = 50;
            //1st > matrix[0,0], 2nd > matrix[0,1], 3rd > matrix[0,2]
            //4th > matrix[1,0], 5th > matrix[1,1], 6th > matrix[1,2]
            Console.WriteLine($"Here are all {matrix.Length}({matrix.GetLength(0)}x{matrix.GetLength(1)}) elements");
            //foreach (double ele in matrix) Console.Write($"{ele,8:n2}");
            View2D(matrix);

            Console.WriteLine("\nCreating an array > new DataType[rowLength, colLength]{{value1, value, ...}, ...}");
            matrix = new double[4, 3]
                    {
                        { 1, 2, 3},
                        { 6, 5, 4 },
                        { 10, 20, 30 },
                        { 100, 90, 80 }
                    };
            Console.WriteLine($"Here are all {matrix.Length}({matrix.GetLength(0)}x{matrix.GetLength(1)}) elements");
            //foreach (double ele in matrix) Console.Write($"{ele,8:n2}");
            View2D(matrix);

            Console.WriteLine("\nCreating an array > new DataType[ , ]{{value1, value, ...}, ...}");
            matrix = new double[,]
            {
                { 1, 2, 3, 4},
                { 20, 25, 30, 10},
                { 8, 7, 18, 12 }
            };
            Console.WriteLine($"Here are all {matrix.Length}({matrix.GetLength(0)}x{matrix.GetLength(1)}) elements");
            View2D(matrix);

            Console.WriteLine("\nCreating an array > Array.CreateInstance(Type type, int rowLength, int colLength)");
            matrix = Array.CreateInstance(typeof(double), 3, 2) as double[,];
            Random rand = new Random();
            for (int r = 0; r < matrix.GetLength(0); r++)
                for (int c = 0; c < matrix.GetLength(1); c++)
                    matrix[r, c] = 100 * rand.NextDouble();
            Console.WriteLine($"Here are all {matrix.Length}({matrix.GetLength(0)}x{matrix.GetLength(1)}) elements");
            View2D(matrix);
         
        }
        static void View2D(double[,] arr)
        {
            if (arr == null) return;
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    Console.Write($"{arr[r, c],6:n2}");
                }
                Console.WriteLine();
            }

        }
        static void Demo1D()
        {
            int[] values = null;
            Console.WriteLine("Creating an array > new DataType[length]");
            values = new int[5];
            Console.WriteLine($"Here are all {values.Length} elements");
            for (int index = 0; index < values.Length; index++)
            {
                Console.Write($"{(index > 0 ? "," : "")} {values[index]}");
            }

            Console.WriteLine("\n\nCreating an array > new DataType[Length]{value1, value2, ...}");
            values = new int[3] { 5, 15, 12 };
            Console.WriteLine($"Here are all {values.Length} elements");
            for (int index = 0; index < values.Length; index++)
            {
                Console.Write($"{(index > 0 ? "," : "")} {values[index]}");
            }
           
            Console.WriteLine("\n\nCreating an array > new DataType[ ]{value1, value2, ...}");
            values = new int[] { 5, 15, 10, 25, 20 };
            Console.WriteLine($"Here are all {values.Length} elements");
            foreach (int ele in values)
            {
                Console.Write($"{(Array.IndexOf(values, ele) > 0 ? "," : "")} {ele}");
            }

            Console.WriteLine("\n\nCreating an array > Array.CreateInstance(Type type, int length)");
            values = Array.CreateInstance(typeof(int), 3) as int[];
            values[0] = 30; values[1] = 90; values[2] = values[1] - values[0];
            Console.WriteLine($"Here are all {values.Length} elements");
            Array.ForEach<int>(values, e =>
            {
                Console.Write($"{(Array.IndexOf(values, e) > 0 ? "," : "")} {e}");
            });
        }
    }
}
