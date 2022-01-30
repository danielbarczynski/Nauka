using System;

namespace Naukaa58_outRef_
{
    internal class Program58
    {
        static void Main(string[] args)
        {
            int outside = 20;

            Nothing(outside); // mozna poodac zmienna i wartosc
            Nothing(50);

            Console.WriteLine();

            Reff(ref outside); // mozna podac jakas zmienna z zewnatrz, ale nie mozna podac wartosci (przekazanie referencji)
            //Reff(ref 20); // nie działa

            Console.WriteLine();

            Outt(out outside);// mozna podac jakas zmienna z zewnatrz, ale nie mozna podac wartosci (przekazanie referencji)
            // zmienna za to w ogóle nie zostanie uwzględniona, czyli takie bezpieczne odpalenie funckji z konstuktorem
        }
        public static void Nothing(int inside) // int outside wazny i liczony
        {
            Console.WriteLine("Nothing:");
            inside = inside + 10;
            Console.WriteLine(inside);
        }

        public static void Reff(ref int inside) // int outside wazny i liczony
        {
            Console.WriteLine("Ref:");
            inside = inside + 10;
            Console.WriteLine(inside);
        }

        public static void Outt(out int inside) // int outside uniewazniony
        {
            Console.WriteLine("Out:");
            inside = 0;
            inside = inside + 10;
            Console.WriteLine(inside);
        }
    }
}
