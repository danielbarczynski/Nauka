using System;

namespace Nauka10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 7;
            Console.WriteLine("Before: a = {0}, b = {1}", a, b);

            Interchange(ref a, ref b);
            Console.WriteLine("After: a = {0}, b = {1}", a, b);
        }

        static void Interchange(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
