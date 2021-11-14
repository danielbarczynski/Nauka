using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeSheet.things
{
     public static class Hero
    {
        public static string Name;
        public static int Age;

        //public Hero() // ctor snippet
        //{
                
        //}

        public static void SayHi()
        {
            Console.WriteLine("Hi " + Name + Age);
        }
    }
}
