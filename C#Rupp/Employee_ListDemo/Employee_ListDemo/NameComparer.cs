namespace Employee_ListDemo;

public class NameComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        if (x == null || y == null) return 0;
        return x.Name.CompareTo(y.Name);
    }
}