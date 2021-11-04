using System;

namespace Naukaa27
{

    //public abstract class Player
    //{
    //    public abstract void returnString();
    //}
    // klasy abstract służa za bazę dla innych klas które będą je impleentować, nie można ich używać #1
    public abstract class SuperPlayer //: Player, specjalny błąd, usunąć abstract
    {
        public /*override*/ void returnString()
        {
            Console.WriteLine("cośTam");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SuperPlayer Player1 = new SuperPlayer(); // (#1) abstrakcyjnych klas nie można używać, musiałbym zaintemplementować nową i tą nową uzyć
            Player1.returnString();
        }
    }
}
