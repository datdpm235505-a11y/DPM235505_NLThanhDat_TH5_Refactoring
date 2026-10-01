using System;
using DPM235505_NLThanhDat_TH4_P18_IntroduceAssertion.After;
using DPM235505_NLThanhDat_TH4_P18_IntroduceAssertion.Real;

namespace DPM235505_NLThanhDat_TH4_P18_IntroduceAssertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            EmployeeRefactored emp = new EmployeeRefactored();
            Console.WriteLine($"Hạn mức chi tiêu: {emp.GetExpenseLimit()}");

            Console.WriteLine("\n--- REAL ---");
            KiemTraDoanhThu kt = new KiemTraDoanhThu();
            kt.XuLyDoanhThu("Nhà sách Thành Đạt", 20000000);

            Console.ReadLine();
        }
    }
}