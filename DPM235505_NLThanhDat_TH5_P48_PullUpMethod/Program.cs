using System;
using DPM235505_NLThanhDat_TH5_P48_PullUpMethod.After;
using DPM235505_NLThanhDat_TH5_P48_PullUpMethod.Real;

namespace DPM235505_NLThanhDat_TH5_P48_PullUpMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            Manager mgr = new Manager();
            Console.WriteLine("Thưởng quản lý: " + mgr.CalculateBonus(20000));

            Console.WriteLine("\n--- REAL ---");
            XeOto oto = new XeOto { TenPhuongTien = "VinFast VF8" };
            oto.KhoiDongMay(); // Sử dụng phương thức kế thừa từ Lớp cha

            Console.ReadLine();
        }
    }
}