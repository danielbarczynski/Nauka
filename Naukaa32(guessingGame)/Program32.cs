using System;

namespace Naukaa32_guessingGame_
{
    class Program32
    {
        static void Main(string[] args)
        {
            string secretWord = "lion";
            string guess = "";
            int guessCount = 0;

            while (guess != secretWord)
            {
                if (guessCount == 5)
                {
                    Console.WriteLine("You did not guessed");
                    break;
                }
                {
                    Console.Write("guess an animal: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                if (guess == secretWord)
                {
                    Console.WriteLine("good guessed!");
                }
            }
        }
    }
}
