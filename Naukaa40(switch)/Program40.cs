using System;

namespace Naukaa40_switch_
{
    class Program40
    {
        static void Main(string[] args)
        {
            double cena = 0;
            Console.WriteLine("Wybierz porjcę posiłku (S/M/L)");
            string porjca = Console.ReadLine().ToString();

            switch (porjca)
            {
                case "S":
                    cena += 3.0;
                    break;
                case "M":
                    cena += 2.0;
                    goto case "S";
                case "L":
                    cena += 3.0;
                    goto case "S";
                default:
                    Console.WriteLine("Podano nieprawidłowy rodzaj");
                    break;

            }
            Console.WriteLine($"Cena za twój posiłek: {cena} zł");
        }
    }
}
