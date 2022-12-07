using System.Reflection;

/* Reflection is a mechanism that allows us to write code that can
inspect types used in the application. For example, using reflection, we can 
list all fields and their values belonging to a given object, even if at 
compile time we don’t know what type it is exactly (while using dynamic keyword for example) */

// Using GetType to obtain type information:
int i = 42;
Type type = i.GetType();
Console.WriteLine(type);

// Using Reflection to get information of an Assembly:
Assembly info = typeof(int).Assembly; // using system.reflection
Console.WriteLine(info);

