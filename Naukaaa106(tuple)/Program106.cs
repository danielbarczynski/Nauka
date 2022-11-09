(string, int) t1 = ("may", 55);
var tuplee = Tuple.Create("Hey", 2, true);
Console.WriteLine(t1.Item1);
Console.WriteLine(t1.Item2);
Console.WriteLine(tuplee.Item1);
Console.WriteLine(tuplee.Item2);
Console.WriteLine(tuplee.Item3);
UseTuple(Tuple.Create(1, "Mom", false));

void UseTuple(Tuple<int, string, bool> tupp)
{
    Console.WriteLine(tupp.Item1 + " " + tupp.Item2 + " " + tupp.Item3);
}
