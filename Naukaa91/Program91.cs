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

    class Program91
    {
        static void Main(string[] args)
        {
            string str = "123456";
            int num = str.IntegerExtension(); 
            Console.WriteLine("The output using extension method: {0}", num);
            Console.ReadLine();
        }
    }
}