using System.Text;
using static System.Math; // static
using Terminal = System.Console; // alias

/* 
The Dispose method must be called on unmanaged resources such as files, streams, or window handles.
Traditionally, the resources were released in the finally block of the try/(catch)/finally statements.

The using statement automatically releases the resources when the object goes out of scope. It also 
ensures that the Dispose is called when an exception occurrs.

In an object inherits from the IDisposable interface, it must be explicitly released.*/
var path = "thermopylae.txt";
using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
using var sr = new StreamReader(fs, Encoding.UTF8);
string content = sr.ReadToEnd();

Console.WriteLine(content);
Console.WriteLine();
// The older syntax required to create a block with curly brackets.
using (var fs2 = new FileStream(path, FileMode.Open, FileAccess.Read))
{
    using (var sr2 = new StreamReader(fs2, Encoding.UTF8))
    {
        string content2 = sr2.ReadToEnd();
        Console.WriteLine(content2);
    }
}

Console.WriteLine();

/* It is possible to group the using statements together

using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
using (var sr = new StreamReader(fs, Encoding.UTF8))
{
    string content = sr.ReadToEnd();
    Console.WriteLine(content);
}*/

// The oldest syntax uses try/finally keywords

FileStream? fs3 = null;
StreamReader? sr3 = null;

try
{
    fs3 = new FileStream(path, FileMode.Open, FileAccess.Read);
    sr3 = new StreamReader(fs3, Encoding.UTF8);
    string content3 = sr3.ReadToEnd();

    Console.WriteLine(content3);
}
finally
{
    fs3?.Close();
    sr3?.Close();
}

Console.WriteLine();

//* C# introduced several convenience methods for reading text, such as File.ReadAllLines or File.ReadAllText. These methods automatically call the Dispose method for us!!
string content4 = File.ReadAllText(path, Encoding.UTF8);
Console.WriteLine(content4);
Console.WriteLine();

// other
Sqrt(3*3);
Terminal.WriteLine("using alias");