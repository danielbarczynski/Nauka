StreamWriter sw = File.CreateText(@"C:\Users\itsmy\source\repos\WhatIveBecome\Nauka\Naukaa81(IDisposable)\test.txt");
sw.WriteLine("foo");
sw.Close();
StreamWriter sw2 = File.CreateText(@"C:\Users\itsmy\source\repos\WhatIveBecome\Nauka\Naukaa81(IDisposable)\test2.txt");
sw2.WriteLine("foo2");
sw2.Close();
//1. Let us first see how we should use a resource typically
TextReader tr = null;


//lets aquire the resources here
try
{
    tr = new StreamReader(@"C:\Users\itsmy\source\repos\WhatIveBecome\Nauka\Naukaa81(IDisposable)\test.txt");

    //do some operations using resources
    string s = tr.ReadToEnd();

    Console.WriteLine(s);
}
catch (Exception ex)
{
    //Handle the exception here
}
finally
{
    //lets release the aquired resources here
    if (tr != null)
    {
        tr.Dispose();
    }
}

//The other way to do the same thing us to use using, this way we only have to think about the resource acquisition and the exception handling. the resource release will be done automatically because the resource acquisition is wrapped inside the using block. 

//2. Let us now look at the other way we should do the same thing (Recommended version)
TextReader tr2 = null;

//lets aquire the resources here                
try
{
    using (tr2 = new StreamReader(@"C:\Users\itsmy\source\repos\WhatIveBecome\Nauka\Naukaa81(IDisposable)\test2.txt")) // kind of using temporary
    {

        //do some operations using resources
        string s = tr2.ReadToEnd();

        Console.WriteLine(s);
    }
}
catch (Exception ex)
{
    //Handle the exception here
}