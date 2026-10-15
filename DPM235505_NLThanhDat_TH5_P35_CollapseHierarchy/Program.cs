using System;
using DPM235505_NLThanhDat_TH5_P35_CollapseHierarchy.After;
using DPM235505_NLThanhDat_TH5_P35_CollapseHierarchy.Real;

namespace DPM235505_NLThanhDat_TH5_P35_CollapseHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            EmployeeRefactored emp = new EmployeeRefactored { Name = "John", BaseSalary = 1000 };
            Console.WriteLine($"Tên: {emp.Name}, Lương cơ bản: {emp.BaseSalary}");

            Console.WriteLine("\n--- REAL ---");
            NhanVien nv = new NhanVien { TenNV = "Thành Đạt", PhongBan = "Phòng IT" };
            nv.InThongTin();

            Console.ReadLine();
        }
    }
}