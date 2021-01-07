using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Sum1perN
{
    class sum1perN
    {
        static void Main(string[] args)
        {
			//sum 1+1/2+...+1/n
			int n;
			Console.WriteLine("Input n= ");
			n = int.Parse(Console.ReadLine());
			while (n<1)
			{
				Console.WriteLine("Please enter n>=1, n=");
				n = int.Parse(Console.ReadLine());
			}
			float sum = 0;
			for (int i = 1; i <= n; i++)
			{
				sum += (float)1/i;
			}
			Console.WriteLine("Sum is {1:F2}", n, sum);
			Console.ReadLine();
		}
    }
}
