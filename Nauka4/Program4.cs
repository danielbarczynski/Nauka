using System;
using System.Linq;
namespace Nauka4
{
    class Program4
    {
        static void Main(string[] args)
        {
            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

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

            int[,] zzz = { { 1, 2 }, { 3, 4 } };
            for (int i = 0; i < zzz.GetLength(0); i++) // for height, always starting from 0 (0)
            {
                for (int j = 0; j < zzz.GetLength(1); j++) // for width
                    Console.Write(zzz[i, j]); // get element from the [i,j] - width and lenght
                Console.WriteLine(); // print whole row [i,j] then jump to another line

                // if "writeline" every element in other line, I want whole row
            }

        }
    }
}
