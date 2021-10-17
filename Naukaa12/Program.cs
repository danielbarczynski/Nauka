using System;

namespace Naukaa12
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Alice", 19);
            Player player2 = new Player();

            player1.PrintInfo();
            player2.PrintInfo();

        }
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

            public Player(string n, int a) // n - name a - age
            {
                age = Math.Max(a, 0);
                name = n;
            }


            // Method - print info


            public void PrintInfo()
            {
                Console.WriteLine("{0}, {1}", name, age);

            }
        }
    }
}
