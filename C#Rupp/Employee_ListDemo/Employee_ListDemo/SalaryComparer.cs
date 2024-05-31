namespace Employee_ListDemo;

public class SalaryComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        if (x==null || y==null) return 0;
        return x.Salary.CompareTo(y.Salary);
    }
}
