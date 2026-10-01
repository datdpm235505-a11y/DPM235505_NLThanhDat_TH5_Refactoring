using System;
using DPM235505_NLThanhDat_TH4_P07_RemoveAssignmentsToParameters.Before;
using DPM235505_NLThanhDat_TH4_P07_RemoveAssignmentsToParameters.After;
using DPM235505_NLThanhDat_TH4_P07_RemoveAssignmentsToParameters.Real;

namespace DPM235505_NLThanhDat_TH4_P07_RemoveAssignmentsToParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- BEFORE (Chưa Refactor) ---");
            DiscountCalculator before = new DiscountCalculator();
            Console.WriteLine("Giá sau giảm: " + before.CalculateDiscount(60, 150, 15000));

            Console.WriteLine("\n--- AFTER (Đã Refactor) ---");
            DiscountCalculatorRefactored after = new DiscountCalculatorRefactored();
            Console.WriteLine("Giá sau giảm: " + after.CalculateDiscount(60, 150, 15000));

            Console.WriteLine("\n--- REAL (Ứng dụng Tính thưởng Nhân viên) ---");
            NhanVienThuong nv = new NhanVienThuong();
            nv.TinhTienThuong("Thành Đạt", 1000000, 95);
            nv.TinhTienThuong("Nguyễn Văn A", 1000000, 45);

            Console.ReadLine();
        }
    }
}