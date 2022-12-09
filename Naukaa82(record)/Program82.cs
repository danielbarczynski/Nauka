
class Person
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
}

record Person2
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string Adress = "Krakow";

    public Person2() // has a constructor
    {
    }
}

class Program82
{
    static void Main(string[] args)
    {
        var person = new Person() { Name = "Bob", Surname = "Rose" };
        var person2 = new Person() { Name = "Bob", Surname = "Rose" }; 
        
        Console.WriteLine("class:");
        Console.WriteLine(person);
        Console.WriteLine(person == person2); // false
        //var person5 = person2 with { Name = "Gary" }; // cannot clone that, only struct or record
       
        Console.WriteLine("\nrecord:");
        
        var person3 = new Person2() { Name = "Bob", Surname = "Rose" };
        var person4 = new Person2() { Name = "Bob", Surname = "Rose" };
        var person6 = person4 with { Name = "Gary" }; // moze tez byc == person4; rowniez dziala przy recordzie

        Console.WriteLine(person3); // drukuje record jako string
        Console.WriteLine(person3 == person4); // porownanie properties (true)
        Console.WriteLine(person6);

        person3.Name = "h";
        person3.Adress = "Wroclaw";

        Console.WriteLine(person3);
        Console.WriteLine(person4);
    }
}