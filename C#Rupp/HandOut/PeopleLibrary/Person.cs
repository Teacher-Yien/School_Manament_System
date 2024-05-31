using System.Data;

namespace PeopleLibrary;
public class Person
{
    public Person() { }
 
    public Person(int no, string name, string gender, byte age)
    {
        No = no;
        Name = name;
        Gender = gender;
        Age = age;
    }

    public int No { get; set; } = 0;
    public string Name { get; set; } = "";
    public string Gender { get; set; } = "";
    public byte Age { get; set; } = 0;

    public Person Clone()
    {
        return new Person()
        {
            No = No,
            Name = Name,
            Gender = Gender,
            Age = Age
        };
    }
}
