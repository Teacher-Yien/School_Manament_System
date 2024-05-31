using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            int n;int Menu;
            do {
                Console.Clear();
                Console.WriteLine("==========Menu==================");
                Console.WriteLine("\t 1.Input   Array...");
                Console.WriteLine("\t 2.output  Array...");
                Console.WriteLine("\t 3.search  Array...");
                Console.WriteLine("\t 4.update  Array...");
                Console.WriteLine("\t 5.Deleted Array...");
                Console.WriteLine("\t 6.Insert  Array...");
                Console.WriteLine("\t 7.sort    Array...");
                Console.WriteLine("\t 8.Add     Array...");
                Console.Write("\t  Chose option of Menu:");
                Menu = int.Parse(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        {
                            Console.WriteLine("========Input==========");
                            Console.Write("Input Size :");
                            n = int.Parse(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write("Input Array[" + i + "]=");
                                array[i] = int.Parse(Console.ReadLine());
                            }
                        break;
                        }
                    case 2:
                        {
                            Console.WriteLine("========output==========");
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Show Array[" + i + "]=" + array[i]);
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("=========Search Data========");
                            int sid;
                            Console.Write("Search By ID :");
                            sid = int.Parse(Console.ReadLine());
                            Boolean check = true;
                            for (int i = 0; i < n; i++)
                            {
                                if (sid == array[i])
                                {
                                    Console.WriteLine("Show Array[" + i + "]=" + array[i]);
                                    check = false;
                                    Console.WriteLine("Check Success!");
                                }

                            }
                            if (check)
                            {
                                Console.WriteLine("Check Not Found!");
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("=========Update Data========");
                            int upid;
                            Console.Write("Update By ID :");
                            upid = int.Parse(Console.ReadLine());
                            Boolean b = true;
                            for (int i = 0; i < n; i++)
                            {
                                if (upid == array[i])
                                {
                                    Console.Write("Input Array[" + i + "]=");
                                    array[i] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Update Success!");
                                    b = false;
                                }

                            }
                            if (b)
                            {
                                Console.WriteLine("Update Not Found!");
                            }
                            Console.WriteLine("========output==========");
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Show Array[" + i + "]=" + array[i]);
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("**********Delete Data*******************");
                            int deleted;
                            Console.Write("Deleted Data by id:");
                            deleted = int.Parse(Console.ReadLine());
                            Boolean f = false;
                            for (int i = 0; i < n; i++)
                            {
                                if (deleted == array[i])
                                {
                                    for (int j = i; j < n - 1; j++)
                                    {
                                        array[j] = array[j + 1];

                                    }
                                    n--;
                                    f = true;
                                }
                            }
                            if (!f)
                            {
                                Console.WriteLine("Check Not Found!");
                            }
                            else
                            {
                                Console.WriteLine("Check  Success!");
                            }
                            Console.WriteLine("========output==========");
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Show Array[" + i + "]=" + array[i]);
                            }
                        } break;
                    case 6:
                        {
                            Console.WriteLine("**********Insert Data*******************");
                            int insert;
                            Console.Write("insert Data by id:");
                            insert = int.Parse(Console.ReadLine());
                            Boolean k = false;
                            for (int i = 0; i < n; i++)
                            {
                                if (insert == array[i])
                                {
                                    for (int j = n; j >= i; j--)
                                    {
                                        array[j] = array[j - 1];

                                    }
                                    Console.Write("Input Array[" + i + "]=");
                                    array[i] = int.Parse(Console.ReadLine());
                                    n++;
                                    k = true;
                                    break;
                                }
                            }
                            if (!k)
                            {
                                Console.WriteLine("Check Not Found!");
                            }
                            else
                            {
                                Console.WriteLine("Check  Success!");
                            }
                            Console.WriteLine("========output==========");
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Show Array[" + i + "]=" + array[i]);
                            }
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("**********Sort Data*******************");
                            int temp;
                            Boolean p = false;
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (array[i] < array[j])
                                    {
                                        temp = array[i];
                                        array[i] = array[j];
                                        array[j] = temp;
                                        p = true;
                                    }
                                }

                            }
                            if (!p)
                            {
                                Console.WriteLine("Check Not Found!");
                            }
                            else
                            {
                                Console.WriteLine("Check  Success!");
                            }
                            Console.WriteLine("========output==========");
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Show Array[" + i + "]=" + array[i]);
                            }
                        }
                        break;
                    case 8:
                        {
                            // Add data
                            int add;
                            Console.Write("Input Size :");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("========Add data==========");
                            for (int i = n; i < n + add; i++)
                            {
                                Console.Write("Input Array[" + i + "]=");
                                array[i] = int.Parse(Console.ReadLine());

                            }

                            Console.WriteLine("========output==========");
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Show Array[" + i + "]=" + array[i]);
                            }
                        }
                        break;
                    case 9:
                        {
                            Environment.Exit(0);
                         break;
                        }
                }
            } while(true);
            Console.ReadKey();
        }
    }
}
