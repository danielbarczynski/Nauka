using System;
using System.Collections.Generic;
using System.Linq;

namespace Naukaa55_lambda_
{

    delegate void Delegate(int x, int y);

    internal class Program55
    {
        static void Main(string[] args)
        {
            Delegate del = (x, y) => Console.WriteLine(x + y);
            del(4, 5);

            Console.WriteLine("---------------");

            //Delegate del2 = new Delegate(x, y);
            //Console.WriteLine(x + y);
            //del(4, 5);

            //----------------------------------------------------------------------

            var myNumbers = new List<int> { 0 , 1, 2, 3, 4, 5};

            // No lambda

            var numbersOver2 = new List<int>();

            foreach (int x in myNumbers)
            {
                if (x > 2) numbersOver2.Add(x);
            }

            // Lambda

            var myNumbers2 = new List<int> { 0, 1, 2, 3, 4, 5 };
            var numbersOver3 = myNumbers2.Where(n => n > 3);

            foreach(int x in numbersOver3)
            {
                Console.WriteLine(x);
            }

            //----------------------------------------------------------------------

            List<Game> games = new List<Game>
            {
                new Game(){Name = "RDR2", Score = 9},
                new Game(){Name = "Cyberpunk", Score = 6},
                new Game(){Name = "Hollow Knight", Score = 10},
                new Game(){Name = "Kena", Score = 8},
            };

            Console.WriteLine();

            Game gamesName = games.FirstOrDefault(x => x.Score == 6); // nie ma sensu pętli - pokazuje tylko 1 lub domyslne
            Console.WriteLine(gamesName.Name);
            Console.WriteLine();

            var suggestedGames = games.Where(x => x.Score >= 8).OrderBy(x => x.Score).Take(3); //.ToList();
           
            foreach (var x in suggestedGames)
            {
                Console.WriteLine(x.Name);
            }



            
        }
    }


    class Game
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
