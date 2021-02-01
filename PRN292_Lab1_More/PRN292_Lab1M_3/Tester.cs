using System;
using System.Collections;
using System.Collections.Generic;

namespace PRN292_Lab1M_3
{
    public class People
    {
        protected string name;
        protected int age;

        protected string Name { get => name; set => name = value; }
        protected int Age { get => age; set { if (value > 0 && value < 200) age = value; } }

        public People()
        {
            name = "Nguyen Van A";
            age = 1;
        }

        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public People(People p)
        {
            name = p.Name;
            age = p.Age;
        }
        

        public virtual void Show()
        {
            Console.WriteLine("\tName: " + name);
            Console.WriteLine("\tAge: " + age);
        }
    }

    public class Student : People
    {
        private int sid;
        private string faculty;
        private double mark;

        public int Sid { get => sid; set => sid = value; }

        public string Faculty { get => faculty; set => faculty = value; }

        public double Mark { get => mark; set { if (value >= 0 && value <= 10) mark = value; } }

        public Student():base()
        { // default constructor
            sid = 1;
            faculty = "IT";
            mark = 0;
        }

        public Student(int sid, string faculty, double mark, string name,int age):base(name,age)
        {// constructor for create new
            this.sid = sid;
            this.faculty = faculty;
            Mark = mark;
        }

        public Student(Student st):base(st) // constructor for copy
        {
            sid = st.sid;
            faculty = st.faculty;
            mark = st.mark;
        }

        public override void Show()
        {
            Console.WriteLine("\tSID: " + sid);
            base.Show();
            Console.WriteLine("\tFaculty: " + faculty);
            Console.WriteLine("\tMark: {0:F2}", mark);
        }
    }

    class Tester
    {
        static int InputInt(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    int rs = int.Parse(Console.ReadLine());
                    return rs;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input must be integer, try again!");
                }
            }
        }

        static double InputDouble(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    double rs = double.Parse(Console.ReadLine());
                    return rs;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input must be a number, try again!");
                }
            }
        }

        static string InputString(string s)
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
                    Console.WriteLine("Invalid Input, try again!");
                }
            }
        }

        static void InputStuList(ref int n, ref List<People> list)
        {
            Console.WriteLine("Number of students: ");
            n = InputInt("\tn = ");
            if (n > 0)
            {
                list = new List<People>();
                Console.WriteLine("--------- Input Student List---------");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\n\tStudent {0}", (i + 1));
                    int sid = InputInt("SID = ");
                    string name = InputString("Name = ");
                    int age = InputInt("Age = ");
                    string fal = InputString("Faculty = ");
                    double mark = InputDouble("Mark = ");
                    while (mark < 0 || mark > 10)
                    {
                        Console.WriteLine("Mark >= 0 and <=10, try again!");
                        mark = InputDouble("Mark = ");
                    }
                    list.Add(new Student(sid, fal, mark, name, age));
                }
                Console.WriteLine("------------------------------------\n\n");
            }
        }

        static void DisplayList(List<People> list, int n)
        {
            if (n > 0)
            {
                Console.WriteLine("=============== STUDENT LIST ===============");
                foreach (People p in list)
                {
                    if (p is Student)
                    {
                        Console.WriteLine("- Student " + (list.IndexOf(p) + 1));
                    }
                    else
                    {
                        Console.WriteLine("- People " + (list.IndexOf(p) + 1));
                    }
                    p.Show();
                }
            }
            else Console.WriteLine("Empty List!");
        }

        static void Main(string[] args)
        {
            
            List<People> list=new List<People>();
            int n = 0;
            InputStuList(ref n, ref list);
            DisplayList(list, n);
            Console.Write("\nPress any key to exit!");
            Console.ReadLine();
        }
    }
}