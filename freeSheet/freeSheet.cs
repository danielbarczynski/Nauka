﻿// ADDED PROJ11 REFERENCE !!!!
using Naukaa11_class_;

namespace FreeSheet
{
    class FreeSheet
    {
        static void Main(string[] args)
        {
            var Dog = new Dog();
            Dog.Skok(); 
            
        }


    }

    interface IForDogs
    {
        void Aport(int x, int y); // mozna tez tworzyc inty w konstruktorze hah
        void Skok(); // czyli metody w interfejsie moga byc puste (jakby abstract)
    }

    class Dog
    {
        public void Skok()
        {
            System.Console.WriteLine("Pies skacze");
        }
    }
}