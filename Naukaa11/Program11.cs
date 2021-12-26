 using System;

namespace Naukaa11
{
    class Program11
    {
        static void Main(string[] args)
        {
            Player player1 = new (); // player player1 - powołaj, new player - utworz
            Player player2 = new (); // powoływanie nowej klasy, czyli stworzenie instancji nowego obiektu

            player1.name = "Alice";
            player1.SetAge(19);
            player2.name = "Bob";
            player2.SetAge(-22);

            //Cat cat1 = new ();
            Cat cat1;
            cat1 = new Cat();
            
            cat1.Name = "Kotek";
            cat1.Age = 10;

             

            Console.WriteLine("cat name is {0} and its age is {1}", cat1.Name, cat1.Age);
        }
    }

    public class Player
    {
        // Fields (if no "=", automatically set to default: int -> 0, string -> "")

        internal int age; // private (by default) - no access outside, prywatne dane //@UPDATE: ZMIENONE NA INTERNAL NA POTRZEBY PROJEKTU
        public string name; // public - free access outside, publiczne dane
                           
        public void SetAge(int a) // void czyli nie zwraca nic
        {
            age = Math.Max(a, 0); // choose higher number inside brackets so there is no negative numbers
            Console.WriteLine("{0} is {1} years old.", name, age);
        }
    }

    class Cat
    {
        public string Name;
        public int Age;
    }
}
