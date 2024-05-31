using ExpenseLibrary;

namespace ListVsDictionaryTest;

[TestClass]
public class PerformanceTest
{
    static int ExpLength = 10_000;
    static int BranchLength = 100;
    Manager mgr = new(ExpLength, BranchLength);
   
    [TestMethod]
    public void GenerateExpenses()
    {
        mgr.GenerateExpenses(ExpLength, BranchLength);
    }
    [TestMethod]
    public void NewExpenseList()
    {
        mgr.GetExpList();
    }
    [TestMethod]
    public void NewExpenseDictNo()
    {
        mgr.GetExpDictNo();
    }
    [TestMethod]
    public void NewExpenseDictBranch()
    {
       mgr.GetExpDictBranch();
    }
    [TestMethod]
    public void GetBranchExpensesViaDict() 
    {
        string target = "Branch" + BranchLength;
        var all= mgr.GetExpDictBranch();
        var exps = all[target];
    }
    [TestMethod]
    public void GetBranchExpensesViaList()
    {
        string target = "Branch" + BranchLength;
        var all = mgr.GetExpList();
        var exps = all.Where(e => e.Branch == target).ToList();
    }
    [TestMethod]
    public void GetExpenseViaDict()
    {
        long target = ExpLength;
        var all = mgr.GetExpDictNo();
        var exp = all[target];
    }
    [TestMethod]
    public void GetExpenseViaList()
    {
        long target = ExpLength;
        var all = mgr.GetExpList();
        var exp = all.FirstOrDefault(e => e.No == target);
    }

    [TestMethod]
    public void TotalEveryBranchByDict()
    {
        var branchDict = mgr.GetExpDictBranch();
      
        foreach (var branch in branchDict.Keys)
        {
            branchDict[branch].Sum(e => e.Amount);
        }
    }

    [TestMethod]
    public void TotalEveryBranchByList_Classic()
    {
        var exps = mgr.GetExpList();
        var branches = exps.Select(e => e.Branch).Distinct().ToList();

        var result = exps.GroupBy(e => e.Branch).Select(g => new { Brannch = g.Key, Expenses = g.ToList() }).ToList();
        foreach (var ele in branches)
        {
            exps.Where(e => e.Branch == ele).Sum(x => x.Amount);
        }
    }

    [TestMethod]
    public void TotalEveryBranchByList_Group()
    {
        var exps = mgr.GetExpList();
        var result = exps.GroupBy(e => e.Branch).Select(g => new { Brannch = g.Key, Expenses = g.ToList() }).ToList();

        foreach (var ele in result)
        {
            var total = ele.Expenses.Sum(e => e.Amount);
        }
    }
}