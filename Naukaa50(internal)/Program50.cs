using Naukaa11;
//Added reference!!!!
using System;
namespace Naukaa50_internal_
{
    class Program50
    {
        static void Main(string[] args)
        {
            Player player = new Player(); // can acces beacuse the class is PUBLIC NOT INTERNAL (class Player)
            player.name = "e";
            // player.age = 5; CANNOT ACCESS CUZ INTERNAL - ONLY FOR THIS PARTICULAR PROJECT (FOR THAT CASER NAUKAA11)
            Console.WriteLine("cos");
            Console.WriteLine(player.name);
        }
    }
}