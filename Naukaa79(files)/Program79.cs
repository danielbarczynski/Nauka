DirectoryInfo dir = new DirectoryInfo("."); // current directory
Console.WriteLine(dir.FullName);
Console.WriteLine(dir.CreationTime);

//string filename1 = @"c:\documents\files\u0066.txt";
//string filename2 = "c:\\documents\\files\\u0066.txt";

string[] customers =
{
    "bob",
    "mark",
    "jay"
};

string filePath = @"C:\Users\itsmy\test";
File.WriteAllLines(filePath, customers);

var read = File.ReadAllLines(filePath); 

foreach (string line in read)
{
    Console.WriteLine(line);
}

DirectoryInfo dir2 = new DirectoryInfo(@"C:\Users\itsmy\source\repos\WhatIveBecome\Nauka");
FileInfo[] txtFiles = dir2.GetFiles("*.txt", SearchOption.AllDirectories); // moze byc bez drugiego argumentu, wtedy szuka tylko w tym folderze

foreach (FileInfo file in txtFiles)
{
    Console.WriteLine(file.Name);
    Console.WriteLine(file.Length); // in bytes
}

// ------------------------------------------------------
Console.WriteLine();

string filePath2 = @"C:\Users\itsmy\source\repos\WhatIveBecome\Nauka\Naukaa79(files)\text1";
StreamWriter sw = File.CreateText(filePath2);

sw.WriteLine("Hello there");
sw.WriteLine("Cya!");
string write = Console.ReadLine();
sw.WriteLine(write);
sw.Close();

StreamReader sr = File.OpenText(filePath2);

Console.WriteLine(sr.ReadLine()); // czyta pierwsza linie
Console.WriteLine("-------");
Console.WriteLine(sr.ReadToEnd()); // czyta cala reszte (lub caly tekst)
sr.Close();