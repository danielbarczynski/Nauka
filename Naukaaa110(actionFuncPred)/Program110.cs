Predicate<int> pred = (x) => x == 1;
Func<int, int, int> funcc = (x, y) => x + y; // cannot use void as the last parameter, for this is Action
Action act = () => Console.WriteLine("hello");
Action<int> act2 = (x) => Console.WriteLine(x);
Func<int, int> showFunc = new(ShowX);
static int ShowX(int x) => x;

Console.WriteLine(showFunc(55));
Console.WriteLine(pred(2));
Console.WriteLine(funcc(2, 2));
act();
act2(5);

ForDels.act2(666);
Console.WriteLine(ForDels.Writing());
ForDels.WritingWhatever("whatsoever");

class ForDels 
{
    public static Action<int> act2 = (x) => Console.WriteLine(x);
    public static int Writing()
    {
        int x = 10;

        int Reading()
        {
            return ++x;
        }

        return Reading();
    }

    public static void WritingWhatever<T>(T x) => Console.WriteLine(x);
}