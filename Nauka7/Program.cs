using System;

namespace Nauka7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The Cake Is A Lie";
            string textNoSpaces = ""; //Thecakeisalie

            for (int i = 0; i < text.Length; i++)
            {
                // If a given char is not empty, add it to the final string

                char ch = text[i]; // bierzemy dowolne znaki -> text[0] = t text[1] = h text[2] = e itd.
                if (ch != ' ' && ch != '\t' && ch != '\n') // ch! -> jesli rozne od spacji // char - pojedyncze literki 't'
                    textNoSpaces += ch; // dodajemy go do tego stringa
            }

            Console.WriteLine(text);
            Console.WriteLine(textNoSpaces);

            string s1 = " mario kropka pe El ";
            string s2 = s1.Trim();
            Console.WriteLine(s2);
            // could be also cw(s1.trim())

            Random rnd = new Random();
            int x = rnd.Next(-101, 101);

            string whatever = x > 0 ? "positive number" : "negative number";
            Console.WriteLine(x + " is a " + whatever);
        }
    }
}
