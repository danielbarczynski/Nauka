public interface IService
{
    void Serve();
}
public class Service1 : IService
{
    public void Serve()
    {
        Console.WriteLine("Service1 Called");
    }
}
public class Service2 : IService
{
    public void Serve()
    {
        Console.WriteLine("Service2 Called");
    }
}
public class Client
{
    private IService _service;
    public Client(IService service)
    {
        this._service = service;
    }
    public void ServeMethod()
    {
        this._service.Serve();
    }

    // Property injection
    // public IService Service
    // {
    //     // get { return this._service; }
    //     set { this._service = value; }
    // }
 

    // Method injection
    // public void ServeMethod(IService service)
    // {
    //     service.Serve();
    // }
}
class Program
{
    static void Main(string[] args)
    {
        //creating object
        Service1 s1 = new Service1();
        //passing dependency
        Client c1 = new Client(s1);
        c1.ServeMethod();

        Service2 s2 = new Service2();
        c1 = new Client(s2);
        c1.ServeMethod();

        // Property injection
        // Client client = new Client();
        // client.Service = s1;
        // client.ServeMethod();

        //Method injection
        // Client client2 = new();
        // client2.ServeMethod(s1);
    }
}

