using System;
using DPM235505_NLThanhDat_TH5_P38_ReplaceDelegationWithInheritance.After;
using DPM235505_NLThanhDat_TH5_P38_ReplaceDelegationWithInheritance.Real;

namespace DPM235505_NLThanhDat_TH5_P38_ReplaceDelegationWithInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            EmployeeRefactored emp = new EmployeeRefactored { Name = "Alice" };
            Console.WriteLine("Tên nhân viên: " + emp.GetName());

            Console.WriteLine("\n--- REAL ---");
            KhachHangVIP vip = new KhachHangVIP { HoTen = "Thành Đạt", SDT = "0909123456", DiemTichLuy = 5000 };
            vip.InThongTinVIP();

            Console.ReadLine();
        }
    }
}