using System;
using DPM235505_NLThanhDat_TH4_P12_HideDelegate.After;
using DPM235505_NLThanhDat_TH4_P12_HideDelegate.Real;

namespace DPM235505_NLThanhDat_TH4_P12_HideDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            var p = new PersonRefactored { Name = "John" };
            p.SetDepartment(new Department { Manager = "Alice" });
            Console.WriteLine($"Manager of {p.Name} is {p.GetManager()}");

            Console.WriteLine("\n--- REAL ---");
            var nv = new NhanVien { TenNV = "Thành Đạt" };
            nv.CapNhatPhongBan(new PhongBan { TruongPhong = "Sếp Nguyễn Văn A" });
            nv.InThongTinSep();

            Console.ReadLine();
        }
    }
}