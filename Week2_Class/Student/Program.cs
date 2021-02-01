using System; //class program

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Huong"; //call set method
            person.Age = -5;
            Console.WriteLine("Age: "+ person.Age);//call get method
            //input person information
            Console.WriteLine("\n------ Input Person Information ------");
            person.Input();
            Console.WriteLine("\n------ Person Information ------");
            person.DisplayPerson();

            Student student = new Student();
            //input student information
            Console.WriteLine("\n------ Input Student Information ------");
            student.Input();
            Console.WriteLine("\n------ Student Information ------");
            student.DisplayPerson();

            Console.ReadLine();
        }
    }
}
