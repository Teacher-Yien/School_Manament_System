using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array_list_Collection
{
    internal class Program
    {
        public  static void Main(string[] args)
        {
            int op = 0;
            int size = 0; 
            List<Product_shop> list = new List<Product_shop>();
            do
            {
                Console.Clear();
                Console.WriteLine("\t 1.Input   Product Array_list....!");
                Console.WriteLine("\t 2.output  Product Array_list....!");
                Console.WriteLine("\t 3.Search  Product Array_list....!");
                Console.WriteLine("\t 4.Find Indexof  Product Array_list....!");
                Console.WriteLine("\t 5.Update  Product Array_list....!");
                Console.WriteLine("\t 6.Insert  Product Array_list....!");
                Console.WriteLine("\t 7.Deleted Product Array_list....!");
                Console.WriteLine("\t 8.Sort    Product Array_list....!");
                Console.Write("\t Chose option of Menu =");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("================= Input ====================");
                            Console.Write("Input Number of Product=");
                            size =  int.Parse(Console.ReadLine());
                            for(int i = 0; i < size; i++)
                            {
                                Product_shop obj = new Product_shop();
                                obj.Input();
                                list.Add(obj);
                            }
                            Console.WriteLine("Input Sucess...!");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\t\t\t================= Output====================");
                            foreach (Product_shop obj in list)
                            {
                                obj.Output();
                                Console.WriteLine("------------------------");
                            }
                            Console.WriteLine("output Sucess...!");
                        }
                        break;
                    case 3:
                        {
                            int sid;Boolean b = false;
                            Console.WriteLine("================= Search====================");
                            Console.Write("Search by ID=");
                            sid = int.Parse(Console.ReadLine());
                            foreach (Product_shop obj in list)
                            {
                                if(sid == obj.Id)
                                {
                                    obj.Output();
                                    b=true;
                                    Console.WriteLine("Search Sucesss...!");
                                }
                                
                            }
                            if(!b) Console.WriteLine("Search Not Sucesss...!");
                        }
                        break;
                    case 4:
                        {
                            int Search_item; 
                            Console.WriteLine("=================Find Index====================");
                            Console.Write("Find Index by ID=");
                            Search_item = int.Parse(Console.ReadLine());
                            int index = -1;

                            foreach(Product_shop obj in list)
                            {
                                if(obj.Id == Search_item)
                                {
                                    index = list.IndexOf(obj); 
                                }
                            }

                            if (index == -1)
                            {
                                Console.WriteLine("You can Not foun This ID..!");
                            }
                            else
                            {
                                Console.WriteLine("Finde at Index :" + index);
                            }
                        }
                        break;
                    case 5:
                        {
                            int Update; Boolean b = false;
                            Console.Write("Update By ID=");
                            Update = int.Parse(Console.ReadLine());
                            foreach (Product_shop obj in list)
                            {
                                if (Update == obj.Id)
                                {
                                   
                                    obj.Input();
                                    b = true;
                                    Console.WriteLine("Update Sucess...!");
                                    break;
                                }

                            }
                            if (!b) Console.WriteLine("Update Not Sucess...!");

                        }
                        break;
                    /* case 6:
                         {
                             int insert; Boolean b = false;
                             List<Product_shop> temp = new List<Product_shop>();

                             foreach(Product_shop myObj in list)
                             {
                                 temp.Add(myObj);
                             }

                             Console.Write("Insert By ID=");
                             insert = int.Parse(Console.ReadLine());
                             int getInsertedIndex = 0; 
                             for (int i = 0; i < size; i++)
                             {
                                 if (insert == list[i].Id)
                                 {


                                     getInsertedIndex = i;
                                     size++;

                                     b = true;
                                     break;

                                 }
                             }

                             if (b)
                             {
                                 temp.Add(new Product_shop());
                                 list.Add(new Product_shop());

                                 for (int i = 0; i < size; i++)
                                 {
                                     if (i == getInsertedIndex)
                                     {
                                         Product_shop obj = new Product_shop();
                                         obj.Input();
                                         list[i] = obj;
                                     }
                                     else
                                     { 
                                             list[i] = temp[i-1]; 
                                     }
                                 }
                                 Console.WriteLine("Insert  Sucess...!");
                             }
                             else 
                                 Console.WriteLine("Insert Not Sucess...!");

                         }
                         break;*/
                    case 6:
                        {
                            int sid; Boolean b = false;
                            Console.Write("Insert by ID=");
                            sid= int.Parse(Console.ReadLine());
                            list.Add(new Product_shop());
                            for(int i = 0; i < list.Count; i++)
                            {
                                if(sid== list[i].Id)
                                {
                                    for (int j = list.Count-1; j > i; j--)
                                    {
                                        list[j] = list[j-1];
                                        
                                    }

                                    list[i].Input();
                                    
                                    b = true;
                                    Console.WriteLine("Insert Success....!");
                                    break;
                                }
                            }
                            if (!b) Console.WriteLine("Insert Not Success....!");
                        }
                        break;
                    case 7:
                        {
                            int Delete_item;Boolean b = false;
                            Console.Write("Deleted by ID=");
                            Delete_item=int.Parse(Console.ReadLine());
                            for(int i = 0; i < list.Count; i++)
                            {
                                if(Delete_item == list[i].Id)
                                {
                                    list.Remove(list[i]);
;                                }
                            }
                            if(!b) Console.WriteLine("Deleted Not Data Sucess...!");

                        }
                        break;
                    case 8:
                        {
                            Boolean b = false;
                            for (int i = 0; i < list.Count; i++)
                            {
                                    for (int j = i+1; j < list.Count ; j++)
                                    {
                                    if (list[i].Id == list[j].Id)
                                    {
                                        list[list.Count-1] = list[j];
                                        b= true;
                                        Console.WriteLine("Sort  Success....!");
                                    }

                                    }
                                }
                            if (!b) Console.WriteLine("Sort Not Success....!");
                            Console.WriteLine("\t\t\t================= Output====================");
                            foreach (Product_shop obj in list)
                            {
                                
                                obj.Output();
                                Console.WriteLine("------------------------");
                            }
                            Console.WriteLine("output Sucess...!");
                        }
                        break;
                }
                Console.ReadKey();
            } while (op != 0);

        }
    }
}
