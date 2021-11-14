using System.Collections.Generic;

namespace Naukaa19
{
    public class CatsGenerator
    {

        // lista nie jest nigdzie dostępna
        // hermatyzacja

        public List<CatModel> CatsList = new List<CatModel>();

        // nazwa funckji sprzeczna z jej logiką
        // brak petli
        //mozna to wszystko latwo zapesuc 
        // (int n)

        public void Genenerate5Cats(int i)
        {
            foreach (int i = 0; i < 5; i++)
          {
                CatsList.Add(new CatModel);
                Age = i + 1;
                Name = "Kotek" + i.ToString();
            };
            CatsList.Add(cat);
            System.Console.WriteLine($"imie kota: {cat.Name} i wiek: {cat.Age}");

            //interpolacja stringow
        }
    }
}