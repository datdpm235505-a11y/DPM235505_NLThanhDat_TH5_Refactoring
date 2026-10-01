using System;
using DPM235505_NLThanhDat_TH4_P01_ExtractMethod.Before;
using DPM235505_NLThanhDat_TH4_P01_ExtractMethod.After;
using DPM235505_NLThanhDat_TH4_P01_ExtractMethod.Real;

namespace DPM235505_NLThanhDat_TH4_P01_ExtractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- BEFORE (Chưa Refactor) ---");
            OrderProcessor before = new OrderProcessor();
            before.PrintOwing("Thành Đạt", 100);

            Console.WriteLine("\n--- AFTER (Đã Refactor - Tách hàm) ---");
            OrderProcessorRefactored after = new OrderProcessorRefactored();
            after.PrintOwing("Thành Đạt", 100);

            Console.WriteLine("\n--- REAL (Ứng dụng thực tế) ---");
            NhanVienSalary realApp = new NhanVienSalary();
            realApp.XuLyTraLuong("Thành Đạt", 15000000, 24);

            Console.ReadLine();
        }
    }
}