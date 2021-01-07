using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Game
{
    class game
    {

        public static int randomNumber(int min, int max) {
            Random rd = new Random();
            int n = rd.Next(min, max);
            return n;
        }

        public static bool play(int answer) {
            int turn = 0;
            bool win = false;
            while (turn < 7 && !win) {
                turn++;
                Console.WriteLine("Your turn: {0}",turn);
                Console.WriteLine("Enter guest number: ");
                int n = int.Parse(Console.ReadLine());
                if (n == answer) win = true;
                else if (n < answer)
                    Console.WriteLine("Your guest is smaller than answer.");
                else
                    Console.WriteLine("Your guest is greater than answer.");
            }
            return win;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Click any keys to start game! Exit '0'");
            string start = Console.ReadLine();
            if(start.Equals("0"))
                System.Environment.Exit(1);
            while (true) {
                Console.Clear();
                int n=randomNumber(1,101);
                if (play(n)) {
                    Console.WriteLine("You win!");
                }else Console.WriteLine("You lose!");
                Console.WriteLine("Do you want to continue? If no, enter 'No'.");
                string cont= Console.ReadLine();
                if (cont.Equals("No"))
                    System.Environment.Exit(1);
            }
        }
    }
}
