using System;

namespace Nauka4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            double[] a1 = new double[3]; // a1 - array1 - tablica 1 [3] - 3 elemntowa

            a1[0] = 2.0; // taki zapis bo to double
            a1[1] = 3.0;
            a1[2] = 5.0;

            // Array initialization #2

            char[] a2 = { 'W', 'S', 'E', 'I' };
         

            Console.WriteLine(a2);

            int[] a5 = new int[2];
            a5[0] = 22;
            a5[1] = 99;

            foreach (var item in a5)
            {
                Console.WriteLine(item.ToString());
            }

            // char[] a2 = new char[] { 'W', 'S', 'E', 'I' };
            // char[] a2 = new char[4] { 'W', 'S', 'E', 'I' };

            int[] b3 = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < b3.Length; i++) // PĘTLA TAK ZAWSZE BĘDZIE WYGLĄDAĆ
            {
                b3[i] = rnd.Next(0, 11); // or a3[i] = i; etc.
                Console.WriteLine(b3[i]);

            }
        }
    }
}
