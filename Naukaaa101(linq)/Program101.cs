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

//--------------------------------------------

List<int> numbers = new List<int>{5, 12, 34, 84, 15, 26, 7};

// as anonymous type
var nums = numbers.Select((x, y) => new {number = x, index = y});

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

string[] strArr = {"abcdefgh", "12345"};
IEnumerable<char> strList = strArr.SelectMany(x => x); // if just Select then can't be char, and it just prints two strings 

IEnumerable<char> strList2 = from str in strArr from chr in str select chr;

foreach (var item in strList)
{
    Console.WriteLine(item);
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

