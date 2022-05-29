string a = new string('x', 1);
string b = new string('x', 1);
Console.WriteLine(a == b); // Uses string's implementation, prints True

object c = a;
object d = b;
Console.WriteLine(c == d); // Reference identity comparison, prints False

string f = new string('x', 1);
string g = new string('y', 1); // if changed to 'y', prints false
Console.WriteLine(f.Equals((object)g));

object x = f;
object z = g;
Console.WriteLine(x.Equals(z)); // values the same, prints true

class MyClass
{
    private class Human // cant be in namespace
    {

    }
}

sealed class Sup // can be in namespace
{

}