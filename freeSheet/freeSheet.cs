using System;

namespace freeSheet
{
    class Program
    {

        static double GetPowered()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            return(x*x);
        }

        static void Main() 
        {
            Console.WriteLine(GetPowered());
        }       
    }
}