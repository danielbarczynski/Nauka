using System;

namespace Nauka8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("Enter y:");
            int.TryParse(Console.ReadLine(), out int y);

            try // dodajemy jak nie jestesmy pewni czy kod jest dobry
            { 
            int result = x / y;
            Console.WriteLine("\n" + result);
            }
            catch // tu ladujemy, jesli w try wyskoczy exception (wyjatek, blad), moze być konkretny np catch (DivideByZeroExpection) możemy mu dać także nazwę
            {
                Console.WriteLine("\nError");
            }
            finally // wykona sie zawsze, nawet jak wyskoczy jakis nieobslugiwany wyjatek czyli catch nie wylapie
            {
                Console.WriteLine("\nThis is always executed. Closing the app.");
            }
            // i tu dalszy kod jak mamy ochote

            int p = 20;
            int o = 5;
            int l = p / o;
            Console.WriteLine(l);

        }
    }
}
