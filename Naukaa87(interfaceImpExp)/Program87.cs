namespace Naukaa87;

interface IInterface
{
    string Start();
    void Pause();
    void Stop();
}

class Mega : IInterface
{
    // implementing interface implicitly (niejawnie)
    public string Start() // must be public 
    {
        return "Start";
    } 

    string IInterface.Start() // passing to public like with GetEnumerator() method
    {
        return Start(); // printing "Start" from public method
        // return "Not start";
    }

    // implementing interface explicitly (jawnie)
    //* they can be only accessable from Interface
    void IInterface.Stop() { } // cannot be public even if has body
    public void Pause() => Console.Write("pause"); // must be public, otherwise isn't implementing

    static void Main(string[] args)
    {
        var mega = new Mega();
        mega.Start();
        // mega.Stop(); // can't access

        IInterface mega2 = new Mega();
        Console.WriteLine(mega2.Start());
        mega2.Stop(); // can access, another reason for initializing class from interface
    }
}
