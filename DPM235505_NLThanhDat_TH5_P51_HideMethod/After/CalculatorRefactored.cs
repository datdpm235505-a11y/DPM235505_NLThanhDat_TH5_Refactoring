namespace DPM235505_NLThanhDat_TH5_P51_HideMethod.After
{
    public class CalculatorRefactored
    {
        public int CalculateTotal(int[] numbers)
        {
            int total = 0;
            foreach (var num in numbers)
            {
                total = Add(total, num);
            }
            return total;
        }

        // Chuyển thành private để giấu đi
        private int Add(int a, int b) => a + b;
    }
}