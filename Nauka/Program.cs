using System;

namespace Nauka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random legi = new Random();

            int x = legi.Next(0, 2000);
            int y = legi.Next(0, 2000);

            Console.WriteLine("x: {0}" + "\ny: {1}", x, y);

            if (x < y)
            {
                Console.WriteLine("y większe");
            }
            else if (x > y)
            {
                Console.WriteLine("x większe");
            }
            else if (x == y)
            {
                Console.WriteLine("x i y równe");
            }
            else if (x == 1)
            {
                Console.WriteLine("spadła lega!");
            }

            int m = 10;
            int n = legi.Next(0,20);

            Console.WriteLine("\nm: {0}" + "\nn: {1}", m, n);

            bool w = m > n;

            if (w)
                Console.WriteLine("m większe");
            else
                Console.WriteLine("\nn większe");

            string p = Console.ReadLine();
            char d = Console.ReadKey().KeyChar;
            
            Console.WriteLine("\n" + p + d + d);


        }
    }
}
