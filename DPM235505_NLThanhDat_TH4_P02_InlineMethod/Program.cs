using System;
using DPM235505_NLThanhDat_TH4_P02_InlineMethod.Before;
using DPM235505_NLThanhDat_TH4_P02_InlineMethod.After;
using DPM235505_NLThanhDat_TH4_P02_InlineMethod.Real;

namespace DPM235505_NLThanhDat_TH4_P02_InlineMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- BEFORE (Chưa Refactor) ---");
            RatingService before = new RatingService(6);
            Console.WriteLine("Rating: " + before.GetRating());

            Console.WriteLine("\n--- AFTER (Đã Refactor - Gộp hàm) ---");
            RatingServiceRefactored after = new RatingServiceRefactored(6);
            Console.WriteLine("Rating: " + after.GetRating());

            Console.WriteLine("\n--- REAL (Ứng dụng Đánh giá KPI Nhân viên) ---");
            NhanVienBonus nv1 = new NhanVienBonus(65000000); // 65 triệu
            nv1.DanhGiaThuong("Thành Đạt");

            NhanVienBonus nv2 = new NhanVienBonus(30000000); // 30 triệu
            nv2.DanhGiaThuong("Nguyễn Văn A");

            Console.ReadLine();
        }
    }
}