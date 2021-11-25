using System;

namespace Nauka8
{
    class Program8
    {
        static void Main(string[] args)
        {

            try
            {
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(n1 / n2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //nie trzeba nawet nic pisac w catch, nie zawiesi juz programu

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
