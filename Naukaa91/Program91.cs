using System;
using System.Text;

namespace ExtensionMethod2
{
    public static class ExtMetClass
    {
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
    }

    class B
    {
        public static int g = 5;
        public  int h { get; set; }
        B(int h)
        {
            this.h = h; // static wyrzuca blad
        }
    }

    class Program91
    {
        static void Main(string[] args)
        {
            string str = "123456";
            int num = str.IntegerExtension();
            Console.WriteLine("The output using extension method: {0}", num);
            Console.ReadLine();
            Console.WriteLine(B.g);
        }
    }
}