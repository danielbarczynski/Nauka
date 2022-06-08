// Find the Difference in Age between Oldest and Youngest Family Members

var array = new int[] { 82, 15, 6, 38, 35 };
var arrayForTest = Kata.DifferenceInAges(array);

for (int i = 0; i < arrayForTest.Length; i++)
{
    Console.WriteLine(arrayForTest[i]); // 82, 6, 76 - Correct! :)
}


public class Kata
{
    public static int[] DifferenceInAges(int[] ages)
    {
        var minAge = ages.Min();
        var maxAge = ages.Max();
        var difference = maxAge - minAge;
        int[] newArray = { minAge, maxAge, difference };
        return newArray;
    }

    public static int[] DifferenceInAges2(int[] ages)
  => new int[] { ages.Min(), ages.Max(), ages.Max() - ages.Min() };
}