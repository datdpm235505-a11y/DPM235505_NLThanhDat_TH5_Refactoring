using System;
using DPM235505_NLThanhDat_TH4_P11_InlineClass.After;
using DPM235505_NLThanhDat_TH4_P11_InlineClass.Real;

namespace DPM235505_NLThanhDat_TH4_P11_InlineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            var p = new PersonRefactored { Name = "Smith", PhoneNumber = "0901234567" };
            Console.WriteLine($"Name: {p.Name}, Phone: {p.PhoneNumber}");

            Console.WriteLine("\n--- REAL ---");
            var nv = new NhanVien { TenNV = "Thành Đạt", TenChucVu = "Trưởng phòng IT" };
            nv.InThongTin();

            Console.ReadLine();
        }
    }
}