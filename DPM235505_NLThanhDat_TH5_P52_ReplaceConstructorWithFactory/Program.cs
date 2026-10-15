using System;
using DPM235505_NLThanhDat_TH5_P52_ReplaceConstructorWithFactory.After;
using DPM235505_NLThanhDat_TH5_P52_ReplaceConstructorWithFactory.Real;

namespace DPM235505_NLThanhDat_TH5_P52_ReplaceConstructorWithFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            EmployeeRefactored emp = EmployeeRefactored.CreateEngineer(); // Gọi Factory Method
            Console.WriteLine("Mã loại nhân viên (0-Engineer, 1-Sale): " + emp.Type);

            Console.WriteLine("\n--- REAL ---");
            TaiKhoanNganHang tkSV = TaiKhoanNganHang.MoTaiKhoanSinhVien();
            TaiKhoanNganHang tkVIP = TaiKhoanNganHang.MoTaiKhoanVIP();

            tkSV.InThongTin();
            tkVIP.InThongTin();

            Console.ReadLine();
        }
    }
}