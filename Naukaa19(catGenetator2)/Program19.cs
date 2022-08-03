using System.Collections.Generic;
using System;

namespace Naukaa19
{
    class CatsGenerator
    {
        class CatModel
        {
            public static string Name { get; set; }
            public static int Age { get; set; }
        }

        public static void Genenerate5Cats(int i)
        {
            List<CatModel> CatsList = new List<CatModel>();

            for (i = 0; i < 5; i++)
            {
                CatModel.Age = i + 1;
                CatModel.Name = "Kotek" + i.ToString();

                CatsList.Add(new CatModel());
                Console.WriteLine($"imie kota: {CatModel.Name} i wiek: {CatModel.Age}");
            }
        }

        static void Main(string[] args)
        {
            Genenerate5Cats(5);
        }
    }
}
