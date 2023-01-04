using System;

namespace Naukaa31
{
    class Program
    { 
        static void Main(string[] args)
        {

            Cow cow1 = new("betsy"); // without constructor (initializer) Cow cow1 = new() {Name = "Besty", Age = 5}; because of get set
            Cow cow2 = new("hammley", 7);

            Console.WriteLine($"{cow1.Name}");
            Console.WriteLine($"{cow2.Name}{cow2.Age}");

            GetPrinted();

            Console.WriteLine(cow1.FullCow() + " oraz " + cow2.FullCow());

        }

        public static void GetPrinted()
        {
            Console.WriteLine("456");
        }
    }
    class Cow // this occurs only in current class while base in parent (inherited) class
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cow(string Name)
        {
            this.Name = Name;
        }
        public Cow(string Name, int Age) : this(Name)
        {
            this.Age = Age;
        }
        public string FullCow()
        {
            return $"imie: {Name} wiek: {Age}";
        }
    }
}