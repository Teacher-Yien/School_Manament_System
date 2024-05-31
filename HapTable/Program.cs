using System.Collections;

namespace HapTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Hashtable ht = new Hashtable();
           
            int op=0,n=0;
            int? keyID; string Value = "";
            do { 
            Console.Write("Input options: ");
            op= int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        Console.WriteLine("Add Data....");
                        Console.Write("Input N: ");
                        n=int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Input ID: ");
                            keyID = int.Parse(Console.ReadLine());
                            Console.Write("Input Name: ");
                            Value = Console.ReadLine();
                            ht.Add(keyID, Value);

                        }
                    }
                    break;
                case 2:
                    {
                        foreach (DictionaryEntry item in ht)
                        {
                            Console.WriteLine("ID : "+ item.Key +"\t "+ item.Value);

                        }

                    }
                    break;
                case 3:
                    {
                        int sid = 0;
                            Console.Write("Search by id: ");
                            sid= int.Parse(Console.ReadLine());

                            foreach (DictionaryEntry item in ht)
                        {
                                if (sid == (int)item.Key)
                                {
                                Console.WriteLine("ID : " + item.Key + "\t " + item.Value);
                                }
                            

                        }

                    }
                    break;
                    case 4:
                        {
                            int sid = 0;
                            Console.Write("Delete by id: ");
                            sid = int.Parse(Console.ReadLine());

                            foreach (var key in ht.Keys)
                            {
                                if (sid == (int)key)
                                {
                                    ht.Remove(key);
                                    Console.WriteLine("ID : " + key + "\t " + ht[key]);
                                    break; // break out of the loop since the item is removed
                                }
                                else{
                                    Console.WriteLine("Find Delete + "+sid+" Not Found!");
                                }
                            }

                        }
                        break;
                    case 5:
                        {
                            int sid = 0;
                            Console.Write("Update by id: ");
                            sid = int.Parse(Console.ReadLine());

                            bool found = false;

                            foreach (DictionaryEntry item in ht)
                            {
                                if (sid == (int)item.Key)
                                {
                                    Console.Write("Input Name: ");
                                    string newValue = Console.ReadLine();
                                    ht[item.Key] = newValue;
                                    found = true;
                                    Console.WriteLine("Data with ID " + sid + " has been updated.");
                                    break; // Exit the loop after updating the item
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine("Data with ID " + sid + " not found for update.");
                            }


                        }
                        break;
                    default:
                        {
                            Console.WriteLine(" Not options "+op);
                        }break;

                }
            } while (op != 0);

            Console.ReadKey();


        }
    }
}
