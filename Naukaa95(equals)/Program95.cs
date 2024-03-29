﻿
using System;

string gg = "gg";
string ggg = "gg";
Console.WriteLine(gg == ggg); // true

string a = new string('x', 1);
string b = new string('x', 1);
Console.WriteLine(a == b); // Uses string's implementation, prints True

string f = new string('x', 1);
string g = new string('y', 1); // if changed to 'y', prints false
Console.WriteLine(f.Equals((object)g));

object c = a;
object d = b;
Console.WriteLine(c == d); // Reference identity comparison, prints False

object x = g;
object z = g;
Console.WriteLine(x.Equals(z)); // values the same, prints true

MyClass mc = new();
MyClass mc2 = new();

Console.WriteLine(mc == mc2); 
Console.WriteLine(mc.Equals(mc2)); // true because of Equals override

class MyClass : IEquatable<MyClass>
{
    public string Name { get; set; }

    class Human // cant be in namespace
    {
       
    }
    public override bool Equals(object obj) => Equals(obj as MyClass);  // if object, casting needed
    public bool Equals(MyClass other) => this.Name == other.Name; // must include class property, otherwise it is working as usual
    
    public override int GetHashCode()
    {
        return this.Name.GetHashCode();
    }
}

sealed class Sup // can be in namespace
{

}