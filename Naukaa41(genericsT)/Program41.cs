using System;

namespace Naukaa41_genericsT_
{
    class Program41
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator<int>.AreEqual(10, 10); // otherwise AreEqual<T>
            if (Equal)
            {
                Console.WriteLine("are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }    
        }
    }

    class Calculator<T> // we can also make the whole class generic
    {
        public static bool AreEqual/*<T>*/(T val1, T val2) // T is referred as the type, but we can change it to whatever we want
        {
            return val1.Equals(val2);
        }
    }
}
