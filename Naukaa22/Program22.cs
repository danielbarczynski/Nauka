using System;

namespace Naukaa23
{
    class Program22
    {
        static void Main(string[] args)
        {
            double f, c;
            Console.WriteLine("Podaj temp. w stopniach Fahrenheita");
            f = double.Parse(Console.ReadLine());
            c = 5.0 / 9 * (f - 32);
            // or c = 5D / 9 * (f-32)
            Console.WriteLine(c);

            const int komputery = 24; // stala wartość, której zmieniać nie wolno. w sali są 24 komputery i tego nie zmieniamy
            int studenci;
            double wynik;
            Console.WriteLine("Podaj liczbę studentów: ");
            studenci = Convert.ToInt32(Console.ReadLine()); // to samo co int.Parse(), konwertuje string na inta || użyta klasa Convert
            wynik = (double)studenci / komputery; // zmienia int studenci na double
            Console.WriteLine("na jeden komputer przypada " + wynik + " studentów");

            // y = pierwiastek (sinx * log2 x)

            double x, y;
            Console.WriteLine("Podaj x (większe od 0): ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));// abs - absolute, sqrt - pierwiastek
            Console.WriteLine(y);
            
            int z = 0, g;
            g = z++ * 2; // najpierw pomnozone, pozniej dodane, wynik 0 i 1
            g = ++z * 2; // na odwrot, dodaje przed dzialaniem, wynik 1 i 2
            Console.WriteLine("z" + z);
            Console.WriteLine("g" + g);


           
        }
    }
}
