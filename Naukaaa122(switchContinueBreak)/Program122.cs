var result = classification(32.45);
var result2 = classification2(12.45);
double bmi = 9;

Console.WriteLine(result);
Console.WriteLine(result2);

string classification(double bmi) => bmi switch
{
    < 18.5 => "underweight",
    < 24.9 => "normal",
    < 29.9 => "overweight",
    _ => "obesity"
};

string classification2(double bmi) // cannot use breaks, only returns
{
    switch (bmi)
    {
    case < 18.5:
        return "underweight";
    case < 24.9:
        return "normal";
    case < 29.9:
        return "overweight";
    default:
        return "obesity";
    };
};

switch (bmi)
{
    case < 10:
    case < 20:
        bmi += 15;
        Console.WriteLine(bmi);
        break;       
    case < 30:
        Console.WriteLine(bmi);
        break;
    case < 40:
        Console.WriteLine(bmi);
        break;     
}

Console.WriteLine("\nbreak:");
for (int i = 0; i < 10; i++) // breakf after 6
{
    if (i == 6)
        break;
    Console.WriteLine(i);
}

Console.WriteLine("\ncontinue:"); // continue after 6 not printing 6
for (int i = 0; i < 10; i++)
{
    if (i == 6)
        continue;
    Console.WriteLine(i);
}