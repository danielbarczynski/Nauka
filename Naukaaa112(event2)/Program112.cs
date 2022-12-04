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


// public delegate string MyDel() => "thanks"; // can't do that
public delegate string MyDel(); 
public class Animal
{
    public Action Run { get; set; }
    public MyDel MyDel { get; set; } // delegate can also be a property, wow

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

public class Animal
{
    // Empty delegate. In this way you are sure that value is always != null 
    // because no one outside of the class can change it.
    public event EventHandler<ArgsSpecial> Run = delegate { };


    public void RaiseEvent()
    {
        Run(this, new ArgsSpecial("Run faster"));
    }
}