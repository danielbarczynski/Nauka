
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

Console.WriteLine();
Console.WriteLine(mc == mc2); 
Console.WriteLine(mc.Equals(mc2)); // it refers to objects and strings only

class MyClass
{
    class Human // cant be in namespace
    {

    }
}

sealed class Sup // can be in namespace
{

}