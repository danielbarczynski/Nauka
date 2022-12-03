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

foreach (int i in ProduceEvenNumbers(9))
{
    Console.Write(i);
    Console.Write(" ");
}
// Output: 0 2 4 6 8

IEnumerable<int> ProduceEvenNumbers(int upto)
{
    for (int i = 0; i <= upto; i += 2)
    {
        yield return i; // without yield error "not all code returns a value"
    }
}

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
            yield break;
        }
    }
}