using System;

namespace FreeSheet
{
    class FreeSheet
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Humans.isMale("female"));

        }
    }

     static class Humans
    {
        public static bool isMale(string sex)
        {
            if (sex == "male")
            {
                return true;
                
            }
            else
            {
                return false;
              
            }

        }


       
    }

}