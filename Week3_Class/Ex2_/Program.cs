using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_
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

        static List<int> SumFirstLast(List<int> list)
        {
            List<int> result = new List<int>();
            int len = list.Count;
            int n = (len + 1) / 2;
            for (int i = 0; i < n; i++)
            {
                int temp = (list[i]+list[len-i-1]);
                result.Add(temp);
            }
            if (len % 2 != 0)
            {
                result[n-1] = result[n-1] / 2;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input list: ");
            List<int> list=InputListInt();
            List<int> result = SumFirstLast(list);
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Result: ");
            ShowList(list); 
            Console.Write("\t=>");
            ShowList(result);
            Console.ReadLine();
        }
    }
}
