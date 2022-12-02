Predicate<int> pred = (x) => x == 1;
Func<int, int, int> funcc = (x, y) => x + y; // cannot use void as the last parameter, for this is Action
Action act = () => Console.WriteLine("hello");
Action<int> act2 = (x) => Console.WriteLine(x);

Console.WriteLine(pred(2));
Console.WriteLine(funcc(2, 2));
act();
act2(5);
