using System;

namespace Naukaa41_genericsT_
{
    class Program41
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator.AreEqual(10, 10);
            if (Equal)
            {
                Console.WriteLine("are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            bool Equall = Calculatorr<string>.AreEquall("C", "DD");
            if (Equall)
            {
                Console.WriteLine("are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            Add.Adding(2, 1);
            Add.Adding("Dwa", "jednym"); // w tym wypadku nie ma sensu cała klasa <T>


        }
    }

    class Calculator
    {
        public static bool AreEqual<T>(T val1, T val2) // T is referred as the type, but we can change it to whatever we want
        {
            return val1.Equals(val2);
        }
    }

    class Calculatorr<T>// we can also make the whole class generic
    {
        public static bool AreEquall(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }

    class Add
    {
        public static void Adding<T>(T x, T y)
        {
            Console.WriteLine(x + " w " + y);
        }
    }

}