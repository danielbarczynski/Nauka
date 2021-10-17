using System;

namespace Nauka3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a, printNumber = 0;

            while (printNumber < 51)   // while (end)
            {
                a = rnd.Next(0, 100);
                if (a % 2 == 0) // czy podzielna przez 2, czy wychodzi jej 0 reszty, jesli tak, zapisz
                {
                    printNumber++;
                    Console.WriteLine("number {0}: (even) {1}", printNumber, a);
                }
                if (a % 3 == 0)
                {
                    printNumber++;
                    Console.WriteLine("number {0}: (odd) {1}", printNumber, a);
                }
                else
                    continue;
                
            }
       
            //----------------------------------------------------------------------------------------

            do // NAJPIERW ROBI, POTEM SPRAWDZA CZY MA RO BIĆ DALEJ
            { 
             a = rnd.Next(0, 10);
                if (a % 2 == 0) // czy podzielna przez 2, czy wychodzi jej 0 reszty, jesli tak, zapisz
                {
                    printNumber++;
                    Console.WriteLine("number {0}: {1}", printNumber, a);
                }
                else
                    continue;
            }
            while (printNumber < 80); 
        }
    }
}
