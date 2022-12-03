using System;
using System.Linq;

namespace Tablice
{
    class Program69
    {
        static string MySuperStr(params string[] str) // must be array
        {
            // string concatStr; // only works in js
            // concatStr = null; // can be like this, but it has no point tbh
            string concatStr = null; // better to use " " prevent <nullable> 
            foreach (var item in str)
            {
                // concatStr += item; // one way
                concatStr = string.Concat(concatStr, item); // second way
            }
            return concatStr!;
        } 
        static string ReturnPerson(Person person) => person.Name;
        
        static void Main(string[] args)
        {
            TablicaJakoParametr tb = new TablicaJakoParametr();
            int[] liczby = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] liczby2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double srednia;
            srednia = tb.PoliczSrednia(liczby);
            Console.WriteLine("Średnia liczb to: {0}", srednia);

            TabliceParametryczne tp = new TabliceParametryczne();
            // W tym momencie do wnętrza naszej metody możemy przekazać różną
            // liczbę parametrów. Nie określamy na sztywno ile może ich być.
            int suma = tp.DodajElementy(1, 2, 3, 4, 6);
            // int suma2 = tp.DodajElementy(liczby, liczby2); // can be only one array
            Console.WriteLine("Wynik dodawania to: {0}", suma);
            Console.WriteLine(MySuperStr("daniel", "mela", "iza"));


            // -----------------------------------------------------------------------
            new Person { Name = "Nikt", Age = 00 };
            new Person();
            new List<Person>{};
            new List<Person>();
            // new int[] {}; // throws error, works only as parameter

            srednia = tb.PoliczSrednia(new int[] { 2, 5, 9 });
            Console.WriteLine(ReturnPerson(new Person { Name = "Gosc", Age = 0}));
            Console.WriteLine(tb.PoliczSrednia2(new List<int> { 5, 6 }));
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class TablicaJakoParametr
    {
        public int PoliczSrednia2(List<int> list) => list.Last();
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

