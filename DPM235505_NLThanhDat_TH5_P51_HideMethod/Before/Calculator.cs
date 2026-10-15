namespace DPM235505_NLThanhDat_TH5_P51_HideMethod.Before
{
    public class Calculator
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

        // Hàm này chỉ dùng nội bộ, nhưng lại để public (Bad smell)
        public int Add(int a, int b) => a + b;
    }
}