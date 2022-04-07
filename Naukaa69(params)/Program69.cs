using System;
using System.Linq;

namespace Tablice
{
    class Program69
    {
        static void Main(string[] args)
        {
            TablicaJakoParametr tb = new TablicaJakoParametr();
            int[] liczby = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double srednia;
            srednia = tb.PoliczSrednia(liczby);
            Console.WriteLine("Średnia liczb to: {0}", srednia);

            TabliceParametryczne tp = new TabliceParametryczne();
            // W tym momencie do wnętrza naszej metody możemy przekazać różną
            // liczbę parametrów. Nie określamy na sztywno ile może ich być.
            int suma = tp.DodajElementy(1, 2, 3, 4, 6);
            Console.WriteLine("Wynik dodawania to: {0}", suma);
        }
    }
    class TablicaJakoParametr
    {
        public double PoliczSrednia(int[] liczby)
        {
            int i;
            int suma = 0;
            double srednia;
            foreach (var item in liczby)
            {
                suma += item;
            }
            // Wbudowana metoda Count() zwraca nam liczbę parametrów 
            // w naszej tablicy;
            i = liczby.Count();
            srednia = (suma) / i;
            return srednia;
        }
    }
    class TabliceParametryczne
    {
        public int DodajElementy(params int[] tablica)
        {
            int suma = 0;
            foreach (var item in tablica)
            {
                suma += item;
            }
            return suma;
        }
    }
}

