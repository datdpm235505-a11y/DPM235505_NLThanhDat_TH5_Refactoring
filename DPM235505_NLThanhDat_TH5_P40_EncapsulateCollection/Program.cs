using System;
using DPM235505_NLThanhDat_TH5_P40_EncapsulateCollection.After;
using DPM235505_NLThanhDat_TH5_P40_EncapsulateCollection.Real;

namespace DPM235505_NLThanhDat_TH5_P40_EncapsulateCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            PersonRefactored p = new PersonRefactored();
            p.AddCourse(new CourseRefactored { Name = "C# Cơ bản" });
            Console.WriteLine($"Số khóa học: {p.Courses.Count} (Không thể gọi p.Courses.Add() từ đây)");

            Console.WriteLine("\n--- REAL ---");
            DuAn da = new DuAn { TenDuAn = "Website Bán Sách" };
            da.ThemThanhVien("Thành Đạt");
            da.ThemThanhVien("Nguyễn A");
            // da.ThanhVien.Clear(); // <- Dòng này sẽ báo lỗi đỏ vì đã được đóng gói an toàn

            Console.ReadLine();
        }
    }
}