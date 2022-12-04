// They both offer a late binding scenario: they enable scenarios where a component communicates by calling a method that is only known at run time. They both support single and multiple subscriber methods. You may find this referred to as singlecast and multicast support. They both support similar syntax for adding and removing handlers. Finally, raising an event and calling a delegate use exactly the same method call syntax. They even both support the same Invoke() method syntax for use with the ?. operator.
namespace SampleApp
{
    public delegate string MyDel(string str); // najpierw trzeba utworzyc delegate
    public delegate string MyDel2(); 
    public delegate string MyDel3(string str); 

    class EventProgram
    {
        // An Event declaration adds a layer of abstraction and protection on the delegate instance. This protection prevents clients of the delegate from resetting the delegate and its invocation list and only allows adding or removing targets from the invocation list.
        event MyDel MyEvent; // event od delegaty
        // event int b = 5; // event must be of type delgate
        MyDel myDel;
        MyDel2 myDel2;
        MyDel3 myDel3;
        public EventProgram() // konstruktor bez parametru
        {
            MyEvent = new(WelcomeUser);
            myDel = new(WelcomeUser);
            Console.WriteLine(WelcomeUser2("without event")); 
        }
     
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        public string WelcomeUser2(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            Console.WriteLine(obj1.MyEvent("with event"));
            Console.WriteLine(obj1.myDel("just del")); // the same, what's the point of event
            var mydl = obj1.myDel2 = () => "ceo"; // conly works without argument (because only methods can be fitted in there)
            Console.WriteLine(mydl());
            //or 
            Console.WriteLine(obj1.myDel2());
            MyDel3 mydl2 = obj1.myDel3 = (string str) => str;
            Console.WriteLine(mydl2("gg"));
            // MyDel3 mydl3 = new MyDel3(string str); // error
            MyDel3 mydl3 = (string str) => str; // this works
            Console.WriteLine(mydl3("mydl3"));
        }
    }
}