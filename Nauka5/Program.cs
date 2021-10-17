using System;

namespace Nauka5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[4, 4]; //50*10=500 [,] = [50,10]
            
            int sum = 0;

            // Main 2D loop (nested loop)
            // getlenght do dwuwymiarowej, bo length zbiera dlugosc obu wymiarow

            for (int i = 0; i < tab.GetLength(0); i++) //tab.length - bierze i mnozy dwa wymiary
                for (int j = 0; j < tab.GetLength(1); j++) // robi i, wszystkie j, kolejne i i wszystkie j
                {
                    tab[i, j] = i * j; // or random number
                    sum += tab[i, j]; // -> sum = sum + i,j, int sum = 0
                }

            // DLA 3D TA SAMA ANALOGIA. trzy wymiary int[1,2,3]


            Console.WriteLine(sum);

        }
    }
}
