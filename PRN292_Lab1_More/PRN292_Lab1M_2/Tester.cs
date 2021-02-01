using System;

namespace PRN292_Lab1M_2
{
    public class Student
    {
        private int sid;
        private string name;
        private string faculty;
        private double mark;

        public Student()
        { // default constructor
            sid = 1;
            name = "Nguyen Van A";
            faculty = "IT";
            mark = 0;
        }

        public Student(int sid, string name, string faculty, double mark)
        {// constructor for create new
            this.sid = sid;
            this.name = name;
            this.faculty = faculty;
            SetMark(mark);
        }

        public Student(Student st) // constructor for copy
        {
            this.sid = st.sid;
            this.name = st.name;
            this.faculty = st.faculty;
            this.mark = st.mark;
        }

        public int GetSid()
        {
            return sid;
        }


        public void GetSid(int value)
        {
            sid = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }


        public string GetFaculty()
        {
            return faculty;
        }

        public void SetFaculty(string value)
        {
            faculty = value;
        }

        public double GetMark()
        {
            return mark;
        }

        public void SetMark(double value)
        {
            if(value>=0 && value<=10) mark = value;
        }

        public void Show()
        {
            Console.WriteLine("\tSID: " + sid);
            Console.WriteLine("\tName: " + name);
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

        static void InputStuList(ref int n,ref Student[] list)
        {
            Console.WriteLine("Number of students: ");
            n = InputInt("\tn = ");
            if (n > 0)
            {
                list = new Student[n];
                Console.WriteLine("--------- Input Student List---------");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\n\tStudent {0}", (i + 1));
                    int sid = InputInt("SID = ");
                    string name = InputString("Name = ");
                    string fal = InputString("Faculty = ");
                    double mark = InputDouble("Mark = ");
                    while (mark < 0 || mark > 10)
                    {
                        Console.WriteLine("Mark >= 0 and <=10, try again!");
                        mark = InputDouble("Mark = ");
                    }
                    list[i] = new Student(sid, name, fal, mark);
                }
                Console.WriteLine("------------------------------------\n\n");
            }
        }

        static void DisplayList(Student[] list,int n)
        {
            if (n > 0)
            {
                Console.WriteLine("\t\tSTUDENT LIST");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nStudent " + (i + 1));
                    list[i].Show();
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] list=new Student[1];
            int n=0;
            InputStuList(ref n, ref list);
            DisplayList(list, n);
            Console.ReadLine();
        }
    }
}