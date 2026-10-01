using System;
using DPM235505_NLThanhDat_TH4_P04_InlineTemp.Before;
using DPM235505_NLThanhDat_TH4_P04_InlineTemp.After;
using DPM235505_NLThanhDat_TH4_P04_InlineTemp.Real;

namespace DPM235505_NLThanhDat_TH4_P04_InlineTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- BEFORE (Chưa Refactor) ---");
            Order before = new Order(1200);
            Console.WriteLine("Hóa đơn 1200 có được giảm giá không? " + before.HasDiscount());

            Console.WriteLine("\n--- AFTER (Đã Refactor - Gộp biến) ---");
            OrderRefactored after = new OrderRefactored(900);
            Console.WriteLine("Hóa đơn 900 có được giảm giá không? " + after.HasDiscount());

            Console.WriteLine("\n--- REAL (Ứng dụng Xét thăng cấp Nhân viên) ---");
            // Giả sử nhân viên vào làm năm 2022
            NhanVienThangCap nv = new NhanVienThangCap(2022);
            nv.KiemTraThangCap("Thành Đạt");

            Console.ReadLine();
        }
    }
}