public class Member
{
    public int Id // is not nullable thanks to init method
    {
        get;
        init;
    } // set is replaced with init
    public string? Name
    {
        get;
        set;
    }
    public string? Address
    {
        get;
        set;
    }
}

namespace Naukaa84
{
    class Program84
    {
        static void Main(string[] args)
        {
            Member memberObj = new Member
            {
                Id = 2
            };

            //memberObj.Id = 2; // only can be assigned in object initializer or this/base
            memberObj.Name = "Kirtesh Shah";
            memberObj.Address = "Vadodara";
            Console.WriteLine("****************START - Member Details***********");
            Console.WriteLine("ID : " + memberObj.Id);
            Console.WriteLine("Name : " + memberObj.Name);
            Console.WriteLine("Address: " + memberObj.Address);
            Console.ReadLine();
            Console.WriteLine("****************END - Member Details***********");

            //Init-only properties can or cannot be set as per your requirement. Only ID property is set and name and address properties are not set. Please note that if any property is not set at the time of object creation that property cannot be set.
        }
    }
}