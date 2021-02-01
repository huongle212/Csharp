using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = new List<int>();
            //add element
            listInt.Add(2);
            listInt.Add(29);
            listInt.Add(14);
            //print list
            foreach (int item in listInt)
                Console.WriteLine(item);
            listInt.Sort();
            listInt.Reverse();
            listInt.Remove(29);
            listInt.RemoveAt(0);
            listInt.Insert(1, 6);
            //print list
            for (int i = 0; i < listInt.Count; i++)
                Console.WriteLine(listInt[i]);
            Console.ReadLine();
        }
    }
}
