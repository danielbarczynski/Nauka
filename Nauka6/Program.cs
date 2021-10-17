using System;

namespace Nauka6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 18, 8, 1, 2 };
            
            foreach (var item in numbers) // moze byc var zamaist int bez ustalnia ze i idzie od 0, zwieksza sie o jeden
            {
                double x = Math.Pow(item, 2);
                Console.WriteLine(item + " ^ 2 = " + x);
            }

            int[] a5 = { 33, 66 };

            foreach (int item in a5)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
