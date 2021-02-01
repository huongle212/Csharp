using MyBookLibrary;
using System;

namespace PRN292_Lab2
{
    class Program
    {
        public static int InputInt(string s, int min, int max)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    int rs = int.Parse(Console.ReadLine());
                    if (rs < min || rs > max)
                    {
                        Console.WriteLine($"Input out of range [{min},{max}]");
                        throw new Exception("Out of range");
                    }
                    return rs;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Please input an integer in range [{min},{max}], try again!");
                }
            }
        }

        static void Main(string[] args)
        {
            BookLibrary bookLibrary = new BookLibrary();
            while (true)
            {
                Console.WriteLine("======== BOOK MANAGER ========");
                Console.WriteLine("1.Add book");
                Console.WriteLine("2.Update book");
                Console.WriteLine("3.Delete book");
                Console.WriteLine("4.List all book");
                Console.WriteLine("5.Sort");
                Console.WriteLine("6.Clear Console");
                Console.WriteLine("7.EXIT");
                Console.WriteLine("------------------------------");
                int choice = InputInt("Select your choice: ", 1, 7);
                switch (choice)
                {
                    case 1:
                        bookLibrary.InputList();
                        break;
                    case 2:
                        bookLibrary.UpdateBook();
                        break;
                    case 3:
                        bookLibrary.DeleteBook();
                        break;
                    case 4:
                        bookLibrary.ShowList();
                        break;
                    case 5:
                        bookLibrary.SortBook();
                        bookLibrary.ShowList();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7: return;
                }
            }
        }
    }
}
