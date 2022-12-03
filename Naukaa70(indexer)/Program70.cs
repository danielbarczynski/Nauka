using System;
using System.Collections;

class SampleCollection<T>
{
    // Declare an array to store the data elements.
    private T[] arr = new T[100]; // T instead of int, string etc.

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

class StringDataStore : IEnumerable<StringDataStore>
{
    public string Name { get; set; }
    private StringDataStore[] strArr = new StringDataStore[10]; // internal data storage
    IEnumerable<StringDataStore> ReturnStrings()
    {
        foreach (var item in strArr)
        {
            yield return item; 
        }
    }
    
    public IEnumerator<StringDataStore> GetEnumerator()
    {
        return ReturnStrings().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public StringDataStore this[int index]
    {
        get
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Index out of range");

            return strArr[index];
        }

        set
        {
            if (index < 0 || index >= strArr.Length)
                throw new IndexOutOfRangeException("Index out of range");

            strArr[index] = value;
        }
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

        StringDataStore stringDataStore = new();

        for (int i = 0; i <= 9; i++)
            stringDataStore[i] = new StringDataStore { Name = $"String {i}" };
            
        foreach (var item in stringDataStore)
        {
            Console.WriteLine(item.Name);
        }
    }
}
// The example displays the following output:
//       Hello, World.