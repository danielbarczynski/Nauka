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
                    Console.WriteLine("number {0}: (even) {1}", printNumber, a); // printnumber from a
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
            int b, i = 0; // printnumber is only name, in this example I have inserted c instead

            do // NAJPIERW ROBI, POTEM SPRAWDZA CZY MA RO BIĆ DALEJ
            { 
             b = rnd.Next(0, 10);
                if (b % 2 == 0) // czy podzielna przez 2, czy wychodzi jej 0 reszty, jesli tak, zapisz
                {
                    i++; // same as for (int i = 0) loop
                    Console.WriteLine("number {0}: {1}", i, b);
                }
                else  
                    continue;
            }
            while (i < 80); 

            // in general, two variables with the same value, c is used to loop
        }
    }
}
