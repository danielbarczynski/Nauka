
B b = new B(); // B is constructed here instead
A a = new A(b);
a.DoSomeStuff();
b.Hop();

C c = new C();
c.DoSomeThings();

public class A 
{
    private B b;

    public A(B b)
    { // A now takes its dependencies as arguments
        this.b = b; // look ma, no "new"!
    }

    public void DoSomeStuff()
    {
        var c = b.z = 15;
        Console.WriteLine(c);
    }
}

public class B
{
    public int z = 10;
    public virtual void Hop()
    {
        Console.WriteLine("Hop");
    }
}

public class C
{
    private readonly D d;

    public C()
    {
        d = new D(); // A *depends on* B
    }

    public void DoSomeThings()
    {
        var xx = d.x = 2000;
        Console.WriteLine(xx);
    }
}

public class D
{
    public int x = 5000;
    public virtual void Jump()
    {
        Console.WriteLine("Jump");
    }
}
