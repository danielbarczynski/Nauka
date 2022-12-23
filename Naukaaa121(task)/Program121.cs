int PerformComputation() 
{
    Random random = new();
    string result = "";
    int ave = 0;
    for (int i = 0; i < 1000; i++)
    {
        int randNum = random.Next(0, 1001);
        result += " " + randNum.ToString();
        if (randNum == 666) {
            ave = randNum;
            Console.WriteLine("\n AVE");
            break;
        }
    }
    Console.WriteLine(result);
    return ave;
}
//! The return type of an async method must be void, Task, Task<T>, a task-like type, IAsyncEnumerable<T>, or IAsyncEnumerator<T>
async void AddNums() 
{
    // var res = await PerformComputation(); // function doesn't containt await keyword so it isn't working
    var res = await Task.Run(() => PerformComputation()); // now it works
    // var res2 = res;
    Console.WriteLine("\nRESULT");
    Console.WriteLine(res - 99);
}
async Task DoSomeWorkAsync() // returns void 
{
  // Perform some asynchronous operation
  int result = await Task.Run(() => PerformComputation());
  Console.WriteLine(result);
}
// DoSomeWorkAsync(); //* without await there is no result printed
// await Task.Run(() => AddNums()); // isn't task so we have to run it this way
// await AddNums(); // cannot await void
var task = new Task(() => AddNums());
//* in this case result 0 is in the end 
task.Start();
task.Wait(); // waits for the task to complete action, but in this case actually not
await DoSomeWorkAsync();
//* in this case it prints shit...
//task.Start();
// task.Wait(); 
// await DoSomeWorkAsync();
