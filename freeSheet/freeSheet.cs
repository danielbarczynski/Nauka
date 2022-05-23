using freeSheet.things;
using System;
using System.Text;
using static FreeSheet2.FreeSheet2;

namespace FreeSheet // ADDED FREESHEET2 REFERENCE
{
     class FreeSheet : Horse
    {
      
        static void Main(string[] args)
        {
            FreeSheet freeSheet = new FreeSheet();
            freeSheet.test();

            string graphemeU = "👍🏼";
            byte[] bytes = Encoding.Default.GetBytes(graphemeU);
            graphemeU = Encoding.UTF8.GetString(bytes);

            string grapheme = "👍🏼";
            Console.WriteLine(grapheme);
            Console.WriteLine(grapheme.Length);
            Console.WriteLine(graphemeU, Console.OutputEncoding = System.Text.Encoding.UTF8);
            Console.WriteLine(graphemeU.Length);
        }

        public void test()
        {
            FreeSheet freeSheet = new FreeSheet();// musi byc tu, poniewaz klasa statyczna poza nia nie widzi
            Horse horse = new Horse(); // class public so accessible
            //horse.Name = "big"; // nie mozna gdy internal/protected internal
            freeSheet.Name = "nope"; // odwolanie sie do naszej klasy (base) ktora dziedziczy i z niej wziecie property
            Console.WriteLine(freeSheet.Name);
            Console.WriteLine(base.Name = "big");


        }

    }
}