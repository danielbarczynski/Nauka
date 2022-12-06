// Implicit conversion is the conversion in which a derived class is converted into a base class like int into a float type. Explicit conversion is the conversion that may cause data loss. Explicit conversion converts the base class into the derived class.

// Implicit (converting from a smaller type to a larger type)
int anInt = 12;
float aFloat = anInt; // can also be with (float)

Console.WriteLine($"anInt: {anInt}"); // anInt: 12
Console.WriteLine($"aFloat: {aFloat}"); // aFloat: 12

// Explicit (converting from a larger type to a smaller type)
float aFloat2 = 12.945f;
int anInt2 = (int)aFloat2; // without (int) throws error

Console.WriteLine($"aFloat: {aFloat2}"); // aFloat: 12.945
Console.WriteLine($"anInt: {anInt2}"); // anInt: 12

aFloat = 13.333f;
Console.WriteLine(aFloat);