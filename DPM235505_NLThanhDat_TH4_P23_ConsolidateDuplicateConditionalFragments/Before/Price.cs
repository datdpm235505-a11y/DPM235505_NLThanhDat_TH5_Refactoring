using System;

namespace DPM235505_NLThanhDat_TH4_P23_ConsolidateDuplicateConditionalFragments.Before
{
    public class Price
    {
        public void CalculateTotal(bool isSpecialDeal, double price)
        {
            double total;
            if (isSpecialDeal)
            {
                total = price * 0.95;
                Console.WriteLine("Gửi hóa đơn cho khách: " + total); // Trùng lặp
            }
            else
            {
                total = price * 0.98;
                Console.WriteLine("Gửi hóa đơn cho khách: " + total); // Trùng lặp
            }
        }
    }
}