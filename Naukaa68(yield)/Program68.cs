void Consumer()
{
    foreach (int i in Integers())
    {
        Console.WriteLine(i.ToString());
    }
}

IEnumerable<int> Integers()
{
    yield return 1;
    yield return 2;
    yield return 4;
    yield return 8;
    yield return 16;
    yield return 16777216;
}

Consumer();

//--------------------------------------------------------------------

foreach (int i in ProduceEvenNumbers(9))
{
    Console.Write(i);
    Console.Write(" ");
}
// Output: 0 2 4 6 8

Console.WriteLine();

IEnumerable<int> ProduceEvenNumbers(int upto)
{
    for (int i = 0; i <= upto; i += 2)
    {
        yield return i; // without yield error "not all code returns a value"
    }
}

//--------------------------------------------------------------------

Console.WriteLine(string.Join(" ", TakeWhilePositive(new[] { 2, 3, 4, 5, -1, 3, 4 })));
// Output: 2 3 4 5

Console.WriteLine(string.Join(" ", TakeWhilePositive(new[] { 9, 8, 7 })));
// Output: 9 8 7

IEnumerable<int> TakeWhilePositive(IEnumerable<int> numbers)
{
    foreach (int n in numbers)
    {
        if (n > 0)
        {
            yield return n; //* przy zwyklym return trzeba zwrocic IEnumerable zamiast inta 
        }
        else
        {
            yield break; // or just break
        }
    }
}

var point = new Point(1, 2, 3);

foreach (int coordinate in point)
{
    Console.Write(coordinate);
    Console.Write(" ");
}

//--------------------------------------------------------------------

var numbers = ProduceEvenNumbers2(5);
Console.WriteLine("Caller: about to iterate.");

foreach (int i in numbers) // it comes back everytime
{
    Console.WriteLine($"Caller: {i}"); 
}

Console.WriteLine("new numbers start");
Console.WriteLine("new numbers end");


object h = hey();
Console.WriteLine(h);

Console.WriteLine("start yielding");
// Console.WriteLine(returnYield()); // wont work, must be iteration through foreach for instance

foreach (var item in returnYield())
{
    Console.WriteLine(item);
}

Console.WriteLine("stop yielding");

string hey() => "hey";

IEnumerable<string> returnYield() //* yield can be only IEnumerable or IEnumerator (in class) type 
{
    yield return "my";
    yield return "name";
    yield return "is";
}

IEnumerable<int> ProduceEvenNumbers2(int upto)
{
    Console.WriteLine("Iterator: start.");

    for (int i = 0; i <= upto; i += 2)
    {
        Console.WriteLine($"Iterator: about to yield {i}");
        yield return i; // it comes back everytime
        Console.WriteLine($"Iterator: yielded {i}");
    }

    Console.WriteLine("Iterator: end.");
}



// yield with GetEnumerator
public readonly record struct Point(int X, int Y, int Z) // can't do it with the class
{
    public IEnumerator<int> GetEnumerator()
    {
        yield return X;
        yield return Y;
        yield return Z;
    }
}