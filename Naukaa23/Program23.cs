using System;

namespace Naukaa24
{
    class Program23
    {
        static void Main(string[] args)
        {
            int x, y = 4; // x0 y4
            x = (y += 3); // x7 y7 
            x = ++y; // x8 y8
            x = y--;// x8 y7
            Console.WriteLine(x);
            Console.WriteLine(y);

            double wiek, PLN;
            bool kino;
            Console.WriteLine("Podaj wiek: ");
            wiek = double.Parse(Console.ReadLine());
            Console.WriteLine("Ile masz pieniędzy: ");
            PLN = double.Parse(Console.ReadLine());
            kino = (wiek >= 18 && PLN >= 20); // nawiasy nie są konieczne, dane dla czytelności
            Console.WriteLine("pójdziesz do kina: " + kino);

            int z = 1, c = 2;
            bool wynik;
            wynik = (z >= 2 && c++ >= 2);// false, true, poniewaz pierwsza zmienna ma false, program nie sprawdza wgl drugiego
            Console.WriteLine(wynik);
            Console.WriteLine(c);// @up: a wiec wartosc 2 zamiast 3, gdy damy & zamiast &&, c=3
        }
    }
}
