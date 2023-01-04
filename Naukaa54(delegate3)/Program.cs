var person = new Person();
person.Name = "Bryan";
var sayHello = person.SayHello();

MyDel myDel = x => x + " bye";
var result = myDel(sayHello);
Console.WriteLine(result);

var sayHello2 = person.SayHello2(x => x + " bye");
Console.WriteLine(sayHello2);

delegate string MyDel(string text);
class Person 
{
    public string Name { get; set; } = "Daniel";
    public string SayHello()
    {
        return $"Hello {Name}";
    }
    public string SayHello2(MyDel myDel)
    {
        return myDel(SayHello());
    }
}