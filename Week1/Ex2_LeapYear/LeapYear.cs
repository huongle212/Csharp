using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year: ");
            int year;
            year = int.Parse(Console.ReadLine());
            bool leapYear = false;
            if (year % 4 == 0) {
                leapYear = true;
                if (year % 100 == 0) {
                    if (year % 400 == 0)
                        leapYear = true;
                    else leapYear = false;
                }
            }

            if (leapYear){
                Console.WriteLine("{0} is leap year.",year);
            }else Console.WriteLine("{0} is not leap year.",year);
            Console.ReadLine();
        }
    }
}
