using System;

namespace Naukaa12
{
    class Program
    {
        
        class Player
        {
            // Fields

            int age;
            public string name;

            // Constructor, no parameters

            public Player() // bez void, long, bo nigdy nic nie zwraca, on wspomaga - konstruktor
            {
                age = 1;
                name = "Anonymous";
            }

            // Constructor, with parameters

            public Player(string n, int a) // n - name a - age, #1 odwolanie na koncu
            {
                age = Math.Max(a, 0);
                name= n;
            }


            // Method - print info


            public void PrintInfo()
            {
                Console.WriteLine("{0}, {1}", name, age);

            }
            static void Main(string[] args)
            {
                Player player1 = new Player("Alice", 19); // sa przypisane dwa typy alice i 19 wiec #1 musi miec string n i int a
                Player player2 = new Player();

                player1.PrintInfo();
                player2.PrintInfo();

            }
        }
    }
}
