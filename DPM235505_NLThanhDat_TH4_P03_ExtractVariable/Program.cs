using System;
using DPM235505_NLThanhDat_TH4_P03_ExtractVariable.Before;
using DPM235505_NLThanhDat_TH4_P03_ExtractVariable.After;
using DPM235505_NLThanhDat_TH4_P03_ExtractVariable.Real;

namespace DPM235505_NLThanhDat_TH4_P03_ExtractVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- BEFORE (Chưa Refactor) ---");
            PriceCalculator before = new PriceCalculator();
            Console.WriteLine("Tổng tiền (Before): " + before.CalculateTotal(600, 50));

            Console.WriteLine("\n--- AFTER (Đã Refactor - Tách biến) ---");
            PriceCalculatorRefactored after = new PriceCalculatorRefactored();
            Console.WriteLine("Tổng tiền (After): " + after.CalculateTotal(600, 50));

            Console.WriteLine("\n--- REAL (Ứng dụng Tính thuế Nhân viên) ---");
            NhanVienTax nv = new NhanVienTax();
            // Lương 15 triệu, thưởng 2 triệu
            nv.TinhThueThuNhap("Thành Đạt", 15000000, 2000000);

            Console.ReadLine();
        }
    }
}