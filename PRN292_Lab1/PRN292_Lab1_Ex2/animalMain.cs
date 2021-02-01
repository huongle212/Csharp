using System; //class main


namespace PRN292_Lab1_Exercise2
{
    //animal
    public abstract class Animal
    {
        protected string type;
        protected string name;

        protected Animal(string type, string name)
        {
            this.type = type;
            this.name = name;
        }

        internal string Type { get => type; set => type = value; }

        internal string Name { get => name; set => name = value; }

        public abstract string getSound();

        public abstract string getInformation();

        public override string ToString()
        {
            return name + " - " + type;
        }
    }

    //dog
    public class Dog : Animal
    {
        private string breed; //one of values such as Spaniel, Chihuahua, and Collie,...

        public Dog(string breed, string type, string name) : base(type, name)
        {
            this.breed = breed;
        }

        internal string Breed { get => breed; set => breed = value; }

        public override string getInformation()
        {
            return "loyal to the owner.";
        }

        public override string getSound()
        {
            return "woow woow";
        }

        public override string ToString()
        {
            return "Dog [ type : " + type + " - name : " + name + " - breed : " + breed + "]\n=> says " + getSound() + " and " + getInformation();
        }
    }

    //cat
    public class Cat : Animal
    {
        public Cat(string type, string name) : base(type, name) { }

        public string climb()
        {
            return "tree";
        }

        public override string getInformation()
        {
            return "very painful pawns";
        }

        public override string getSound()
        {
            return "meo meo";
        }

        public override string ToString()
        {
            return "Cat [ type : " + type + " - name : " + name + " - climb : " + climb() + "]\n=> says " + getSound() + " and " + getInformation();
        }
    }

    //duck
    public class Duck : Animal
    {
        public Duck(string type, string name) : base(type, name) { }

        public string swim()
        {
            return "lake";
        }

        public override string getInformation()
        {
            return "have wings";
        }

        public override string getSound()
        {
            return "cap cap";
        }

        public override string ToString()
        {
            return "Duck [ type : " + type + " - name : " + name + " - swim : " + swim() + "]\n=> says " + getSound() + " and " + getInformation();
        }
    }

    //main class
    class animalMain
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Chollie", "Mammal", "Kiki");
            Cat cat = new Cat("Mammal", "Milu");
            Duck duck = new Duck("Bird", "Donald");

            Console.WriteLine(dog.ToString());
            Console.WriteLine("\n" + cat.ToString());
            Console.WriteLine("\n" + duck.ToString());
            Console.ReadLine();
        }
    }
}
