using System;

namespace Naukaa38_static_
{
    class Program38
    {
        static void Main()
        {
            Games game1 = new();
            Games game2 = new();
            Games game3 = new();

            game1.title = "Hollow Knight";
            Games.price = 26.99; //!!!

            Console.WriteLine($"The game is called: {game1.title} and its price is: {Games.price}. Rated: {Games.rating = 9.8}");
            Console.WriteLine(Games.counting);

            Games.SayGames(); // metoda static, nie tworzymy obiektu, od razu ja powolujemy

            //Movies movie1 = new(); -- !! nie da sie, ponieważ oznaczyłem klase jako static

            Console.WriteLine(Movies.title);
        }
    }

    class Games
    {
        public string title;
        public static double price; // przy staticu musimy odnosic się do całej klasy
        public static double rating;
        public static int counting = 0;

        public Games() //ctor
        {
            counting++;// or with cw, but then counting after every created object
        }

       public static void SayGames()
        {
            Console.WriteLine("games are fun");
        }

    }

    static  class Movies
    {
         public static string title = "coś"; // aby zmienna byla dostepna, musi byc rowniez oznaczona jako static

        
    }

}