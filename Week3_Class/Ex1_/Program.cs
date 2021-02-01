using System;
using System.Collections.Generic;

namespace Ex1_
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
            int n = InputInt("Number of element: ");
            for (int i = 0; i < n; i++)
            {
                int a = InputInt("Element " + i + " : ");
                list.Add(a);
            }
            return list;
        }

        static void ShowList(List<int> list)
        {
            Console.Write("\t");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        static List<int> SumAdj(List<int> list)
        {
            List<int> result = new List<int>();
            int j = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int temp = list[i];
                int index = j;
                while (i < list.Count - 1 && temp == list[i + 1])
                {
                    i++;
                    temp += list[i];
                    while (j > 0 && temp == result[j - 1])
                    {
                        temp += result[j - 1];
                        j--;
                    }
                }
                if (j ==index)
                {
                    if (j == result.Count) result.Add(temp);
                    else result[index] = temp;
                    j++;
                }
                else
                {
                    result[j] = temp;
                    j++;
                }

            }
            while (j + 1 < result.Count)
            {
                result.RemoveAt(j + 1);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("List: ");
            List<int> list = InputListInt();
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Result: ");
            ShowList(list);
            Console.Write("\t=>");
            List<int> result = SumAdj(list);
            ShowList(result);
            Console.ReadLine();
        }
    }
}
