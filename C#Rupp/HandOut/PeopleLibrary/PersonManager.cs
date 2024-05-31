namespace PeopleLibrary;
public class PersonManager
{
    #region Singleton
    private static PersonManager? instance = null;
    private PersonManager() { }
    public static PersonManager GetInstance()
    {
        if (instance == null) instance = new PersonManager();
        return instance;
    }
    #endregion

    private Dictionary<int, Person> people=new();

    public int Count => people.Count;
    public Person Add(int no, string name, string gender, byte age)
    {
        Person person = new Person(no, name, gender, age);
        Add(person);
        return person;
    }
    public void Add(Person person)
    {
        if (people.TryAdd(person.No, person) == false)
        {
            throw new Exception($"The person id, {person.No}, does already exist");
        }
    }
    public Person? Get(int no)
    {
        people.TryGetValue(no, out Person? person);
        return person?.Clone();
    }
    public List<Person> All => people.Values.Select(x => x.Clone()).ToList();
   
    public bool Update(Person person)
    {
        people.TryGetValue(person.No, out Person? result);
        if (result != null)
        {
            result.Name= person.Name;
            result.Gender= person.Gender;
            result.Age= person.Age;
        }
        return result != null;
    }
    public Person? Remove(int no)
    {
        people.Remove(no, out Person? person);
        return person;
    }
    public void Clear()
    {
        people.Clear();
    }
}
