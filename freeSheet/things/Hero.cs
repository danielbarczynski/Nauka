using System;
using static FreeSheet.FreeSheet;

namespace freeSheet.things
{
     public class Hero
    {
        internal static string Name = "Mero";
        public static int Age = 15;

        //public Hero() // ctor snippet
        //{
                
        //}

        public static void SayHi()
        {
            Console.WriteLine("Hi " + Name + Age);
        }
    }
}
