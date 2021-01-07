using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Compute
{
    class calculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Operation: ");
            string op = Console.ReadLine();
            while (op.Length > 1) {
                Console.WriteLine("Operation is character, enter again: ");
                op = Console.ReadLine();
            }
            char operation = op[0];
            float result=0;
            switch (operation) {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Can not divide with b==0");
                        Console.ReadLine();
                        System.Environment.Exit(1);
                    }
                    else {
                        result = (float)a / b;
                    }
                    break;
                default:
                    Console.WriteLine("Operation is invalid!");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                    break;
            }
            Console.WriteLine("{0} {1} {2}={3:F2}",a,operation,b,result);
            Console.ReadLine();
        }
    }
}
