using System;
using DPM235505_NLThanhDat_TH5_P44_ParameterizeMethod.After;
using DPM235505_NLThanhDat_TH5_P44_ParameterizeMethod.Real;

namespace DPM235505_NLThanhDat_TH5_P44_ParameterizeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            EmployeeRefactored emp = new EmployeeRefactored();
            emp.RaiseSalary(15); // Tăng 15%
            Console.WriteLine("Lương sau khi tăng: " + emp.Salary);

            Console.WriteLine("\n--- REAL ---");
            ThanhToanHoaDon hd = new ThanhToanHoaDon { TongTien = 1000000 };
            hd.ApDungMaGiamGia(20); // Dùng mã giảm 20%

            Console.ReadLine();
        }
    }
}