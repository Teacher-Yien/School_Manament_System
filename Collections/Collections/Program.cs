using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int size = 0;
            Hashtable storage = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("===============Menu========================");
                Console.WriteLine("\t 1.Input Data...");
                Console.WriteLine("\t 2.output Data...");
                Console.WriteLine("\t 3.Search Data...");
                Console.WriteLine("\t 4.Update Data...");
                Console.WriteLine("\t 5.Deleted Data...");
                Console.WriteLine("\t 6.Add size Data...");
                Console.Write("\t Chose option of Menu= ");
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        {
                            Console.WriteLine("=============Input data==============");
                            Console.Write("Input Size of Number =");
                            size = int.Parse(Console.ReadLine());
                            for(int i = 0; i<size; i++)
                            {
                                int key;
                                Console.Write("Input ID=");
                                key = int.Parse(Console.ReadLine());
                                Student Value = new Student();
                                Value.input();
                                storage.Add(key, Value);
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("==================Output=======================");
                           foreach(DictionaryEntry item in storage)
                            {
                                Console.WriteLine("ID:"+item.Key+item.Value.ToString());
                            }
                        }
                        break;
                    case 3:
                        {
                            int sid;
                            Console.WriteLine("==================Search=======================");
                            Console.Write("Input Search by ID=");
                            sid = int.Parse(Console.ReadLine());
                            foreach (DictionaryEntry item in storage)
                            {
                                if (int.Parse(item.Key.ToString()) == sid)
                                {
                                    Console.WriteLine("ID:" + item.Key + item.Value.ToString());
                                }

                            }
                        }
                            break;
                    case 4:
                        {
                            int sid;
                            Console.WriteLine("==================Update=======================");
                            Console.Write("Input Update by ID=");
                            sid = int.Parse(Console.ReadLine());
                            foreach (DictionaryEntry item in storage)
                            {
                                if (int.Parse(item.Key.ToString()) == sid)
                                {
                                    storage.Remove(item.Key);
                                    int key;
                                    Console.Write("Input ID=");
                                    key = int.Parse(Console.ReadLine());
                                    Student Value = new Student();
                                    Value.input();
                                    storage.Add(key, Value);
                                    break;
                                }


                            }
                        }
                        break;
                    case 5:
                        {
                            int sid;
                            Console.WriteLine("==================Update=======================");
                            Console.Write("Input Deleted by ID=");
                            sid = int.Parse(Console.ReadLine());
                            foreach (DictionaryEntry item in storage)
                            {
                                if (int.Parse(item.Key.ToString()) == sid)
                                {
                                    storage.Remove(item.Key);
                                    break;
                                }

                            }
                            Console.WriteLine("==================Output=======================");
                            foreach (DictionaryEntry item in storage)
                            {
                                Console.WriteLine("ID:" + item.Key + item.Value.ToString());
                            }
                        }
                        break;
                    case 6:
                        {
                            int add;
                            Console.WriteLine("==================Add Size=======================");
                            Console.Write("Input Add size =");
                            add = int.Parse(Console.ReadLine());
                            for (int i = size; i < size+add; i++)
                            {
                                int key;
                                Console.Write("Input ID=");
                                key = int.Parse(Console.ReadLine());
                                Student Value = new Student();
                                Value.input();
                                storage.Add(key, Value);
                            }
                            size += add;
                            Console.WriteLine("==================Output=======================");
                            foreach (DictionaryEntry item in storage)
                            {
                                Console.WriteLine("ID:" + item.Key + item.Value.ToString());
                            }
                        }
                        break;

                }
                Console.ReadKey();

            } while (op != 0);
        }
    }
}
