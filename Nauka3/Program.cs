﻿using System;

namespace Nauka3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a, b , i = 0;

            while (i < 51)   // while (end)
            {
                a = rnd.Next(0, 100);
                if (a % 2 == 0) // czy podzielna przez 2, czy wychodzi jej 0 reszty, jesli tak, zapisz
                {
                    i++; // same as for (int i = 0) loop
                    Console.WriteLine("number {0}: (even) {1}", i, a); // printnumber from a
                }
                if (a % 3 == 0)
                {
                    i++;
                    Console.WriteLine("number {0}: (odd) {1}", i, a);
                }
                else
                    continue;
                
            }

            //----------------------------------------------------------------------------------------
           

            do // NAJPIERW ROBI, POTEM SPRAWDZA CZY MA RO BIĆ DALEJ
            { 
             b = rnd.Next(0, 10);
                if (b % 2 == 0) // czy podzielna przez 2, czy wychodzi jej 0 reszty, jesli tak, zapisz
                {
                    i++; 
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
