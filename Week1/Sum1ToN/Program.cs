using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
			//sum 1 to n
			int n;
			Console.WriteLine("Input n= ");
			n = int.Parse(Console.ReadLine());
			while (n < 1)
			{
				Console.WriteLine("Please enter n>=1, n=");
				n = int.Parse(Console.ReadLine());
			}
			int sum = 0;
			for (int i = 1; i <= n; i++)
			{
				sum += i;
			}
			Console.WriteLine("Sum 1 to {0} is {1}",n,sum);
		}
    }
}
