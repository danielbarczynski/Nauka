using System;
namespace Ex_05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Alice", 19);
            player1.PrintInfo();
        }
    }
    /**********************************************************************/
    class Player
    {
        // Fields
        int age;
        string name;

        // Properties

        public int Age { get => age; set => age = Math.Max(value, 0); }
        public string Name { get => name; set => name = value; }

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
}