// C# 2.0

Nullable<int> x = null;
Console.WriteLine("x: " + x);

// current
// nullable - zmienna której można przypisać null ponieważ nie jest zainicjalizowana np. auto-property

int? y; // can be without ? but
y = null; // error without "?" 
// or

int? z = null; 

Console.WriteLine("y: " + y);
Console.WriteLine("z: " + z);