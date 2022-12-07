List<string> list = new List<string>
{
    "adam", "beata", "celina"
};

Console.WriteLine(string.Join("\n", list)); // just like foreach

// Ternary operator
string c = "bear";
string d = "lion";
c = c == d ? "equal" : "not equal"; // or var e = ...
Console.WriteLine(c);

// Coalescing operator (null checking operator)
int? a = null;
a = a ?? -1; // is null? if yes then -1
Console.WriteLine(a);  	// output: -1

int? aa = 9;
aa = aa ?? -1; // or int b = aa ? -1;
Console.WriteLine(aa);