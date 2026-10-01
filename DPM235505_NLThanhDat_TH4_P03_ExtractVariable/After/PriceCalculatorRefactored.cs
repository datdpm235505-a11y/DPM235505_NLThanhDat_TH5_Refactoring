using System;

namespace DPM235505_NLThanhDat_TH4_P03_ExtractVariable.After
{
    public class PriceCalculatorRefactored
    {
        public double CalculateTotal(double quantity, double itemPrice)
        {
            // Đã tách ra thành các biến có ý nghĩa rõ ràng
            double basePrice = quantity * itemPrice;
            double quantityDiscount = Math.Max(0, quantity - 500) * itemPrice * 0.05;
            double shipping = Math.Min(basePrice * 0.1, 100.0);

            return basePrice - quantityDiscount + shipping;
        }
    }
}