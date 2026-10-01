namespace DPM235505_NLThanhDat_TH4_P07_RemoveAssignmentsToParameters.Before
{
    public class DiscountCalculator
    {
        public int CalculateDiscount(int inputVal, int quantity, int yearToDate)
        {
            // Sửa trực tiếp tham số đầu vào (Bad smell)
            if (inputVal > 50)
                inputVal -= 2;

            if (quantity > 100)
                inputVal -= 1;

            if (yearToDate > 10000)
                inputVal -= 4;

            return inputVal;
        }
    }
}