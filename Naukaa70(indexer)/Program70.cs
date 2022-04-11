using System;

class SampleCollection<T>
{
    // Declare an array to store the data elements.
    private T[] arr = new T[100];

    // Define the indexer to allow client code to use [] notation.
    //public T this[int i]
    //{
    //    get { return arr[i]; }
    //    set { arr[i] = value; }
    //}
    public T this [int index] // indexer - property for array with expression-bodied member. zamiast T może też być typ zmiennej np bool
    {
        get => arr [index];
        set => arr [index] = value;
    }
}

class Program70
{
    static void Main()
    {
        var stringCollection = new SampleCollection<string>();
        stringCollection[0] = "Hello, World";
        stringCollection[1] = "Bye, World";
        Console.WriteLine(stringCollection[0] + "\n" + stringCollection[1]);
    }
}
// The example displays the following output:
//       Hello, World.