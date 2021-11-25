using System;
using System.Collections.Generic;

namespace FreeSheet
{
    class FreeSheet
    {            
        static void Main() // snippet: svm
        {
            Games game1 = new();

            game1.title = "Hollow Knight";
            Games.price = 26.99; //!!!

            Console.WriteLine($"The game is called: {game1.title} and its price is: {Games.price}. Rated: {Games.rating = 9.8}");
        }      
    }

    class Games
    {
        public string title;
        public static double price; // przy staticu musimy odnosic się do całej klasy
        public static double rating;

        public Games() //ctor
        {

        }
    }

}

