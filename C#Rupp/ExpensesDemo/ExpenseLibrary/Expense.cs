namespace ExpenseLibrary
{
    public class Expense
    {
        public long No { get; set; } = 0;
        public string Text { get; set; } = ""; 
        public string Branch { get; set; } = "";
        public double Amount { get; set; } = 0.0;
    }

}