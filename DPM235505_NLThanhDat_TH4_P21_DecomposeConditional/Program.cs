using System;
using DPM235505_NLThanhDat_TH4_P21_DecomposeConditional.After;
using DPM235505_NLThanhDat_TH4_P21_DecomposeConditional.Real;

namespace DPM235505_NLThanhDat_TH4_P21_DecomposeConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            PriceCalculatorRefactored calc = new PriceCalculatorRefactored();
            Console.WriteLine("Giá cước tháng 1 (Mùa đông): " + calc.CalculateCharge(new DateTime(2026, 1, 15), 10));

            Console.WriteLine("\n--- REAL ---");
            GiaVePhim rapPhim = new GiaVePhim();
            rapPhim.TinhTienVe(DayOfWeek.Sunday, 2); // Đi xem cuối tuần
            rapPhim.TinhTienVe(DayOfWeek.Wednesday, 2); // Đi xem giữa tuần

            Console.ReadLine();
        }
    }
}