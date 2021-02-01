using System;
using System.Collections.Generic;

namespace PRN292_Lab1M_1_Student
{
    class Tester
    {
        static int inputInt(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    int rs=int.Parse(Console.ReadLine());
                    return rs;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input must be integer, try again!");
                }
            }
        }

        static double inputDouble(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    double rs= double.Parse(Console.ReadLine());
                    return rs;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input must be a number, try again!");
                }
            }
        }

        static string inputString(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    string temp = Console.ReadLine().Trim();
                    if (temp.Length == 0) throw new Exception("Empty string"); 
                    return temp;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, try again!");
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] list;
            int n;
            Console.WriteLine("Number of students: ");
            n = inputInt("\tn = ");
            if (n > 0)
            {
                list = new Student[n];
                Console.WriteLine("--------- Input Student List---------");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\n\tStudent {0}", (i + 1));
                    int sid = inputInt("SID = ");
                    string name = inputString("Name = ");
                    string fal = inputString("Faculty = ");
                    double mark = inputDouble("Mark = ");
                    while (mark < 0 || mark > 10)
                    {
                        Console.WriteLine("Mark >= 0 and <=10, try again!");
                        mark = inputDouble("Mark = ");
                    }
                    list[i] = new Student(sid, name, fal, mark);
                }
                Console.WriteLine("------------------------------------\n\n");
                Console.WriteLine("\t\tSTUDENT LIST");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nStudent " + (i + 1));
                    list[i].Show();
                }
            }
            
/*            if (n > 0)
            {

                foreach (Student st in list)
                {
                    Console.WriteLine("\nStudent " + (list.IndexOf(st) + 1));
                    st.Show();
                }
            }*/
            Console.ReadLine();
        }
    }
}