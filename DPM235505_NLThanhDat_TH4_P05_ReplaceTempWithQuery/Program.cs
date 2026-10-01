using System;
using DPM235505_NLThanhDat_TH4_P05_ReplaceTempWithQuery.Before;
using DPM235505_NLThanhDat_TH4_P05_ReplaceTempWithQuery.After;
using DPM235505_NLThanhDat_TH4_P05_ReplaceTempWithQuery.Real;

namespace DPM235505_NLThanhDat_TH4_P05_ReplaceTempWithQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- BEFORE (Chưa Refactor) ---");
            Product before = new Product(10, 150); // Tổng 1500 > 1000 => giảm 5%
            Console.WriteLine("Thành tiền: " + before.CalculateTotal());

            Console.WriteLine("\n--- AFTER (Đã Refactor) ---");
            ProductRefactored after = new ProductRefactored(10, 150);
            Console.WriteLine("Thành tiền: " + after.CalculateTotal());

            Console.WriteLine("\n--- REAL (Ứng dụng Tính lương thực lãnh Nhân viên) ---");
            NhanVienNetSalary nv1 = new NhanVienNetSalary(200, 120000); // 24 triệu
            nv1.InPhieuLuong("Thành Đạt");

            NhanVienNetSalary nv2 = new NhanVienNetSalary(150, 100000); // 15 triệu
            nv2.InPhieuLuong("Nguyễn Văn A");

            Console.ReadLine();
        }
    }
}