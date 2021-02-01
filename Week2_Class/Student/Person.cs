using System; //class person

namespace Student
{
    public class Person
    {
        protected int age;
        protected string name;

        public Person()
        {
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public int Age { get {return age; } set { if(value>0 && value<200) age = value; } }

        public string Name { get => name; set => name = value; }

        public virtual void DisplayPerson()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

        public virtual void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Person [ " + name + ", " + age + "]";
        }
    }
}
