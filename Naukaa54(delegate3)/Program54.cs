MyDel myDel = new MyDel(SayHello); // we can pass a function in constrctor
MyDel myDel2 = SayHello; // or just assign a function
MyDel myDel3 = x => x + " no hello"; // we can assing anonymous method/function

Console.WriteLine(SayHello("Daniel"));
Console.WriteLine(SayHello2(x => x));
Console.WriteLine(SayHello2(x => x + " and bye"));
Console.WriteLine(myDel("Kayla"));
Console.WriteLine(myDel2("Kayla"));
Console.WriteLine(myDel3("Kayla"));

string SayHello(string name) => $"Hello {name}";
string SayHello2(MyDel myDel) => myDel(SayHello("Bryan"));

delegate string MyDel(string method);