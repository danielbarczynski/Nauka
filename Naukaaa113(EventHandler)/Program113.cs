using System;

EventArgs eventArgs = new();
Cat cat = new Cat { Name = "Tino" };

cat.Meow += (sender, e) =>
{
    Cat cat = sender as Cat; // must cast because it is an object
    Console.WriteLine(cat.Name);
};

cat.Meow += PetCat; // no need for () with parameters. it doesn't override the method, but adds to it!
cat.Pet();

cat.Meow2 += PetCat2;
Console.WriteLine(cat.Pet2());

// with method
static void PetCat(object sender, EventArgs e)
{
    Cat cat = sender as Cat;
    Console.WriteLine(cat.Name = "Negra");
}

static string PetCat2(Cat cat)
{
    return cat.Name = "Leon";
}

class Cat
{
    public string Name { get; set; }
    public event EventHandler Meow; // non generic. that's convention if I am correct
    public event Func<Cat, string> Meow2;
    public void Pet() => Meow(this, EventArgs.Empty);  // or new EventArgs() - the same
    public string Pet2() => Meow2(this);
}