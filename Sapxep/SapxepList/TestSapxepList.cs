using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapxepList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> ListString = new List<string>();
            ListString.Add("An");
            ListString.Add("Nam");
            ListString.Add("Bình");
            Console.WriteLine("Danh sách trước khi sắp xếp");
            foreach (string st in ListString)
            {
                Console.WriteLine(st);
            }
            ListString.Sort();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Danh sách sau khi sắp xếp");
            foreach (string st in ListString)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();
        }
    }
}
