using System.Collections.Generic;

namespace Naukaa18
{
   

    public class CatsGenerator
    {

        public List<CatModel> CatsList = new List<CatModel>();     

        public void Genenerate5Cats()
        {
            for(int i = 0; i < 5; i++)
          {
                CatsList.Add(new CatModel);
                Age = i + 1;
                Name = "Kotek" + i.ToString();
          };
            CatsList.Add(cat);
            System.Console.WriteLine($"imie kota: {cat.Name} i wiek: {cat.Age}");

            
        }
        // ZROBIĆ LISTE LICZBOWĄ I GENERATOR LICZB DO NIEJ
    }
    public class CatModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
   
}
