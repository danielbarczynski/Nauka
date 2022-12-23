int x = 100;
int y = x;

var task2 = new Task(() => 
{   
    Console.WriteLine(x + y);
});

var task3 = new Task(() => 
{
    Console.WriteLine(x * y);
});

task3.Start();
task2.Start();
task2.Wait(); // it finishes first, because block the threads to wait for this task
task3.Wait();

//! The return type of an async method must be void, Task, Task<T>, a task-like type, IAsyncEnumerable<T>, or IAsyncEnumerator<T>
async void Something() 
{

}

// task that returns 
async Task<int> AddNumsAsync(int x, int y) 
{
    // x = AddNum(x); // can't await non async func
    x = await Task.Run(() => AddNum(x)); //! not working without await
    return x + y;
}

int AddNums(int x, int y)
{
    return x * y;
}

int AddNum(int x)
{
    Thread.Sleep(2000); // it actually waits for it
    return x * x;
}

Console.WriteLine("Asynchronous:");
var addNumsAsync = AddNumsAsync(10, 10);  //* it doesn't block the flow
Console.WriteLine(AddNums(10, 10)); 
Console.WriteLine(addNumsAsync.Result);

Console.WriteLine("Synchronous:");
var add = AddNum(10); //* it actually blocks the whole flow for 5 sec!!
Console.WriteLine(AddNums(10, 10)); 
Console.WriteLine(add);


