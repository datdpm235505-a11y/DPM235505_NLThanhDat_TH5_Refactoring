using System;
using DPM235505_NLThanhDat_TH5_P36_ExtractSubclass.After;
using DPM235505_NLThanhDat_TH5_P36_ExtractSubclass.Real;

namespace DPM235505_NLThanhDat_TH5_P36_ExtractSubclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            LaborItem labor = new LaborItem { UnitPrice = 50, Employee = "Alice" };
            Console.WriteLine($"Công việc của {labor.Employee} có đơn giá {labor.UnitPrice}");

            Console.WriteLine("\n--- REAL ---");
            SanPhamDienTu sp = new SanPhamDienTu { TenSP = "Laptop Dell", GiaBan = 20000000, ThoiGianBaoHanhThang = 24 };
            sp.InThongTin();

            Console.ReadLine();
        }
    }
}