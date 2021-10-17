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
            
            Console.WriteLine("x={0}, y={1}", x, y);

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
            int n = 5;

            bool w = m > n;

            if (m < n)
                Console.WriteLine("m bigger");
            else
                Console.WriteLine("m not bigger");
       


        }
    }
}
