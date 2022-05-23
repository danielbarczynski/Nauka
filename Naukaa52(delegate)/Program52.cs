using System;

namespace Naukaa52_delegate_
{
    public delegate void Delegate(string message);
    public delegate void Delegatee(string text);

    internal class Program52
    {
        static void Main(string[] args)
        {

            Delegatee delegatee = delegate (string text) // funkcja anonimowa
            {
                Console.WriteLine(text);
            };


            delegatee("whatever");

            //-----------------------------------------------------------------

            Delegate Delegate, Delegate2, Delegate3, Delegate4;

            Delegate del = new Delegate(Hello);
            Delegate = new Delegate(Hello); // delegacja zawsze bierze w nawiasy nazwe funckji, zamiast typ i nazwe zmiennej
            Delegate2 = new Delegate(HowAreYou);
            Delegate3 = new Delegate(Goodbye);

            Delegate4 = Delegate + Delegate2 + Delegate3;
            Delegate4("Daniel");
            del("yo");

            del = delegate (string x) // type void as delegate
            {
                Console.WriteLine($"Anonymous function {x}");
            };

            del("confirmed");

        }

        public static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.ReadLine();
        }

        public static void HowAreYou(string name)
        {
            Console.WriteLine($"How are you {name}?");
            Console.ReadLine();
        }

        public static void Goodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}!");
            Console.ReadLine();
        }
    }
}
