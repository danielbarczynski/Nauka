class MyClass
{
    // na zmiane wykonuja zadanie, w roznych proporcjach
    static void Main(string[] args)
    {
        Thread t1 = new Thread(Print1);
        t1.Start();

        for (int i = 0; i < 1000; i++)
        {
            Console.Write(0);
        }

        int x = 0;

        while (x < 5)
        {
            Thread.Sleep(1000);
            x++;
            Console.WriteLine(x);
        } 

    }

    static void Print1()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write(1);
        }
    }
}