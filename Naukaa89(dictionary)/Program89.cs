IDictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "One"); //adding a key/value using the Add() method
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");
var test = "test";
//numberNames.Add(3, "Three"); // the following throws run-time exception: key already added.

foreach (KeyValuePair<int, string> kvp in numberNames)
	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

//creating a dictionary using collection-initializer syntax
var cities = new Dictionary<string, string>(){
	{"UK", "London, Manchester, Birmingham"},
	{"USA", "Chicago, New York, Washington"},
	{"India", "Mumbai, New Delhi, Pune"}
};

foreach (var kvp in cities)
	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
