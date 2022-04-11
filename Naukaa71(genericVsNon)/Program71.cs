using System.Collections;

class Animal {
public void Speak()
    {
        Console.WriteLine("hau");
    }
}

// ArrayList holds objects, it isn't type-safe. You could still add an Animal to an ArrayList of strings:

ArrayList arrayList = new ArrayList();
arrayList.Add(new Animal());
arrayList.Add("");

//When iterating an ArrayList you'd have to check the type to make sure the instance is of a specific type, which results in poor code:

foreach (object o in arrayList)
{
    if (o is Animal)
        ((Animal)o).Speak();
}

// With a generic List<string>, this is simply not possible:

List<string> stringList = new List<String>();
stringList.Add("Hello");
stringList.Add("Second String");
stringList.Add(new Animal()); // error! Animal cannot be cast to a string