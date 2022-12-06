var struct1 = new MyStruct();
var struct2 = new MyStruct();
var class1 = new MyClass();
var class2 = new MyClass();

// MyStruct struct3 = null; // null cannot be assigned
MyClass class4 = null; //  null can be assigned

struct1.x = 4;
class1.x = 4;
struct2 = struct1;
class2 = class1;

void Assign(MyClass myClass)
{
    class1.x = 5;
    myClass.x = 6;
    Console.WriteLine(class1.x + " c1"); // doesn't recognize, cannot assign inside function
    Console.WriteLine(myClass.x + " c2");
}

void Assign2(MyStruct myStruct)
{
    struct1.x = 5;
    myStruct.x = 6;
    Console.WriteLine(struct1.x + " s1");
    Console.WriteLine(myStruct.x + " s2");
}

Assign(class1);
Assign2(struct1);

Console.WriteLine();

Console.WriteLine(class2.x); // oba obiekty odwoluja sie do jednego miejsca w pamieci (typy referencyjne)
Console.WriteLine(struct2.x); // ze struct tak nie jest


struct MyStruct
{
    public int x;
}

class MyClass
{
    public int x;
}