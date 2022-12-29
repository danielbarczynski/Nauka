using System.Reflection;
using System.ComponentModel;

var props = typeof(Person).GetProperties();
// Console.WriteLine(atr);
foreach (var item in props)
{
    Console.WriteLine();
    Console.WriteLine(item.Name);
    Console.WriteLine(item.GetCustomAttribute<PersonAttribute>().DisplayName);
    Console.WriteLine(item.GetCustomAttribute<DisplayNameAttribute>().DisplayName); // it actually has the same prop as my attribute
}
