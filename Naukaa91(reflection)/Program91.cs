using System.Reflection;
using System.Collections;

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

// Get name of type  
Type MyType = Type.GetType("System.Collections.ArrayList");

//Store all the tpyes 
MemberInfo[] Mymemberinfoarray = MyType.GetMembers();

//Display
Console.WriteLine(MyType);

foreach (MemberInfo item in Mymemberinfoarray)
{
    Console.WriteLine((item.Name + " (" + item.MemberType + ")")); // double quotes to allow ()
}

ArrayList arrayList = new();
arrayList.BinarySearch(); // one of the methods listed above ^