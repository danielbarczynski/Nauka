
class Person
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
}

record Person2
{
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public Person2()
    {
        Console.WriteLine("hi");
    }
}

class Program82
{
    static void Main(string[] args)
    {
        var person = new Person() { Name = "Bob", Surname = "Rose" };
        var person2 = new Person() { Name = "Bob", Surname = "Rose" }; 
        Console.WriteLine(person);
        Console.WriteLine(person == person2); // false
        //var person5 = person2 with { Name = "Gary" }; // cannot clone that, only struct or record
       
        Console.WriteLine();

        var person3 = new Person2() { Name = "Bob", Surname = "Rose" };
        var person4 = new Person2() { Name = "Bob", Surname = "Rose" };
        var person6 = person4 with { Name = "Gary" };
        Console.WriteLine(person3); // drukuje record jako string
        Console.WriteLine(person3 == person4); // porownanie properties (true)
        Console.WriteLine(person6);
    }
}