namespace Naukaa87;

interface IInterface
{
    void Start();
    void Stop();
}

class Mega : IInterface
{
    // implementing interface implicitly (niejawnie)
    public void Start() { }

    // implementing interface explicitly (jawnie)

    void IInterface.Stop() { }

    static void Main(string[] args)
    {
        var mega = new Mega();
        mega.Start();
        //mega.Stop(); // cant access

        IInterface mega2 = new Mega();
        mega2.Start();
        mega2.Stop(); // can access
    }
}
