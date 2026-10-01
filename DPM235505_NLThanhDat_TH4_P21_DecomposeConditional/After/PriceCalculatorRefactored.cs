using System;

namespace DPM235505_NLThanhDat_TH4_P21_DecomposeConditional.After
{
    public class PriceCalculatorRefactored
    {
        public double CalculateCharge(DateTime date, double quantity)
        {
            // Code đọc dễ hiểu như tiếng Anh thông thường
            if (IsNotSummer(date))
                return WinterCharge(quantity);
            else
                return SummerCharge(quantity);
        }

        private bool IsNotSummer(DateTime date) => date.Month < 6 || date.Month > 8;
        private double WinterCharge(double quantity) => quantity * 10 + 50;
        private double SummerCharge(double quantity) => quantity * 15;
    }
}