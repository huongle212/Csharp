using System;
using System.Collections.Generic;

namespace Ex3_
{
    class Program
    {
        static int InputInt(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    int rs = int.Parse(Console.ReadLine());
                    return rs;
                }
                catch (Exception ex)
                {
                    Console.Write("Invalid input, try again! Please input an integer. \n");
                }
            }
        }

        static List<int> InputListInt()
        {
            List<int> list = new List<int>();
            int n =InputInt("Number of element: ");
            for(int i = 0; i < n; i++)
            {
                int a = InputInt("Element " + i +" : ");
                list.Add(a);
            }
            return list;   
        }

        static void ShowList(List<int> list)
        {
            Console.Write("\t");
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        static List<int> MergeList(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();
            if (list1.Count > list2.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    result.Add(list1[i]);
                    result.Add(list2[i]);
                }
                for (int i = list2.Count; i < list1.Count; i++)
                    result.Add(list1[i]);
            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    result.Add(list1[i]);
                    result.Add(list2[i]);
                }
                for (int i = list1.Count; i < list2.Count; i++)
                    result.Add(list2[i]);
            }
            
            return result;
        }

        static void Main(string[] args)
        {
            List<int> list1, list2, list3;
            Console.WriteLine("Input elements of List 1: ");
            list1 = InputListInt();
            Console.WriteLine("Input elements of List 2: ");
            list2 = InputListInt();
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Result: ");
            Console.WriteLine("\n\tList 1: ");
            ShowList(list1);
            Console.WriteLine("\n\tList 2: ");
            ShowList(list2);
            Console.WriteLine("\n\tResult:");
            list3 = MergeList(list1, list2);
            ShowList(list3);
            Console.ReadLine();
        }
    }
}
