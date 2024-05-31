namespace Food_Crop
{
    public class Buying
    {
        public event EventHandler<(int rowIndex, int colIndex)>? AmountModified;
        private string[] provs = new string[] { };
        private string[] crops = new string[] { };
        private double[,] amounts = new double[,] { };
        public string[] Provinces => provs;
        public string[] Crops => crops;
        public Buying(string[] provs, string[] crops)
        {
            if (provs != null) this.provs = provs;
            if (crops != null) this.crops = crops;
            amounts = new double[this.provs.Length, this.crops.Length];
        }
        public double TotalRow(int index)
        {
            double result = 0.0;
            for (int c = 0; c < amounts.GetLength(1); c++) result += amounts[index, c];
            return result;
        }
        public double TotalColumn(int index)
        {
            double result = 0.0;
            for (int r = 0; r < amounts.GetLength(0); r++) result += amounts[r, index];
            return result;
        }
        public double Total()
        {
            double result = 0.0;
            foreach (var e in amounts) result += e;
            return result;
        }
        public bool SetValue(double value, int rowIndex, int colIndex, bool isAddedUp = false)
        {
            double? currentAmount = GetValue(rowIndex, colIndex);
            if (currentAmount == null) return false;
            double newValue = value;
            if (isAddedUp) newValue += currentAmount.Value;
            amounts[rowIndex, colIndex] = newValue;
            AmountModified?.Invoke(this, (rowIndex, colIndex));
            return true;
        }
        public double? GetValue(int rowIndex, int colIndex)
        {
            if ((rowIndex < 0 || rowIndex > amounts.GetLength(0))
            || (colIndex < 0 || colIndex > amounts.GetLength(1)))
                return null;
            return amounts[rowIndex, colIndex];
        }
    }
}
