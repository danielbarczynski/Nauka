List<Person> listOfPersons = new List<Person>();

listOfPersons.Add(new Person { Name = "Andrew", Age = 22 });
listOfPersons.Add(new Person { Name = "Thomas", Age = 50 });
listOfPersons.Add(new Person { Name = "Mike", Age = 35 });

var query = 
    from person in listOfPersons 
    select person.Age;

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

Console.WriteLine("min " + nameLength);

string result = listOfPersons.Aggregate(string.Empty, (x, y) => x + ", " + y.Name).Substring(2); // without string.Empty

Console.WriteLine(result);

Func<Person, bool> predicate = x => x.Age % 2 == 0;
var evenAge = listOfPersons.Where(x => x.Age % 2 == 0);
var evenAge2 = listOfPersons.Where(predicate);

foreach (var item in evenAge2)
{
    Console.WriteLine(item.Age);
}

//--------------------------------------------

List<int> numbers = new List<int> {5, 12, 34, 84, 15, 26, 7};

// as anonymous type
var nums = numbers.Select((x, y) => new { number = x, index = y });

foreach (var item in nums)
{
    Console.WriteLine(item.index + ", " + item.number);
}

// ------------------------------------------

IEnumerable<string> nameSelected = listOfPersons.Select(x => x.Name);

foreach (var item in nameSelected)
{
    Console.WriteLine(item);
}

// ------------------------------------------

string[] strArr = { "abcdefgh", "12345" };
Person[] persons = new Person[] 
{ 
    new Person { Name = " Jack", Age = 44, Hobbies = new List<string> { "Ships", "Gold"}  },
    new Person { Name = " Daniel", Age = 23, Hobbies = new List<string> { "Piano", "Books"}   }
};

IEnumerable<char> strList = strArr.SelectMany(x => x); // iterates through each element
IEnumerable<string> perList = persons.SelectMany(x => x.Hobbies); // only works with list. if just select, prints List assembly info
IEnumerable<char> strList2 = from str in strArr from chr in str select chr;

foreach (var item in perList)
{
    Console.Write(item + " ");
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Hobbies { get; set; }
}

