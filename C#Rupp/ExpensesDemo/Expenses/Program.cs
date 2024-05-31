using ExpenseLibrary;

int ExpLength = 1_000;
int BranchLength = 100;
Manager mgr = new(ExpLength, BranchLength);


Console.WriteLine("Viewing total amount in all branches (List)-Classic");
ShowTotalAmountByBranchViaListB();

Console.WriteLine("Viewing total amount in all branches (List)-Grouping");
ShowTotalAmountByBranchViaListA();


Console.WriteLine("Viewing total amount in all branches (dictionary)");
ShowTotalAmountByBranchViaDict();

void ShowTotalAmountByBranchViaDict()
{
    var begin = DateTime.Now;   
    Console.WriteLine($"{"No",3} {"Branch",-20} {"Amount($)",8}");
    Console.WriteLine(new string('=', 3 + 1 + 20 + 1 + 8));
    var branchDict = mgr.GetExpDictBranch();
    int no = 1;
    foreach(var branch in branchDict.Keys)
    {
        var total = branchDict[branch].Sum(e => e.Amount);
        Console.WriteLine($"{no,3:000} {branch,-20} {total,8:n2}");
        no++;
    }
    var end = DateTime.Now;
    Console.WriteLine(end.Subtract(begin));
}
void ShowTotalAmountByBranchViaListA()
{
    var begin = DateTime.Now;
    Console.WriteLine($"{"No",3} {"Branch",-20} {"Amount($)",8}");
    Console.WriteLine(new string('=', 3 + 1 + 20 + 1 + 8));
    var exps = mgr.GetExpList();
    var result = exps.GroupBy(e => e.Branch).Select(g => new { Brannch=g.Key, Expenses=g.ToList() }).ToList();
   
    int no = 1;
    foreach (var ele in result)
    {
        var total = ele.Expenses.Sum(e => e.Amount);
        Console.WriteLine($"{no,3:000} {ele.Brannch,-20} {total,8:n2}");
        no++;
    }
    var end = DateTime.Now;
    Console.WriteLine(end.Subtract(begin));
}

void ShowTotalAmountByBranchViaListB()
{
    var begin = DateTime.Now;
    Console.WriteLine($"{"No",3} {"Branch",-20} {"Amount($)",8}");
    Console.WriteLine(new string('=', 3 + 1 + 20 + 1 + 8));
    var exps = mgr.GetExpList();
    var branches = exps.Select(e => e.Branch).Distinct().ToList();
   
    int no = 1;
    foreach (var ele in branches)
    {
        var total = exps.Where(e => e.Branch == ele).Sum(x => x.Amount);
        Console.WriteLine($"{no,3:000} {ele,-20} {total,8:n2}");
        no++;
    }
    var end = DateTime.Now;
    Console.WriteLine(end.Subtract(begin));
}