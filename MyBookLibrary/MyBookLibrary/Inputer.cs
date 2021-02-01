using System;

namespace MyBookLibrary
{
    class Inputer
    {
        public static int InputInt(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    int rs = int.Parse(Console.ReadLine());
                    return rs;
                }
                catch (Exception ex)
                {
                    Console.Write("Invalid input, try again! Please input an integer. \n");
                }
            }
        }

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

        public static double InputDouble(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    double rs = Double.Parse(Console.ReadLine());
                    return rs;
                }
                catch (Exception ex)
                {
                    Console.Write("Invalid input, try again!Please input a number. \n" + ex);
                }
            }
        }

        public static double InputDouble(string s,double min)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    double rs = Double.Parse(Console.ReadLine());
                    if (rs < min) throw new Exception();
                    return rs;
                }
                catch (Exception ex)
                {
                    Console.Write($"Invalid input, try again!Please input a number greater than {min}. \n");
                }
            }
        }

        public static string InputString(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    string rs = Console.ReadLine().Trim();
                    if (rs.Length == 0) throw new Exception();
                    return rs;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Can not be empty, try again!");
                }
            }
        }
    }
}
