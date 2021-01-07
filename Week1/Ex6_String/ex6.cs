using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_String
{
    class ex6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            int upper = 0, lower = 0, blank = 0, digit = 0, other = 0;
            foreach(char c in chars){
                if (char.IsWhiteSpace(c))
                    blank++;
                else if (char.IsUpper(c))
                    upper++;
                else if (char.IsLower(c))
                    lower++;
                else if (char.IsDigit(c))
                    digit++;
                else other++;
            }
            Console.WriteLine("=> Total character: {0}",str.Length);
            Console.WriteLine("with {0} upper characters, {1} lower characters, {2} digits, {3} blank",upper,lower,digit,blank);
            Console.ReadLine();
        }
    }
}
