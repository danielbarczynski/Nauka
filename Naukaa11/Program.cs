using System;

namespace Naukaa11
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(); // plaer player1 - powołaj, new player - utworz
            Player player2 = new Player();

            player1.name = "Alice";
            player1.SetAge(19);
            player2.name = "Bob";
            player2.SetAge(5);
        }
    }

    class Player
    {
        // Fields (if no "=", automatically set to default: int -> 0, string -> "")

        private int age; // private (by default) - no access outside, prywatne dane
        public string name; // public - free access outside, publiczne dane
                           
        public void SetAge(int a) // void czyli nie zwraca nic
        {
            age = Math.Max(a, 0); // sets a if +ve, or 0 otherwise
            Console.WriteLine("{0} is {1} years old.", name, age);
        }
    }
}
