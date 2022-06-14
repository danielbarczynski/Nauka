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

IOrderedEnumerable<Person> sortedList(List<Person> people)
{
    return people.OrderByDescending(x=>x.Age); 
}

var posortowanaLista = sortedList(people);

foreach (var item in posortowanaLista)
{
    Console.WriteLine(item.Name + item.Age);
}

public class Person

{
    public string Name { get; set; }

    public int Age { get; set; }

}


