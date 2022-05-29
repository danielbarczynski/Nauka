using System.Reflection;

// Using GetType to obtain type information:
int i = 42;
Type type = i.GetType();
Console.WriteLine(type);

// Using Reflection to get information of an Assembly:
Assembly info = typeof(int).Assembly; // using system.reflection
Console.WriteLine(info);