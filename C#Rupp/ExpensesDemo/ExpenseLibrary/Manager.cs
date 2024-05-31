using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseLibrary
{
    public class Manager
    {
        private List<Expense> _expenses = new List<Expense>();
        public Manager(int expLength, int branchLength)
        {
            _expenses=GenerateExpenses(expLength, branchLength);
        }
        public List<Expense> GenerateExpenses(int expLength, int branchLength)
        {
            var branches = new List<string>();
            for (int k = 1; k <= branchLength; k++) 
                branches.Add("Branch" + k);
            var result = new List<Expense>();
            Random rand = new Random();
            for (int no = 1; no <= expLength; no++)
            {
                result.Add(new Expense()
                {
                    No = no,
                    Text = "Expense " + no,
                    Branch = branches[no%100],
                    Amount = rand.NextDouble() * 1000
                });
            }
            return result;
        }

        public List<Expense> GetExpList()
        {
            var result = new List<Expense>();
            _expenses.ForEach(e =>
            {
                if (!result.Exists(r=>r.No==e.No)) 
                {
                    result.Add(e);
                }
            });
            return result;
        }
        public Dictionary<long, Expense> GetExpDictNo()
        {
            Dictionary<long, Expense> result = new Dictionary<long, Expense>();
            _expenses.ForEach(e =>
            {
                try
                {
                    result.Add(e.No, e);
                }
                catch (Exception) { }
            });
            return result;
        }
        public Dictionary<string, List<Expense>> GetExpDictBranch()
        {
            Dictionary<string, List<Expense>> result = new Dictionary<string, List<Expense>>();
            _expenses.ForEach(e =>
            {
                if (result.TryGetValue(e.Branch, out List<Expense>? lst))
                {
                    lst.Add(e);
                }
                else
                {
                    result.Add(e.Branch, new List<Expense>() { e });
                }
            });
            return result;
        }
    }

}