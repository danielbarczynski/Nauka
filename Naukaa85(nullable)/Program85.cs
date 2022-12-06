// C# 2.0
Nullable<int> x = null;
Console.WriteLine(x);

// current
// nullable - zmienna której można przypisać null ponieważ nie jest zainicjalizowana np. auto-property

int? y; // can be without ? but
y = null; // error without "?" 
int? z = null; 
int? h;
h = null; // without ? not working
h = 5;

Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(h);