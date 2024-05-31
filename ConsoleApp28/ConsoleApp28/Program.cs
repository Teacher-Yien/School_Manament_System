using System.Text.Json;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        Person p1 = new Person()
        {
            FullName="Mut Dara",
            Age=23,
            Height = 1.78
        };
        Person p2 = new Person()
        {
            FullName = "Keo Raman",
            Age = 35,
            Height = 1.86,
            Address = new Address() { Country = "Cambodia", Code= 12345}
        };
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.PropertyNameCaseInsensitive = false;
        options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        //string json1 = JsonSerializer.Serialize(p1, options);
        //Console.WriteLine(json1);

        //Person? result = JsonSerializer.Deserialize<Person>(json1, options);
        

        string jsons = JsonSerializer.Serialize(new Person[] {p1,p2}, options);
        Console.WriteLine(jsons);

        var pers = JsonSerializer.Deserialize<List<Person>>(jsons, options);
        Console.ReadKey();
    }
}
public class Person
{
    [JsonPropertyName("fullname")]
    public string FullName { get; set; }
    public int Age { get; set; }    
    public double Height { get; set; }
    [JsonIgnore]
    public bool IsOld => Age > 50;

    public Address? Address { get; set; }
}
public class Address
{
    public string Country { get; set; }
    public int Code { get; set; }
}