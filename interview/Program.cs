
//Napisz metodę, która posortuje powyższą listę malejąco względem wieku i zwróci ją w formie dowolnej kolekcji. Sortowanie możesz zaimplementować w jaki tylko sposób chcesz.

//Definiujemy kolekcję
List<Person> people = new List<Person>

{

 new Person { Name = "Jacek", Age = 4  },

 new Person { Name = "Basia", Age = 12  },

 new Person { Name = "Łukasz", Age = 75  },

 new Person { Name = "Kasia", Age = 89  },

 new Person { Name = "Zosia", Age = 33  },

 new Person { Name = "Rafał", Age = 21  },

 new Person { Name = "Stefan", Age = 56  },

 new Person { Name = "Daniel", Age = 7  },

};

var posortowanaLista = SortowanieListy(people);

foreach (var item in posortowanaLista)
{
    Console.WriteLine(item.Name + item.Age);
}

List<Person> SortowanieListy(List<Person> people)
{
    var query1 = people.OrderByDescending(x => x.Age);
    var query2 = query1.ToList();
    return query2;
}

public class Person

{
    public string Name { get; set; }

    public int Age { get; set; }

}


