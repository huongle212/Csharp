using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Sum2Num
{
    class sum
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Input a=");
			float a;
			a = float.Parse(Console.ReadLine());
			Console.WriteLine("Input b=");
			float b;
			b = float.Parse(Console.ReadLine());
			float sum = a + b;
			// 2 cach in bien
			Console.WriteLine($"Sum of {a} and {b} is {sum}");
			Console.ReadLine();
		}
	}
}
