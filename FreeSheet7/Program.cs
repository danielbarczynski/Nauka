using System.Collections;

var r1 = new FootRace();
var r2 = r1 as IDisplayResult;
r1.Seconds = 99;

r1.Display();
r2.Display();
r1.DisplayRaw();
Person[] persons = new Person[5];
Person person = new Person(persons);
Console.WriteLine(person.CompareTo(persons[1]));

Person2 person2 = new Person2();
Person2 person3 = new Person2();
person2.Name = "bob";
person3.Name = "bob";
var p = person2.CompareTo(person3);
Console.WriteLine(p);

//var name = Console.ReadLine();
//var pers = new Pers(name);
//Pers lord = new Lord(pers);
//Console.WriteLine("pers name" + pers.Name);
//Console.WriteLine("lord name" + lord.Name);

int? i = null;
int j = (i is null)? 0 : i;
Console.WriteLine(j);

public interface IDisplayResult
{
    void Display();
}

public class Race
{
    public int Seconds;
    public virtual void Display()
    {
        Console.WriteLine(Seconds);
    }
}

public class FootRace : Race, IDisplayResult
{
    public override void Display()
    {
        Console.WriteLine(Seconds + "seconds");
    }

    void IDisplayResult.Display()
    {
        base.Display();
    }

    public void DisplayRaw()
    {
        Console.WriteLine(Seconds / 60d + "minutes");
    }
}

//struct MyStruct : MyStruct2
//{
//    public int z = 5;
//    public MyStruct()
//    {

//    }
//}

//struct MyStruct2
//{
//    public MyStruct2()
//    {

//    }
//}

public class Person : IComparable
{
    public string Name { get; set; }
    private readonly Person[] persons;

    public Person(Person[] personsArray)
    {
        persons = new Person[personsArray.Length];

        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = personsArray[i];
        }
    }

    public int CompareTo(object? obj)
    {
        return obj == null ? 1 : persons.Length;

    }
}

public class Person2 : IComparable
{
    public string Name { get; set; }
    public int CompareTo(object? obj)
    {
        var other = obj as Person2;
        //return other.Name.CompareTo(this.Name);
        return this.Name.CompareTo(other.Name);
    }
}

public class Pers
{
    public string Name { get; set; }
    public Pers()
    {

    }
    public Pers(string name)
    {
        Name = name;
    }
    public Pers(object obj)
    {

    }
}

public class Lord : Pers
{
    public string Namee { get; set; }
    string nameea = "";
    public Lord()
    {
        
    }

    public Lord(Pers pers) 
    {
        nameea = pers.Name;
        //new Lord(obj, persName);
    }

    //public Lord(object objj, string name) : this(objj)
    //{
    //    Namee = name;
    //}


}