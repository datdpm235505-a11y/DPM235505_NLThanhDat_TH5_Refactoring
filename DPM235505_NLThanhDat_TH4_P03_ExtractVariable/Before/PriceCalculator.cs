using System;

namespace DPM235505_NLThanhDat_TH4_P03_ExtractVariable.Before
{
    public class PriceCalculator
    {
        public double CalculateTotal(double quantity, double itemPrice)
        {
            // Biểu thức tính toán quá dài và khó hiểu
            return quantity * itemPrice -
                   Math.Max(0, quantity - 500) * itemPrice * 0.05 +
                   Math.Min(quantity * itemPrice * 0.1, 100.0);
        }
    }
}