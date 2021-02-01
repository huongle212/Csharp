using System;

namespace PRN292_Lab1M_1_Student
{
    public class Student
    {
        private int sid { get; set; }
        private string name { get; set; }
        private string faculty { get; set; }
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
            Mark = mark;
        }

        public Student(Student st) // constructor for copy
        {
            this.sid = st.sid;
            this.name = st.name;
            this.faculty = st.faculty;
            this.mark = st.mark;
        }

        public double Mark{get => mark;set => mark = value;  }

        public void Show()
        {
            Console.WriteLine("\tSID: " + sid);
            Console.WriteLine("\tName: " + name);
            Console.WriteLine("\tFaculty: " + faculty);
            Console.WriteLine("\tMark: {0:F2}", mark);
        }
    }
}
