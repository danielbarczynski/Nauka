using System;

namespace Nauka9
{
    class Program9
    {
        static void Main(string[] args)
        {
            //silnia - factorial

            int a = 10;

            long f1 = Factorial(a);
            Console.WriteLine(f1);

            Console.WriteLine(Factorial(20));

            int z = 4;
            long silnia = 1;

            for (int i = 1; i <= z; i++)
            {
                silnia *= i;
            }
            Console.WriteLine("to jest " + silnia);

        }

        //------------------------------------------------------------------------------
        
        // static - statyczna = wieczna
        // pisanie metody: statyczna typ long nazwa (zawsze z duzej litery) typ i nazwa typu
        // by nie pisac tego samego kodu x razy, ta metoda jest do wszystkich obliczen silnii
        // wywoływanie metody tak samo jak Math.Pow, napisanej kiedys przez kogos

        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result; // return konczy metode, zwraca obiecany typ metody w tym (int n), po return juz nic nie dziala
        }

    }
}
