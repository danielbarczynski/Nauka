Animal animal = new Animal();

// animal.Run(); // here it throws an error
animal.Run += () => Console.WriteLine("I'm running");
animal.Run += () => Console.WriteLine("I'm still running");
animal.Run = () => Console.WriteLine("I'm sleeping"); // it just prints that without previous
animal.Run();
// animal.RaiseEvent();
// animal.MyDel() => "bye"; // throwss an error
animal.MyDel = () => "hi";
animal.MyDel += delegate ()
{
    return "hi2";
};
string myDelStr = animal.MyDel();
Console.WriteLine(myDelStr);

// Another weak spot is that every class which uses your Animal class can invoke the delegate directly. For example, animal.Run() or animal.Run.Invoke() are valid outside the Animal class

//-----------------------------------------------------------------------------

Animal2 animal2 = new Animal2();
// animal2.Run = (sender, e) => Console.WriteLine("I'm running. My value is {0}", e.Operation); // won't work, that's why event is more safe
animal2.Run += (sender, e) => Console.WriteLine("I'm running. My value is {0}", e.Operation);
// animal2.Run(animal2, new ArgsSpecial("Run faster")); // won't work
// animal2.Run2 += (sender, e) => Console.WriteLine($"I'm not running. {e}"); // cannot convert EventArgs to string
animal2.RaiseEvent();


/* Differences:
1. You aren't using a public property but a public field (using events, the compiler protects your fields from unwanted access) 
2. Events can't be assigned directly. In this case, it won't give rise to the previous error that I have showed with overriding the behavior. 
3. No one outside of your class can raise or invoke the event. For example, animal.Run() or animal.Run.Invoke() are invalid outside the Animal class and will produce compiler errors.
4. Events can be included in an interface declaration, whereas a field cannot */

// public delegate string MyDel() => "thanks"; // can't do that
public delegate string MyDel();
public class Animal
{
    public Action Run { get; set; }
    public MyDel MyDel { get; set; } // delegate can also be a property

    public void RaiseEvent()
    {
        if (Run != null)
        {
            Run();
        }
    }
}

public class ArgsSpecial : EventArgs
{
    public ArgsSpecial(string val)
    {
        Operation = val;
    }

    public string Operation { get; set; }
}

public class Animal2
{
    // Empty delegate. In this way you are sure that value is always != null 
    // because no one outside of the class can change it.
    public event EventHandler<ArgsSpecial> Run = delegate { }; // without event we can assign it by = and invoke it Run()
    public event EventHandler Run2 = delegate { };

    public void RaiseEvent()
    {
        // Run(new Animal2(), new ArgsSpecial("Run faster"));
        Run(this, new ArgsSpecial("Run faster"));
        // Run2(this, "run slower");
    }
}

// event handler is declared as following delegate
public delegate void EventHandler2(object sender, EventArgs e);