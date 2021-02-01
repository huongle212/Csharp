using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CompareTo
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 9, n2 = 5;
            Console.WriteLine(n1.CompareTo(n2));
            
            n1 = 5; n2 = 5;
            Console.WriteLine(n1.CompareTo(n2));

            string s1 = "Annnnnnnnnn", s2 = "Bình";
            Console.WriteLine(s1.CompareTo(s2));

            Console.WriteLine(string.Compare(s1, s2));

            float f1 = 3.2f, f2 = 5.5f;
            Console.WriteLine(f1.CompareTo(f2));

            Console.ReadLine();

        }
    }
}
