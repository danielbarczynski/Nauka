float f = 0.1f;
float f2 = 0.2f;
double d = 0.1d;
double d2 = 0.2d;
decimal m = 0.1m;
decimal m2 = 0.2m;

Console.WriteLine(f + f2);
Console.WriteLine(d + d2);
Console.WriteLine(m + m2);

Console.WriteLine(f + f2 == 0.3f);
Console.WriteLine(d + d2 == 0.3d); // 3.000000004
Console.WriteLine(m + m2 == 0.3m);