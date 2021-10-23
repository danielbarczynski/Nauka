using System;
namespace Ex_05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Alice", 19);
            player1.PrintInfo();

            Cat cat1 = new Cat("Kotek1", 10);
            Console.WriteLine("{0}, {1}", cat1.Name, cat1.Age);
            cat1.PrintInfo();
            player1.Salary = 300;
           

        }
    }
    /**********************************************************************/
    class Player
    {
        // Fields
        int age; // small age
        string name;

        // Properties

        public int Age { get => age; set => age = Math.Max(value, 0); } // big age
        public string Name { get => name; set => name = value; }

        public int Salary { get; set; }

        // public string Name { get; set; }
        // public int P1 { get; } // Read only property
        // public int P2 { get; private set; } // Read only outside, modifiable inside
        // Constructor, no parameters

        public Player()
        {
            Age = 1;
            Name = "Anonymous";
        }
        // Constructor, with parameters
        public Player(string n, int a)
        {
            Age = Math.Max(a, 0);
            Name = n;
        }
        // Method
        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}", Name, Age);
        }
    }
    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Cat(string n, int a)
        {
            Age = a;
            Name = n;
        }
        public void PrintInfo()
        {
            Console.WriteLine("{0}, {1}", Name, Age);
        }

    }
  
}