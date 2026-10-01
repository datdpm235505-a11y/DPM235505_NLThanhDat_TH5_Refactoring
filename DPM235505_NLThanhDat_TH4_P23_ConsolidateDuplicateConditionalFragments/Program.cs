using System;
using DPM235505_NLThanhDat_TH4_P23_ConsolidateDuplicateConditionalFragments.After;
using DPM235505_NLThanhDat_TH4_P23_ConsolidateDuplicateConditionalFragments.Real;

namespace DPM235505_NLThanhDat_TH4_P23_ConsolidateDuplicateConditionalFragments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            PriceRefactored calc = new PriceRefactored();
            calc.CalculateTotal(true, 1000);

            Console.WriteLine("\n--- REAL ---");
            XuLyDonHang donHang = new XuLyDonHang();
            donHang.ThanhToan("Thành Đạt (VIP)", 500000, true);
            donHang.ThanhToan("Khách vãng lai", 500000, false);

            Console.ReadLine();
        }
    }
}