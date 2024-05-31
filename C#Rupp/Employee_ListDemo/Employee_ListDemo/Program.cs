// See https://aka.ms/new-console-template for more information
using Employee_ListDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Demo: Collection-List<Employee>!");

        List<Employee> employees;
        Initialize();
        AddNewEmployee();
        AddRangeEmployees();
        InsertEmployee();
        InsertRangeEmployees();

        Employee target = new("Ham Sitha", 3000);
        CheckByContains(target);
        CheckByExists(target);

        double salaryLevel = 2500;
        FindFirstSalayLevelEmployee(salaryLevel);
        FindSalaryLevelEmployees(salaryLevel);

        SortEmployeesByNames();
        SortEmployeesBySalaries();

        Employee bTarget = new Employee("Mut Vongsa", 2500);
        BinarySearch1(bTarget);
        BinarySearch2(bTarget);

        DoubleSalaries();
        ViewRangeEmployees(2, 3);
        PredicateForAllEmployees(1500);
        PredicateForAllEmployees(1000);

        var removed = employees[2];
        RemoveEmployee(removed);
        RemoveEmployeeAt(0);
        RemoveRangeEmployees(1, 2);
        RemoveEmployeesFor(3000);
        RemoveAllEmployees();

        void RemoveAllEmployees()
        {
            Console.WriteLine($"\n[Removing all employees from the list]");
            employees.Clear();
            Console.WriteLine($"Result> all employees were removed");
            ViewEmployees(employees);
        }
        void RemoveEmployeesFor(double salary)
        {
            Console.WriteLine($"\n[Removing employees with salary = {salary} from the list]");
            int result = employees.RemoveAll(e => e.Salary == salary);
            Console.WriteLine($"Result> {result} employees were removed");
            ViewEmployees(employees);
        }
        void RemoveRangeEmployees(int starting, int count)
        {
            Console.WriteLine($"\n[Removing {count} employees starting at the index {starting} from the list]");
            try
            {
                employees.RemoveRange(starting, count);
                Console.WriteLine("Result > succeded");
            }
            catch (Exception)
            {

                Console.WriteLine("Result > failed");
            }
            ViewEmployees(employees);
        }
        void RemoveEmployeeAt(int index)
        {
            Console.WriteLine($"\n[Removing an employee at the index {index} from the list]");
            try
            {
                employees.RemoveAt(index);
                Console.WriteLine($"Result> succeded");
            }
            catch (Exception)
            {
                Console.WriteLine($"Result> failed");
            }
            ViewEmployees(employees);
        }
        void RemoveEmployee(Employee removed)
        {
            Console.WriteLine($"\n[Removing an employee named {removed.Name} from the list]");
            var result = employees.Remove(removed);
            Console.WriteLine($"Result> {(result ? "succeded" : "failed")}");
            ViewEmployees(employees);
        }
        void PredicateForAllEmployees(double level)
        {
            Console.WriteLine($"\n[Predicating for all employees with salaries >= {level}");
            bool result = employees.TrueForAll(e => e.Salary >= level);
            Console.WriteLine($"Do all employees have salary >= {level}?");
            Console.WriteLine($"Result> {(result ? "yes" : "no")}");

        }
        void ViewRangeEmployees(int starting, int count)
        {
            Console.WriteLine($"\n[Viewing {count} employess starting from the index {starting}");
            List<Employee> result = employees.GetRange(2, 3);
            ViewEmployees(result);
        }
        void DoubleSalaries()
        {
            Console.WriteLine("\n[Iterating on every employee to double salary");
            employees.ForEach(e => e.Salary *= 2);
            ViewEmployees(employees);
        }
        void BinarySearch2(Employee target)
        {
            Console.WriteLine("\n[Binary searching using salary comparision");
            //employees.Sort(new SalaryComparer());
            int index = employees.BinarySearch(target, new SalaryComparer());
            string msg = $"The employee (salary:{target.Salary}) ";
            if (index < 0)
                msg += "was not found in the list";
            else
                msg += $"was found at the index {index}";
            Console.WriteLine($"Result > {msg}");
            ViewEmployees(employees);
        }
        void BinarySearch1(Employee target)
        {
            Console.WriteLine("\n[Binary searching for employees sorted by names");
            employees.Sort();
            int index = employees.BinarySearch(target);
            string msg = $"The employee (name:{target.Name}) ";
            if (index < 0)
                msg += "was not found in the list";
            else
                msg += $"was found at the index {index}";
            Console.WriteLine($"Result > {msg}");
            ViewEmployees(employees);
        }
        void SortEmployeesBySalaries()
        {
            Console.WriteLine("\n[Ascending sorting employees by salary applying ICompararer functionality");
            employees.Sort(new SalaryComparer());
            ViewEmployees(employees);
        }
        void SortEmployeesByNames()
        {
            Console.WriteLine("\n[Ascending sorting employees by names applying IComparable functionality");
            employees.Sort();
            ViewEmployees(employees);
        }
        void FindSalaryLevelEmployees(double level)
        {
            Console.WriteLine($"\n[Finding for the first employee with salary >={level}]");
            var result = employees.FindAll(e => e.Salary >= level);
            if (result == null)
                Console.WriteLine("Result > Not found");
            else
            {
                Console.WriteLine("Result > Found");
                ViewEmployees(result);
            }
        }
        void FindFirstSalayLevelEmployee(double level)
        {
            Console.WriteLine($"\n[Finding for the first employee with salary >={level}]");
            var result = employees.Find(e => e.Salary >= level);
            string msg = "Not found";
            if (result != null)
                msg = $"First found named {result.Name}";
            Console.WriteLine($"Result > {msg}");
        }
        void CheckByExists(Employee target)
        {
            Console.WriteLine("\n[Checking for employee existing using the method Exists()]");
            bool result = employees.Exists(e => e.Name.Equals(target.Name) && e.Salary == target.Salary);
            string msg = "This list does ";
            if (result == false) msg += "not ";
            msg += $"contain the employee (name:{target.Name}, salary:{target.Salary})";
            Console.WriteLine($"Message > {msg}");
        }
        void CheckByContains(Employee target)
        {
            Console.WriteLine("\n[Checking for employee existing using the method Contains()]");
            bool result = employees.Contains(target);
            string msg = "This list does ";
            if (result == false) msg += "not ";
            msg += $"contain the employee (name:{target.Name}, salary:{target.Salary})";
            Console.WriteLine($"Message > {msg}");
        }
        void InsertRangeEmployees()
        {
            Console.WriteLine("\n[Inserting 2 employees at the 2nd position]");
            employees.InsertRange(2, new Employee[] { new("Prak Thavy", 1500), new("Yum Thary", 500) });
            ViewEmployees(employees);
        }
        void InsertEmployee()
        {
            Console.WriteLine("\n[Inserting an employee at the beggining]");
            employees.Insert(0, new Employee("Heng Vimean", 3500));
            ViewEmployees(employees);
        }
        void AddRangeEmployees()
        {
            Console.WriteLine("\n[Adding 2 employees]");
            employees.AddRange(new Employee[] { new("Ham Sitha", 3000), new("Leng Tola", 4000) });
            ViewEmployees(employees);
        }
        void AddNewEmployee()
        {
            Console.WriteLine("\n[Adding new employee]");
            employees.Add(new Employee() { Name = "Mut Vongsa", Salary = 1000 });
            ViewEmployees(employees);
        }
        void Initialize()
        {
            Console.WriteLine("\n[Initialization]");
            employees = new List<Employee>()
            {
              new Employee{Name="Heng Long", Salary=2500 },
              new Employee{Name="Prak Vong", Salary=1500 }
            };
            ViewEmployees(employees);
        }

        void ViewEmployees(List<Employee> emps)
        {
            Console.WriteLine($"Employees:{emps.Count}");
            Console.WriteLine($"{"No",-5} {"Name",-30} {"Salary($)",-10}");
            Console.WriteLine($"{new string('=', 5 + 1 + 30 + 1 + 10)}");
            for (int k = 0; k < emps.Count; k++)
            {
                var e = emps[k];
                Console.WriteLine($"{k + 1,5:00000} {e.Name,-30} {e.Salary,10:N2}");
            }
        }
        Console.ReadKey();
    }
}