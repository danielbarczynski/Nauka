namespace Example1
{

    class A
    {
        protected int x = 123;
    }

    class D : A { }

    class C : B { }

    class B : A
    {
        public int GetX() { return x; }

        public static void Uruchom()
        {
            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();

            a.x = 10; // tworzone w klasie B, wiec nie moze byc
            b.x = 10;
            c.x = 10;
            d.x = 10; // nie dziedziczy po B
            x = 10; // musi byc odniesienie w statycznej metodzie
            this.x = 10; // nie wazne w static metodzie
            int x = 10;
            int y = c.GetX();
        }

        public void Test()
        {
            //...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //...
        }
    }
}