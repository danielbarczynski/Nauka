using System.Collections.Generic;
using System;

namespace Naukaa18
{
   

    public class CatsGenerator
    {

        public static List<CatModel> CatsList = new List<CatModel>();     

        public static void Genenerate5Cats()
        {
            for (int i = 0; i < 5; i++)
            {
                CatsList.Add(new CatModel
                {
                    Age = i + 1,
                    Name = "Kotek" + i.ToString()
                });
            }      

            foreach (var CatModel in CatsList)
            {
                Console.WriteLine(CatModel.Name + " " + CatModel.Age);
            }
        }

         static void Main(string[] args)
        {
            Genenerate5Cats();
        }


    }
    public class CatModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
   
}
