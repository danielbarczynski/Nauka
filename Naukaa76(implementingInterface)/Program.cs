public interface IAnimal
{
    string Speak();
}

public class Dog : IAnimal
{
    public string Speak()
    {
        return "Woof, woof";
    }
}

public class Cat : IAnimal
{
    public string Speak()
    {
        return "Meow";
    }
}

public class Parrot : IAnimal
{
    public string Speak()
    {
        return "Sqwark!";
    }
}

interface IDetails
{
    string GetFullName();
}

public class Customer : IDetails
{
    public string GetFullName()
    {
        return "Mark";
    }
}

public class Employee : IDetails
{
    public string GetFullName()
    {
        return "Joe";
    }
}
    class Program
{
    //This also allows you to then get into things like Inversion Of Control where you would take an item in like this and you could pass a dog,
    //cat or parrot and the method would always work, not knowing or caring which animal it was:

    public void ShoutLoud(IAnimal animal)
    {
        Console.WriteLine("Shout " + animal.Speak());
    }
    //This then makes ShoutLoud unit testable because you could use a mock object rather than a real animal. It basically makes your code flexible
    //and dynamic rather than rigid and tightly coupled.
    //In C# you can only inherit from one base class but you can have multiple interfaces. So, you could have:

   // public class Dog : IAnimal, IMammal, ICarnivor

    //This allows you to have small interfaces (recommended) that then allow you to build up so giving maximum control over what an item can / must do.

    static void Main(string[] args)
    {
        // Writes Woof, Woof
        IAnimal animal = new Dog();
        Console.WriteLine(animal.Speak());

        // Now writes Meow
        animal = new Cat();
        Console.WriteLine(animal.Speak());

        // Now writes Sqwark etc
        animal = new Parrot();
        Console.WriteLine(animal.Speak());

        //---------------------------------------

        IDetails human = new Customer();
        Console.WriteLine(human.GetFullName());

        human = new Employee();
        Console.WriteLine(human.GetFullName());

        Console.ReadLine();
    }
}