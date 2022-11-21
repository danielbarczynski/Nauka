IEnumerable<int> nums = new List<int>()
{
    1, 2, 3, 4, 5, 6
};

var linq = nums.Append(11);
var linq2 = nums.GetEnumerator();
Console.WriteLine(linq2);