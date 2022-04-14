using System;

namespace SampleApp
{
    public delegate string MyDel(string str); // najpierw trzeba utworzyc delegate

    class EventProgram
    {
        event MyDel MyEvent; // event od delegaty

        public EventProgram() // konstruktor bez parametru
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
     

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
            EventProgram obj1 = new EventProgram();
            string result = obj1.MyEvent("Tutorials Point"); // argument wziety od funkcji
            Console.WriteLine(result);
        }

    }
}