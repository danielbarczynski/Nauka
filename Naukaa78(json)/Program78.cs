using System.Text.Json;

namespace SerializeToFile
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
    }
    class Person
    {
        public string? Name { get; set; }
        public string Age { get; set; } // if int, then json throws an error
    }

    public class Program78
    {
        public static void Main()
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            Console.WriteLine("serialized:");
            string fileName = "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(weatherForecast);

            File.WriteAllText(fileName, jsonString); // zapisanie jsona do pliku
            string fileString = File.ReadAllText(fileName);

            Console.WriteLine(jsonString); // reading string
            Console.WriteLine(fileString); // reading file

            // deserialization while class doesn't exist 
            Console.WriteLine("deserialized:");
            Console.WriteLine(weatherForecast.TemperatureCelsius);
            weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(fileString)!;
            Console.WriteLine();
            Console.WriteLine($"Date: {weatherForecast.Date}");
            Console.WriteLine($"TemperatureCelsius: {weatherForecast.TemperatureCelsius}");
            Console.WriteLine($"Summary: {weatherForecast.Summary}");
            string forJson = "{ \"Name\" : \"Daniel\", \"Age\" : \"23\" }";
            string forJson2 = @"
            {
                ""Name"" : ""Karol"",
                ""Age"" : ""16""
            }
            ";
            Person? me = JsonSerializer.Deserialize<Person>(forJson);
            Person? karol = JsonSerializer.Deserialize<Person>(forJson2);
            Console.WriteLine(me.Name + " " + me.Age);
            Console.WriteLine(karol.Name + " " + karol.Age);

            Person person = new()
            {
                Name = "Tessa",
                Age = "16"
            };

            string jsonFile = JsonSerializer.Serialize<Person>(person);
            File.WriteAllText("person.json", jsonFile);
            Console.WriteLine(File.ReadAllText("person.json"));
        }
    }
}
