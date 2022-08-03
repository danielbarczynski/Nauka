List<Person> listOfPersons = new List<Person>();

listOfPersons.Add(new Person { Name = "Andrew", Age = 22 });
listOfPersons.Add(new Person { Name = "Thomas", Age = 50 });
listOfPersons.Add(new Person { Name = "Mike", Age = 35 });

var query = from person in listOfPersons select person.Age;
listOfPersons = listOfPersons.OrderBy(x => x.Age).ThenBy(x => x.Name).ToList();

foreach (var item in listOfPersons)
{
    Console.WriteLine(item.Name + " " + item.Age);
}

int totalAge = listOfPersons.Sum(x => x.Age);
int totalAge2 = query.Sum();

Console.WriteLine(totalAge);
Console.WriteLine(totalAge2);

foreach (var item in query)
{
    Console.WriteLine(item);
}

int nameLength = listOfPersons.Min(x => x.Name.Length);

Console.WriteLine(nameLength);

string result = listOfPersons.Aggregate(string.Empty, (x, y) => x + ", " + y.Name).Substring(2);

Console.WriteLine(result);

Func<Person, bool> predicate = x => x.Age % 2 == 0;
var evenAge = listOfPersons.Where(x => x.Age % 2 == 0);
var evenAge2 = listOfPersons.Where(predicate);


foreach (var item in evenAge2)
{
    Console.WriteLine(item.Age);
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

