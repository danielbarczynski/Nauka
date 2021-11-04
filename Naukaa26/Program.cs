using System;
using System.Collections.Generic;

namespace Prototype
{

    public abstract class <nazwa-klasy>
    {
  public readonly decimal Price;
    public ProductPrototype(decimal price)
    {
        Console.WriteLine("Executing constructor");
        Price = price;
    }

    public ProductPrototype Clone()
    {
        return (ProductPrototype)this.MemberwiseClone();
    }
}

public class Bread : ProductPrototype
{
    public Bread(decimal price) : base(price) { }
}

public class Supermarket
{

    private Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

    public void AddProduct(string key, ProductPrototype productPrototype)
    {
        _productList.Add(key, productPrototype);
    }

    public ProductPrototype GetClonedProduct(string key)
    {
        var objectToCLone =
      return < powinno - zwracac - klon - produktu >
    }
    Dictionary<string, int> products;// 2 type, key and value
  {
    // for example 
    {key: "orange", value: 1},
    { key: "blue", value: 2}

    // wartosci moga sie powtarzac, stringi nie przy adddictionary do listy
    //MemberwiseClone - przydatna funkcja w c#
  }
  
}


class MainClass
{
    public static void Main(string[] args)
    {
        Supermarket supermarket = new Supermarket();
        var firstBread = new Bread(1.20);
        supermarket.AddProduct("Bread", firstBread);

        // tworzymy chleb, klonujemy drugi, dodajemy masło + rabat 10%

        var breadClone = supermarket.GetClonedProduct("Bread");
        Console.WriteLine(String.Format("Bread - {0} zł", firstBread.Price));
        Console.WriteLine(String.Format("Bread - {0} zł", breadClone.Price));
    }
}
}

