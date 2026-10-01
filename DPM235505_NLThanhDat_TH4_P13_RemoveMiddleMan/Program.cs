using System;
using DPM235505_NLThanhDat_TH4_P13_RemoveMiddleMan.After;
using DPM235505_NLThanhDat_TH4_P13_RemoveMiddleMan.Real;

namespace DPM235505_NLThanhDat_TH4_P13_RemoveMiddleMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            var p = new PersonRefactored();
            p.Department.Manager = "Alice";
            Console.WriteLine("Manager: " + p.Department.Manager); // Truy cập thẳng

            Console.WriteLine("\n--- REAL ---");
            var nv = new NhanVien { TenNV = "Thành Đạt" };
            nv.HoSo.SoBaoHiem = "BHXH-123456789";
            Console.WriteLine($"Nhân viên {nv.TenNV} có Số BHXH là: {nv.HoSo.SoBaoHiem}");

            Console.ReadLine();
        }
    }
}