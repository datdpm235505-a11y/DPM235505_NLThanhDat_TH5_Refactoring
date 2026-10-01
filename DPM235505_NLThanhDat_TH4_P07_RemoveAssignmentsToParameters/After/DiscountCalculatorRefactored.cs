namespace DPM235505_NLThanhDat_TH4_P07_RemoveAssignmentsToParameters.After
{
    public class DiscountCalculatorRefactored
    {
        public int CalculateDiscount(int inputVal, int quantity, int yearToDate)
        {
            // Gán sang biến cục bộ mới để thao tác
            int result = inputVal;

            if (inputVal > 50)
                result -= 2;

            if (quantity > 100)
                result -= 1;

            if (yearToDate > 10000)
                result -= 4;

            return result;
        }
    }
}