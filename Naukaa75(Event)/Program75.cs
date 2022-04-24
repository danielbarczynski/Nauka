using System;

namespace SampleApp
{
    public delegate string MyDel(string str); // najpierw trzeba utworzyc delegate

    class EventProgram
    {
        event MyDel MyEvent; // event od delegaty

        public EventProgram() // konstruktor bez parametru
        {
            MyEvent = new MyDel(WelcomeUser);
        }
     

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        static void Main(string[] args)
        {
            EventProgram obj1 = new EventProgram();
            Console.WriteLine(obj1.MyEvent("Tutorials Point"));
        }
    }
}