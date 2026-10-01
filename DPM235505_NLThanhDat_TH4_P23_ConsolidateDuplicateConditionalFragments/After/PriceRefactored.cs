using System;

namespace DPM235505_NLThanhDat_TH4_P23_ConsolidateDuplicateConditionalFragments.After
{
    public class PriceRefactored
    {
        public void CalculateTotal(bool isSpecialDeal, double price)
        {
            double total;
            if (isSpecialDeal)
            {
                total = price * 0.95;
            }
            else
            {
                total = price * 0.98;
            }

            // Đưa phần code trùng lặp ra khỏi if/else
            Console.WriteLine("Gửi hóa đơn cho khách: " + total);
        }
    }
}