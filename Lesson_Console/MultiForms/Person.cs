namespace MultiForms;

public delegate void RectangleHandler(Person rec);
public class Person
{
   
    public static event RectangleHandler? Created;
    
    public int No { get; init; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public byte Age { get; set; }
    private static int Count = 0;
    public Person(string n ="", string g ="", byte a = 0)
    { Name = n; Gender = g; Age = a; No =Count++; }

}
