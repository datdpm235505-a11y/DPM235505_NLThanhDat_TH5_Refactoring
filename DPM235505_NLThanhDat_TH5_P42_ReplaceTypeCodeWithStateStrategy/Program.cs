using System;
using DPM235505_NLThanhDat_TH5_P42_ReplaceTypeCodeWithStateStrategy.After;
using DPM235505_NLThanhDat_TH5_P42_ReplaceTypeCodeWithStateStrategy.Real;

namespace DPM235505_NLThanhDat_TH5_P42_ReplaceTypeCodeWithStateStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            EmployeeRefactored emp = new EmployeeRefactored();
            emp.Type = new Salesman(); // Chuyển sang Salesman
            Console.WriteLine("Lương: " + emp.PayAmount());

            Console.WriteLine("\n--- REAL ---");
            DonHangVanChuyen dh = new DonHangVanChuyen { TrongLuongKg = 2.5 };

            Console.WriteLine("Khách chọn Giao thường:");
            dh.InPhiGiaoHang();

            Console.WriteLine("\nKhách đổi ý, muốn Giao hỏa tốc:");
            dh.HinhThuc = new GiaoHangHoaToc(); // Thay đổi Strategy dễ dàng
            dh.InPhiGiaoHang();

            Console.ReadLine();
        }
    }
}