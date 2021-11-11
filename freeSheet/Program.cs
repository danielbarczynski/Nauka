using System;

namespace freeSheet
{
    class Program
    {

        public const int value = 10;
        public static readonly int valuee; // has to be static to be available, nie trzeba przypisywać wartości
        

        static void Main(string[] args)
        {
            
            Console.WriteLine(value);
            Console.WriteLine(valuee);
        }
    }
}
