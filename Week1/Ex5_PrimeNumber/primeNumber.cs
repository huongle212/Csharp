using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PrimeNumber
{
    class primeNumber
    {

        public static bool checkPrime(int n) {
            if (n == 2) return true;
            else if (n > 1 && n % 2 != 0)
            {
                int t = (int)Math.Sqrt(n);
                for (int i = 3; i <= t; i+=2)
                    if (n % i == 0) return false;
            }
            else return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 2) {
                Console.WriteLine("Please enter number greater than 2, enter again:");
                n= int.Parse(Console.ReadLine());
            }
            if (checkPrime(n))
                Console.WriteLine("{0} is a prime number.", n);
            else Console.WriteLine("{0} is not a prime number.", n);
            Console.ReadLine();
        }
    }
}
