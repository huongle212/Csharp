using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Quadratic
{
    class quadratic
    {
        public static void bacNhat(double a,double b) {
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("=> Infinity solution.");
                else Console.WriteLine("=> No solution.");
            }
            else {
                double x = -b / a;
                Console.WriteLine("=> Solution: {0:F2}", x);
            }

        }

        public static void bacHai(double a, double b,double c)
        {
            double x1, x2;
            if (a == 0)
            {
                bacNhat(b,c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("=> No solution.");
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("=> Solution: x1=x2={0}", x1);
                }
                else {
                    x1 = (-b- Math.Sqrt(delta))/(2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("=> Solution: x1={0:F5} and x2={1:F5}", x1,x2);
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Equation: {0}x^2+{1}x+{2}=0",a,b,c);
            bacHai(a, b, c);
            Console.ReadLine();
        }
    }
}
