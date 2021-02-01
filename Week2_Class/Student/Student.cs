using System; //class student

namespace Student
{
    class Student : Person
    {
        private double gpa;

        public Student()
        {
        }

        public Student(int age, string name) : base(age, name)
        {
        }

        public Student(double gpa, int age, string name) :base(age,name)
        {
            this.gpa = gpa;
        }

        internal double Gpa { get { return gpa; } set { if(value>=0 && value<=10) gpa = value; } }

        public override void DisplayPerson()
        {
            base.DisplayPerson();
            Console.WriteLine("GPA: {0:F2}",gpa);
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter GPA: ");
            Gpa = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Student [ " + name + ", " + age +", "+gpa+"]";
        }
    }
}
