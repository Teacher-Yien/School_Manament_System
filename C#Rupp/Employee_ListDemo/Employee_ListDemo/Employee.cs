namespace Employee_ListDemo;
public partial class Employee
{
    public string Name{get;set;}="";
    public double Salary{get;set;}=0.0;

    public Employee(string name, double salary) { Name = name; Salary = salary; }
    public Employee() { }
}
public partial class Employee : IComparable<Employee>
{
    public int CompareTo(Employee? other)
    {
        if (other == null) return 0;
        return Name.CompareTo(other.Name);
    }
}