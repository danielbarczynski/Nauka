using System;

namespace Nauka10
{
    class Program10
    {
        static void Main(string[] args)
        {
            SayHi("maciek ", 12);// method can be just used like this lol
            SayHi("kuba ", 15);
            SayHi("tomek ", 18);
            int a = 3, b = 7;
            Console.WriteLine("Before: a = {0}, b = {1}", a, b);

            Interchange(ref a, ref b);
            Console.WriteLine("After: a = {0}, b = {1}", a, b);
            Console.ReadLine();
        }

        static void Interchange(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("hi " + name + age);
        }
        
    }
}
